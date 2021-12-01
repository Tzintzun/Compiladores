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

        public void AgregarAFN(int id)
        {
            result.idAFN = id;
            AFN.ConjuntoAFNs.Add(result);
        }
        public bool IniConversion()
        {
            int Token;
            AFN f;
            f = new AFN();
            if (E(ref f))
            {
                Token = L.yylex();
                if(Token == 0)
                {
                    this.result = f;
                    //f.idAFN = result.idAFN;
                    //AFN.ConjuntoAFNs.Add(f);
                    return true;
                }
            }
            
            return false;
        }

        public bool E(ref AFN f)
        {
            if (T(ref f))
                if (Ep(ref f))
                    return true;
            return false;
        }

        public bool Ep(ref AFN f)
        {
            int Token;
            AFN f2 = new AFN();

            Token = L.yylex();
            if (Token == 10) // OR
            {
                if (T(ref f2))
                {
                    f.UnirAFN(f2);
                    if (Ep(ref f))
                        return true;
                }
                return false;
            }
            L.UndoToken();
            return true;
        }

        bool T(ref AFN f)
        {
            if (C(ref f))
                if (Tp(ref f))
                    return true;
            return false;
        }
        public bool Tp(ref AFN f)
        {
            int Token;
            AFN f2 = new AFN();

            Token = L.yylex();
            if(Token == 20) // CONCATENACIÓN
            {
                if(C(ref f2))
                {
                    f.ConcatenarAFN(f2);
                    if (Tp(ref f))
                        return true;
                }
                return false;
            }
            L.UndoToken();
            return true;
        }

        public bool C(ref AFN f)
        {
            if (F(ref f))
                if (Cp(ref f))
                    return true;
            return false;
        }

        public bool Cp(ref AFN f)
        {
            int Token;

            Token = L.yylex();
            switch(Token)
            {
                case 30: // CERRADURA TRANSITIVA
                    f.cerraduraPos();
                    if (Cp(ref f))
                        return true;
                    return false;
                case 40: // CERRADURA KLEEN
                    f.cerraduraKleen();
                    if (Cp(ref f))
                        return true;
                    return false;
                case 50: // OPCIONAL
                    f.opcional();
                    if (Cp(ref f))
                        return true;
                    return false;
            }
            L.UndoToken();
            return true;
        }

        public bool F(ref AFN f)
        {
            int Token;
            char simbolo1, simbolo2;
            Token = L.yylex();
            
            switch(Token)
            {
                case 60: // PAR_IZQ
                    if(E(ref f))
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
