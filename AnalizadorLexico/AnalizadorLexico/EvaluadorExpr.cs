using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorLexico
{
    class EvaluadorExpr
    {
        string Expresion;
        public float result;
        public string ExprPost;
        public AnalizLexico L;
        
        public EvaluadorExpr(string sigma, AFD AutFD)
        {
            Expresion = sigma;
            L = new AnalizLexico(Expresion, AutFD);
        }
        public EvaluadorExpr(string sigma, string FileAFD, int IdentifAFD)
        {
            Expresion = sigma;
            L = new AnalizLexico(Expresion, FileAFD, IdentifAFD);
        }
        public EvaluadorExpr(string FileAFD, int IdentifAFD)
        {
            L = new AnalizLexico(FileAFD, IdentifAFD);
        }

        public void setExpresion(string sigma)
        {
            Expresion = sigma;
            L.SetSigma(sigma);
        }

        public bool IniEval()
        {
            int Token;
            float v;
            string Postfijo = "";
            v = (float)0;
            
            if( E(ref v,ref Postfijo) )
            {
                Token = L.yylex();
                if(Token == 0)
                {
                    this.result = v;
                    this.ExprPost = Postfijo;
                    return true;
                }
            }
            return false;
        }

        bool E(ref float v, ref string Post)
        {
            if (T(ref v, ref Post))
                if (Ep(ref v, ref Post))
                    return true;
            return false;
        }

        bool Ep(ref float v, ref string Post)
        {
            int Token;
            float v2 = 0;
            string Post2 = "";
            Token = L.yylex();
            if(Token == 10 || Token == 20) // + o -
            {
                if( T(ref v2, ref Post2))
                {
                    v = v + (Token == 10 ? v2 : -v2);
                    Post = Post + " " + Post2 + (Token == 10 ? "+" : "-");
                    if (Ep(ref v, ref Post))
                        return true;
                }
                return false;
            }
            L.UndoToken();
            return true;
        }
        bool T(ref float v, ref string Post)
        {
            if (F(ref v, ref Post))
                if (Tp(ref v, ref Post))
                    return true;
            return false;
        }
        bool Tp(ref float v, ref string Post)
        {
            int Token;
            float v2 = 0;
            string Post2 = "";
            Token = L.yylex();
            if(Token == 30 || Token == 40)  // * o /
            {
                if(F(ref v2, ref Post2))
                {
                    v = v * (Token == 30 ? v2 : 1 / v2);
                    Post = Post + " " + Post2 + " " + (Token == 30 ? "*" : "/");
                    if (Tp(ref v, ref Post))
                        return true;
                }
                return false;
            }
            L.UndoToken();
            return true;
        }
        bool F(ref float v, ref string Post)
        {
            int Token;
            Token = L.yylex();
            switch (Token)
            {
                case 50: //parentesis izquierdo
                    if(E(ref v, ref Post))
                    {
                        Token = L.yylex();
                        if (Token == 60) //parentesis derecho
                            return true;
                    }
                    return false;
                case 70:    //NUM
                    v = float.Parse(L.Lexema);
                    Post = L.Lexema;
                    return true;
            }
            return false;
        }

    }
}
