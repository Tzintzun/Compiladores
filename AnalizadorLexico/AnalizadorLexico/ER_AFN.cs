using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorLexico
{
    class ER_AFN
    {
        string ExprRegular;
        public AFN result;
        public AnalizLexico L;

        public ER_AFN(string sigma, AFD AutFD)
        {
            ExprRegular = sigma;
            L = new AnalizLexico(ExprRegular, AutFD);
        }
        public ER_AFN(string sigma, string FileAFD, int IdentifAFD)
        {
            ExprRegular = sigma;
            L = new AnalizLexico(ExprRegular, FileAFD, IdentifAFD);
        }
        public ER_AFN(string FileAFD, int IdentifAFD)
        {
            L = new AnalizLexico(FileAFD, IdentifAFD);
        }

        public void SetExpresion(string sigma)
        {
            ExprRegular = sigma;
            L.SetSigma(sigma);
        }

        public bool IniConversion()
        {
            int Token;
            AFN f;
            f = new AFN();
            if (E(f))
            {
                Token = L.yylex();
                if(Token == 0)
                {
                    this.result = f;
                    return true;
                }
            }
            return false;
        }

        public bool E(AFN f)
        {
            if (T(f))
                if (Ep(f))
                    return true;
            return false;
        }

        public bool Ep(AFN f)
        {
            int Token;
            AFN f2 = new AFN();

            Token = L.yylex();
            if (Token == 10) // OR
            {
                if (T(f2))
                {
                    f.UnirAFN(f2);
                    if (Ep(f))
                        return true;
                }
                return false;
            }
            L.UndoToken();
            return true;
        }

        bool T(AFN f)
        {
            if (C(f))
                if (Tp(f))
                    return true;
            return false;
        }
        public bool Tp(AFN f)
        {
            int Token;
            AFN f2 = new AFN();

            Token = L.yylex();
            if(Token == 20) // CONCATENACIÓN
            {
                if(C(f2))
                {
                    f.ConcatenarAFN(f2);
                    if (Tp(f))
                        return true;
                }
                return false;
            }
            L.UndoToken();
            return true;
        }

        public bool C(AFN f)
        {
            if (F(f))
                if (Cp(f))
                    return true;
            return false;
        }

        public bool Cp(AFN f)
        {
            int Token;

            Token = L.yylex();
            switch(Token)
            {
                case 30: // CERRADURA TRANSITIVA
                    f.cerraduraPos();
                    if (Cp(f))
                        return true;
                    return false;
                case 40: // CERRADURA KLEEN
                    f.cerraduraKleen();
                    if (Cp(f))
                        return true;
                    return false;
                case 50: // OPCIONAL
                    f.opcional();
                    if (Cp(f))
                        return true;
                    return false;
            }
            L.UndoToken();
            return true;
        }

        public bool F(AFN f)
        {
            int Token;
            char simbolo1, simbolo2;
            Token = L.yylex();
            
            switch(Token)
            {
                case 60: // PAR_IZQ
                    if(E(f))
                    {
                        Token = L.yylex();
                        if (Token == 70) // PAR_DER
                            return true;
                    }
                    return false;
                case 80: // CORCHETE_IZQ
                    Token = L.yylex();
                    if(Token == 110) // SIMBOLO
                    {
                        simbolo1 = (L.Lexema[0] == '\\') ? L.Lexema[1] : L.Lexema[0];
                        Token = L.yylex();
                        if(Token == 100) // GUION
                        {
                            Token = L.yylex();
                            if(Token == 110) // SIMBOLO
                            {
                                simbolo2 = (L.Lexema[0] == '\\') ? L.Lexema[1] : L.Lexema[0];
                                Token = L.yylex();
                                if (Token == 90) // CORCHETE DERECHO
                                {
                                    f = new AFN();
                                    f.crearAFNBasico(simbolo1, simbolo2);
                                    return true;
                                }
                            }
                        }
                    }
                    return false;
                case 110: // SIMBOLO
                    simbolo1 = (L.Lexema[0] == '\\') ? L.Lexema[1] : L.Lexema[0];
                    f = new AFN();
                    f.crearAFNBasico(simbolo1);
                    return true;
            }
            return false;
        }
    }
}
