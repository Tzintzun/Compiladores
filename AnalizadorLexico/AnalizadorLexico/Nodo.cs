using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorLexico
{
    class Nodo
    {
        public string simbolo;
        public bool terminal;
        //public Nodo nodoSig; // Se usa una clase de C#
        public Nodo()
        {
            simbolo = "";
            terminal = false;
        }
        public Nodo(string simb)
        {
            simbolo = simb;
            terminal = false;
        }
        public Nodo(string simb, bool esTerminal)
        {
            simbolo = simb;
            terminal = esTerminal;
        }
    }
    class ElemArreglo
    {
        public Nodo infSimbolo;
        public List<Nodo> listaLadoDerecho;
        public ElemArreglo()
        {
            infSimbolo = new Nodo();
            listaLadoDerecho = new List<Nodo>();
        }
    }
}
