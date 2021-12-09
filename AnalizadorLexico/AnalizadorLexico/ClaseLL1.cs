using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        const string ArchAFDLexiGramGram = "";

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

        public void crearTablaLL1()
        {
            int i;
            HashSet<string> first = new HashSet<string>();
            HashSet<string> follow = new HashSet<string>();

            DesRecG.AnalizarGramatica();
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
                    tablaLL1[k, 1] = -1;
            
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
        }
    }
}
