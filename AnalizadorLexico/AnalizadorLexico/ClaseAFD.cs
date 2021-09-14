﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorLexico
{
    class TransEdoAFD
    {
        public int IdEdo;
        public int[] TransAFD;
    }
    public class AFD
    {
        public static HashSet<AFD> ConjAFDs = new HashSet<AFD>();
        public int NumEstados;
        public int CardAlfabeto;
        public char[] ArrAlfabeto;
        public int[,] TransicionesAFD;
        public int[,] TablaAFD;
        public int IdAFD;
        public AFD()
        {
            IdAFD = -1;
        }
        public AFD(int NumeroDeEstados, int IdAutFD)
        {
            TablaAFD = new int[NumeroDeEstados, 257];
            for (int i = 0; i < NumeroDeEstados; i++)
            {
                for (int j = 0; j < 257; j++)
                {
                    TablaAFD[i, j] = -1;
                }
            }
            NumEstados = NumeroDeEstados;
            IdAFD = IdAutFD;
            AFD.ConjAFDs.Add(this);
        }
    }
}
