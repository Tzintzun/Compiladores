using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace AnalizadorLexico
{
    class SimbTerm
    {
        public string simbolo;
        public int valToken;
        public SimbTerm(string simb, int token)
        {
            simbolo = simb;
            valToken = token;
        }
        public SimbTerm()
        {
            simbolo = "";
            valToken = -1;
        }
    }
    class Simbolo
    {
        public string simbolo;
        public int valToken;
        public bool isTerminal;
        public Simbolo(string simb,bool isTerminal, int token)
        {
            simbolo = simb;
            valToken = token;
            this.isTerminal = isTerminal;
        }
        public Simbolo()
        {
            simbolo = "";
            valToken = -1;
        }
    }
    class AnalizadorLL1
    {
        DescRecGram_Gram DesRecG;
        AnalizLexico lexGram;
        public string gram;
        public string sigma;
        public int[,] tablaLL1;
        public SimbTerm[] vt;
        public string[] vt2;
        public string[] vn;
        const string ArchAFDLexiGramGram = "C:\\Users\\david\\Desktop\\Semestre 7\\Compiladores\\TxtGram_Gram.txt";

        public AnalizadorLL1(string cadGramatica, string ArchAFDLexic)
        {
            gram = cadGramatica;
            DesRecG = new DescRecGram_Gram(cadGramatica, ArchAFDLexiGramGram, 0);
            lexGram = new AnalizLexico(ArchAFDLexic, 1);
        }
        public AnalizadorLL1(string cadGramatica)
        {
            gram = cadGramatica;
            DesRecG = new DescRecGram_Gram(cadGramatica, ArchAFDLexiGramGram, 0);
        }
        public void setLexico(string ArchAFDLexic)
        {
            lexGram = new AnalizLexico(ArchAFDLexic, 0);
        }

        public bool crearTablaLL1()
        {
            int i;
            HashSet<string> first = new HashSet<string>();
            HashSet<string> follow = new HashSet<string>();

            bool resultadoAnalisis = DesRecG.AnalizarGramatica();
            if (!resultadoAnalisis)
            {
                return resultadoAnalisis;
            }
            vt = new SimbTerm[DesRecG.vt.Count + 1];
            vt2 = new string[DesRecG.vt.Count + 1];

            vn = new string[DesRecG.vn.Count + 1];
            i = 0;
            // Llena los dos arreglos de terminales
            foreach(string s in DesRecG.vt)
            {
                vt[i] = new SimbTerm(s, -1);
                vt2[i++] = s;
            }
            // Final de cadena
            vt[i] = new SimbTerm("$", -1);
            vt2[i++] = "$";

            i = 0;
            // Llena el arreglo de no terminales
            foreach (string s in DesRecG.vn)
                vn[i++] = s;
            vn[i++] = "$";

            tablaLL1 = new int[DesRecG.vn.Count + 1, DesRecG.vt.Count + 1];
            for (int j = 0; j <= DesRecG.vn.Count; j++)
                for (int k = 0; k <= DesRecG.vt.Count; k++)
                    tablaLL1[j, k] = -1;
            
            int row;
            int col;
            for(i = 0; i < DesRecG.NumReglas; i++)
            {
                first.Clear();
                follow.Clear();

                row = Array.IndexOf(vn, DesRecG.arrReglas[i].infSimbolo.simbolo);

                first = DesRecG.First(DesRecG.arrReglas[i].listaLadoDerecho);
                foreach(string s in first)
                {
                    col = Array.IndexOf(vt2, s);
                    if (col >= 0)
                        tablaLL1[row, col] = i + 1;
                }
                // Si hay epsilon en el fist se calcula el follow del lado izquierdo
                if(first.Contains("epsilon"))
                {
                    follow = DesRecG.Follow(DesRecG.arrReglas[i].infSimbolo.simbolo);
                    foreach(string s in follow)
                    {
                        col = Array.IndexOf(vt2, s);
                        tablaLL1[row, col] = i + 1;
                    }
                }
            }
            return resultadoAnalisis;
        }


        public bool analizarSintacticamente(string cad,DataGridView tabla)
        {
            int  tokenyylex,renglon = -1,columna = -1,accion=-1;
            Stack<Simbolo> pila = new Stack<Simbolo>();
            pila.Clear();
            sigma = cad;
            int numeroEstados = 0;
            string cadena = "";
            lexGram.SetSigma(sigma);
            Simbolo extraerSimbolo;
            Simbolo simbolo = new Simbolo(vn[0],false,-1);
            pila.Push(simbolo);
            tabla.Rows.Clear();
            tabla.Columns.Clear();
            tabla.RowHeadersVisible = false;
            tabla.AllowUserToAddRows = false;

            tabla.Columns.Add("pila", "Pila");
            tabla.Columns.Add("cadena", "Cadena");
            tabla.Columns.Add("accion", "Accion");
            tokenyylex = lexGram.yylex();

            while(true)
            {
                if (pila.Count == 0 && tokenyylex == 0)
                {
                    return true;
                }else if(pila.Count == 0 && tokenyylex != 0)
                {
                    return false;
                }
                Simbolo[] aux = pila.ToArray<Simbolo>();
                Array.Reverse(aux);
                tabla.Rows.Add();
                string cadenaPila = "";
                foreach (Simbolo sim in aux)
                {
                    cadenaPila += sim.simbolo + " ";
                }
                tabla.Rows[numeroEstados].Cells[0].Value = cadenaPila;
                tabla.Rows[numeroEstados].Cells[1].Value = cadena.Length > 0 ? cad.Replace(cadena, " ") : cad;
                string accionesTabla = "";
                extraerSimbolo = pila.Pop();
                
                if (extraerSimbolo.isTerminal)
                {
                    if (extraerSimbolo.valToken == tokenyylex)
                    {
                        cadena += lexGram.Lexema;
                        tokenyylex = lexGram.yylex();
                        tabla.Rows[numeroEstados].Cells[2].Value = "POP";
                        numeroEstados++;
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }

                renglon = Array.IndexOf(vn, extraerSimbolo.simbolo);

                for (int i = 0; i < vt.Length; i++)
                {
                    if (vt[i].valToken == tokenyylex)
                    {
                        columna = i;
                        break;
                    }
                }
                if (renglon >= 0 || columna >= 0)
                {
                    accion = tablaLL1[renglon, columna];
                }

                

                if (accion != -1)
                {
                    foreach (Nodo nod in DesRecG.arrReglas[accion - 1].listaLadoDerecho)
                    {
                        accionesTabla += nod.simbolo + " ";
                    }
                    tabla.Rows[numeroEstados].Cells[2].Value = accionesTabla;
                    numeroEstados++;
                    for (int i = DesRecG.arrReglas[accion - 1].listaLadoDerecho.Count-1; i >= 0; i--)
                    {
                        int TokenActual = -1;
                        Nodo n = DesRecG.arrReglas[accion - 1].listaLadoDerecho[i];
                        if (n.simbolo.Equals("epsilon"))
                        {
                            continue;
                        }
                        if (n.terminal)
                        {
                            
                            foreach(SimbTerm st in vt)
                            {
                                if (st.simbolo.Equals(n.simbolo))
                                {
                                    TokenActual = st.valToken;
                                    break;
                                }
                            }

                            
                        }
                        pila.Push(new Simbolo(n.simbolo,n.terminal,TokenActual));

                    }
                }
                else
                {
                    return false;
                }

            } 


            
        }
    }
}
