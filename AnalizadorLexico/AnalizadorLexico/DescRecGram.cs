using System;
using AnalizadorLexico;

class DescRecGram_Gram
{
    public string Gramatica;
    public AnalizLexico L;
    public DescRecGram_Gram(string sigma, string FileAFD, int IdentifAFD)
    {
        Gramatica = sigma;
        L = new AnalizLexico(Gramatica, FileAFD, IdentifAFD);
    }

    public bool AnalizarGramatica()
    {
        int token;
        if (G())
        {
            token = L.yylex();
            if (token == 0)
                return true;
        }
        return false;
    }

    public bool G()
    {
        if (ListaReglas())
            return true;
        return false;
    }

    public bool ListaReglas()
    {
        int token;
        if (Reglas())
        {
            token = L.yylex();
            if (token == TokensGram_Gram.PC)
                if (ListaReglasP())
                    return true;
        }
        return false;
    }

    bool ListaReglasP()
    {
        int token;
        ClassEstadoAnalizLexico e;
        e = L.GetEdoAnalizLexico();
        if (Reglas())
        {
            token = L.yylex();
            if(token == TokensGram_Gram.PC)
            {
                if (ListaReglasP())
                    return true;
            }
            return false;
        }
        //epsilon
        L.SetEdoAnalizLexico(e);
        return true;
    }

    bool Reglas()
    {
        int token;
        if (LadoIzquierdo())
        {
            token = L.yylex();
            if (token == TokensGram_Gram.FLECHA)
                if (LadosDerechos())
                    return true;
        }
        return false;
    }

    bool LadoIzquierdo()
    {
        int token;
        token = L.yylex();
        if (token == TokensGram_Gram.SIMBOLO)
            return true;
        return false;
    }

    bool LadosDerechos()
    {
        if (LadoDerecho())
            if (LadosDerechosP())
                return true;
        return false;
    }

    bool LadosDerechosP()
    {
        int token;
        token = L.yylex();
        if(token == TokensGram_Gram.OR)
        {
            if (LadoDerecho())
                if (LadosDerechosP())
                    return true;
            return false;
        }
        L.UndoToken();
        return true; 
    }

    bool LadoDerecho()
    {
        if (SecSimbolos())
            return true;
        return false;
    }

    bool SecSimbolos()
    {
        int token;
        token = L.yylex();
        if (token == TokensGram_Gram.SIMBOLO)
            if (SecSimbolosP())
                return true;
        return false;
    }

    bool SecSimbolosP()
    {
        int token;
        token = L.yylex();
        if(token == TokensGram_Gram.SIMBOLO)
        {
            if (SecSimbolosP())
                return true;
            return false;
        }
        L.UndoToken();
        return true;
    }

}
