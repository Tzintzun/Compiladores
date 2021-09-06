using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorLexico
{
    public class Transicion
    {
        private char SInf;
        private char Sdup;
        private Estado edo;

        public Transicion(char simb, Estado e)
        {
            SInf = simb;
            Sdup = simb;
            edo = e;
        }

        public Transicion(char simb1, char simb2, Estado e)
        {
            SInf = simb1;
            Sdup = simb2;
            edo = e;
        }

        public Transicion()
        {
            edo = null;
        }

        public void SetTransicion(char simb, Estado e)
        {
            SInf = simb;
            Sdup = simb;
            edo = e;
        }

        public void SetTransicion(char simb1, char simb2, Estado e)
        {
            SInf = simb1;
            Sdup = simb2;
            edo = e;
        }

        public char SimInf { get => SInf; set => SInf = value; }
        public char SimSup { get => Sdup; set => Sdup = value; }

        public Estado GetEdoTrans(char s)
        {
            if(SInf <= s && s <= Sdup)
            {
                return edo;
            }
            return null;
        }
    }
}
