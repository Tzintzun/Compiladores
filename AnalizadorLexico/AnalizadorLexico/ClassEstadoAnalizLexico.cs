using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorLexico
{
    class ClassEstadoAnalizLexico
    {
        public int token, EdoActual, EdoTransicion;

        public string Lexema;
        public bool PasoPorEdoAcept;
        public int IniLexema, FinLexema, IndiceCaracterActual;
        public char CaracterActual;
        public Stack<int> Pila = new Stack<int>();
        public ClassEstadoAnalizLexico()
        {
            token = 0;
            EdoActual = 0;
            EdoTransicion = -1;
            Lexema = "";
            PasoPorEdoAcept = false;
            IniLexema = -1;
            FinLexema = -1;
            IndiceCaracterActual = -1;
            CaracterActual = ' ';
            Pila.Clear();
        }
    }
}
