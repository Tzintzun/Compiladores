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


        public static void Unir(String afn1, String afn2)
        {
            AFN a1 = null;
            AFN a2 = null;

            foreach(AFN a in AFN.ConjuntoAFNs)
            {
                if (a.idAFN == Int32.Parse(afn1))
                {
                    a1 = a;
                    break;
                }   
            }
            foreach (AFN a in AFN.ConjuntoAFNs)
            {
                if (a.idAFN == Int32.Parse(afn2))
                {
                    a2 = a;
                    break;
                }
            }
            _ = a1.UnirAFN(a2);

            AFN.ConjuntoAFNs.Remove(a2);

        }

        public static void Concat(String afn1,String afn2)
        {
            
            AFN a1 = null;
            AFN a2 = null;

            foreach (AFN a in AFN.ConjuntoAFNs)
            {
                if (a.idAFN == Int32.Parse(afn1))
                {
                    a1 = a;
                    break;
                }
            }
            foreach (AFN a in AFN.ConjuntoAFNs)
            {
                if (a.idAFN == Int32.Parse(afn2))
                {
                    a2 = a;
                    break;
                }
            }
            _ = a1.ConcatenarAFN(a2);

            AFN.ConjuntoAFNs.Remove(a2);

            
        }

        public static void CerraduraPos(String afn1)
        {
            AFN a1 = null;
            foreach (AFN a in AFN.ConjuntoAFNs)
            {
                if (a.idAFN == Int32.Parse(afn1))
                {
                    a1 = a;
                    break;
                }
            }
            a1.cerraduraPos();
        }

        public static void CerraduraKleen(String afn1)
        {
            AFN a1 = null;
            foreach (AFN a in AFN.ConjuntoAFNs)
            {
                if (a.idAFN == Int32.Parse(afn1))
                {
                    a1 = a;
                    break;
                }
            }
            a1.cerraduraKleen();
        }

        public static void Opcional(String afn1)
        {
            AFN a1 = null;
            foreach (AFN a in AFN.ConjuntoAFNs)
            {
                if (a.idAFN == Int32.Parse(afn1))
                {
                    a1 = a;
                    break;
                }
            }
            a1.opcional();
        }

    }
}
