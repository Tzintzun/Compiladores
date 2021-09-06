using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorLexico
{
    

    public class Estado
    {
        static int contadorIdEstados = 0;
        private int idEstado1;
        private bool EdoAcept1;
        private int Token1;
        private HashSet<Transicion> Trans1 = new HashSet<Transicion>();

        public Estado()
        {
            EstadoAcept = false;
            Token1 = -1;

            idEstado1 = contadorIdEstados++;
            Trans1.Clear();
        }

        public bool EstadoAcept { get => EdoAcept1; set => EdoAcept1 = value; }
        public int IdEstado { get => idEstado1; set => idEstado1 = value; }
        public int Token { get => Token1; set => Token1 = value; }

        public HashSet<Transicion> Trans { get => Trans1; set => Trans1 = value; }


    }
}
