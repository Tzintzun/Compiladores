using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalizadorLexico
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static void AgregarNuevoAFN(char s1,char s2, int id)
        {
            AFN a1 = new AFN();
            a1.crearAFNBasico(s1, s2);
            a1.idAFN = id;
            AFN.ConjuntoAFNs.Add(a1);
        }
        public static void AgregarNuevoAFN(char s1, int id)
        {
            AFN a1 = new AFN();
            a1.crearAFNBasico(s1);
            a1.idAFN = id;
            AFN.ConjuntoAFNs.Add(a1);
        }
    }
}
