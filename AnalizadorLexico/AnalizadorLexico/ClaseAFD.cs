using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace AnalizadorLexico
{
    [Serializable]
    class TransEdoAFD
    {
        public int IdEdo;
        public int[] TransAFD;
    }
    public class AFD
    {
        
        public static HashSet<AFD> conjAFDs = new HashSet<AFD>();
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

        public static HashSet<AFD> ConjAFDs { get => conjAFDs; set => conjAFDs = value; }
        

        public void GuardarADFenArchivo(string NombreArchivo)
        {
            using (StreamWriter writer = new StreamWriter(NombreArchivo, false))
            {
                writer.WriteLine(this.NumEstados.ToString());

                for(int i = 0; i < NumEstados; i++)
                {
                    for(int j = 0; j < 257; j++)
                    {
                        writer.Write(TablaAFD[i, j]);
                        if (j != 256)
                            writer.Write(";");
                    }
                    writer.WriteLine("");
                }
                writer.Close();
            }
        }

        public void LeerAFDdeArchivo(string NombArchivo, int IdentifAFD)
        {
            int IdEdo;
            int k;
            string Renglon;
            string[] ValoresRenglon = new string[257];

            using (StreamReader reader = new StreamReader(NombArchivo))
            {
                IdEdo = 0;
                Renglon = reader.ReadLine();
                this.NumEstados = int.Parse(Renglon);
                this.TablaAFD = new int[this.NumEstados, 257];

                while (!reader.EndOfStream)
                {
                    Renglon = reader.ReadLine();
                    ValoresRenglon = Renglon.Split(';');

                    for (k = 0; k < 257; k++)
                    {
                        this.TablaAFD[IdEdo, k] = int.Parse(ValoresRenglon[k]);
                    }

                    IdEdo++;
                }
            }

            this.NumEstados = IdEdo;
            this.IdAFD = IdentifAFD;
            AFD.ConjAFDs.Add(this);
            return;
        }


        public int Guardar()
        {
            try
            {
                SaveFileDialog filechooser = new SaveFileDialog();

                if (filechooser.ShowDialog() == DialogResult.OK)
                {
                    GuardarADFenArchivo(filechooser.FileName);
                    return 0;
                }

            }
            catch (Exception e)
            {
                return 1;
            }
            return 0;
        }


    }
}
