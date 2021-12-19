using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Analizador sintáctico por descenso recursivo
namespace AnalizadorLexico
{
    class DescRecGram_Gram
    {
        public string Gramatica;
        public AnalizLexico L;
        // Acciones Semánticas
        public ElemArreglo[] arrReglas = new ElemArreglo[100];
        public int NumReglas = 0;
        // División de conjunto de simbolos entre terminales y no terminales
        public HashSet<string> vn = new HashSet<string>(); // No terminales
        public HashSet<string> vt = new HashSet<string>(); // Terminales
        public DescRecGram_Gram(string sigma, string FileAFD, int IdentifAFD)
        {
            Gramatica = sigma;
            L = new AnalizLexico(Gramatica, FileAFD, IdentifAFD);
            vn.Clear();
            vt.Clear();
        }
        public DescRecGram_Gram(string FileAFD, int IdentiAFD)
        {
            L = new AnalizLexico(FileAFD, IdentiAFD);
            vn.Clear();
            vt.Clear();
        }
        public bool SetGramatica(string sigma)
        {
            vn.Clear();
            vt.Clear();
            Gramatica = sigma;
            L.SetSigma(sigma);
            return true;
        }

        public bool AnalizarGramatica()
        {
            int token;
            if (G())
            {
                token = L.yylex();
                if (token == 0)
                {
                    IdentificarTerminales();
                    return true;
                }
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
                if (token == TokensGram_Gram.PC)
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
            string simbolo = "";
            if (LadoIzquierdo(ref simbolo))
            {
                vn.Add(simbolo);
                token = L.yylex();
                if (token == TokensGram_Gram.FLECHA)
                    if (LadosDerechos(simbolo))
                        return true;
            }
            return false;
        }

        bool LadoIzquierdo(ref string simbolo)
        {
            int token;
            token = L.yylex();
            if (token == TokensGram_Gram.SIMBOLO)
            {
                simbolo = L.Lexema;
                return true;
            }
            return false;
        }

        bool LadosDerechos(string simbolo)
        {
            if (LadoDerecho(simbolo))
                if (LadosDerechosP(simbolo))
                    return true;
            return false;
        }

        bool LadosDerechosP(string simbolo)
        {
            int token;
            token = L.yylex();
            if (token == TokensGram_Gram.OR)
            {
                if (LadoDerecho(simbolo))
                {
                    if (LadosDerechosP(simbolo))
                    {
                        return true;
                    }
                }
                return false;
            }
            L.UndoToken();
            return true;
        }
        // Simbolo es el lado izquierdo de la regla gramatical
        bool LadoDerecho(string simbolo)
        {
            // Secuencia de simbolos
            List<Nodo> lista = new List<Nodo>();
            lista.Clear();
            // Crea la lista y agrega a la secuencia de simbolos
            if (SecSimbolos(ref lista))
            {
                arrReglas[NumReglas] = new ElemArreglo();
                arrReglas[NumReglas].infSimbolo = new Nodo(simbolo);
                arrReglas[NumReglas++].listaLadoDerecho = lista;
                return true;
            }
            return false;
        }

        bool SecSimbolos(ref List<Nodo> lista)
        {
            int token;
            Nodo n;
            token = L.yylex();
            if (token == TokensGram_Gram.SIMBOLO)
            {
                n = new Nodo(L.Lexema);
                // En lista se tienen todos los simbolos que aparecen despues de TokensGram_Gram.SIMBOLO
                if (SecSimbolosP(ref lista))
                {
                    lista.Insert(0, n);
                    return true;
                }
            }
            return false;
        }

        bool SecSimbolosP(ref List<Nodo> lista)
        {
            int token;
            Nodo n;
            token = L.yylex();
            if (token == TokensGram_Gram.SIMBOLO)
            {
                n = new Nodo(L.Lexema, false);
                if (SecSimbolosP(ref lista))
                {
                    lista.Insert(0, n);
                    return true;
                }
                return false;
            }
            L.UndoToken();
            return true;
        }
        void IdentificarTerminales()
        {
            int i;
            for(i = 0; i < NumReglas; i++)
            {
                foreach(Nodo n in arrReglas[i].listaLadoDerecho)
                {
                    if(!vn.Contains(n.simbolo))
                    {
                        n.terminal = true;
                        vt.Add(n.simbolo);
                    }
                }
            }
        }
        public HashSet<string> First(List<Nodo> lista)
        {
            int i, j;
            Nodo n;
            HashSet<string> R = new HashSet<string>();
            R.Clear();

            if (lista.Count == 0)
                return R;
            for(j = 0; j < lista.Count; j++)
            {
                n = lista[j];
                if(n.terminal || n.simbolo.Equals("epsilon"))
                {
                    R.Add(n.simbolo);
                    return R;
                }
                // N es no terminal
                // Se calcula el fisrt de cada lado derecho de este no terminal
                for(i = 0; i < NumReglas; i++)
                {
                    if (arrReglas[i].listaLadoDerecho[0].simbolo.Equals(n.simbolo)) // Ejemplo E - > E + T
                        continue;
                    if (arrReglas[i].infSimbolo.simbolo.Equals(n.simbolo))
                        R.UnionWith(First(arrReglas[i].listaLadoDerecho));
                }
                if(R.Contains("epsilon"))
                {
                    if (j == (lista.Count - 1))
                        continue;
                    R.Remove("epsilon");
                }
                else              
                    break;                
            }
            return R;
        }
        public HashSet<string> Follow(string simbolo) // Simbolo no terminal
        {
            HashSet<string> R = new HashSet<string>();
            HashSet<string> Aux = new HashSet<string>();
            List<Nodo> ListaPost = new List<Nodo>();
            int i, j, k;

            R.Clear();

            if (arrReglas[0].infSimbolo.simbolo.Equals(simbolo))
                R.Add("$");
            for(i = 0; i < NumReglas; i++) // Se busca simbolo en los lados derechos de todas las reglas
            {
                // Se recorre la lista del lado derecho buscando al simbolo
                for(j = 0; j < arrReglas[i].listaLadoDerecho.Count; j++)
                {
                    if(arrReglas[i].listaLadoDerecho[j].simbolo.Equals(simbolo))
                    {
                        ListaPost.Clear();
                        // Obtenemos la lista que corresponde a los simbolos que están después del simbolo
                        for (k = j + 1; k < arrReglas[i].listaLadoDerecho.Count; k++)
                            ListaPost.Add(arrReglas[i].listaLadoDerecho[k]);

                        // Si no hay más simbolos después del simbolo, se calcula el Follow del lado izquierdo de la regla
                        if (ListaPost.Count == 0) 
                        {
                            // Si el simbolo del lado izquierdo es igual al simbolo del que queremos calcular
                            // el follow, omitimos la regla
                            if (!arrReglas[i].infSimbolo.simbolo.Equals(simbolo))
                                R.UnionWith(Follow(arrReglas[i].infSimbolo.simbolo));
                            break;
                        }

                        // Se calcula el First de la lista 1 que está después del elemento j
                        Aux.Clear();
                        Aux = First(ListaPost);
                        if (Aux.Contains("epsilon"))
                        {
                            Aux.Remove("epsilon");
                            R.UnionWith(Aux);

                            if (!arrReglas[i].infSimbolo.simbolo.Equals(simbolo))
                            {
                                R.UnionWith(Follow(arrReglas[i].infSimbolo.simbolo));
                            }
                                
                        }
                        else
                            R.UnionWith(Aux);
                    }
                }
            }
            return R;
        }
    }
}
