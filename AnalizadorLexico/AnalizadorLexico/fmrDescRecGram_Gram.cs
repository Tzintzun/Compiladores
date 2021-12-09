using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalizadorLexico
{
    public partial class fmrDescRecGram_Gram : Form
    {
        public string Sigma;
        private DescRecGram_Gram AnalizGram;

        public fmrDescRecGram_Gram()
        {
            InitializeComponent();
        }

        private void btn_eval_Click(object sender, EventArgs e)
        {
            string texto = txt_exp.Text;
            Console.WriteLine(texto);
            AnalizGram.SetGramatica(texto);

            if (AnalizGram.AnalizarGramatica())
            {
                MessageBox.Show("Expresión sintácticamente correcta", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Expresión sintácticamente incorrecta", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.WriteLine(SimbolosEspeciales.ERROR);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path_file = openFileDialog1.FileName;
                string[] parts_parh_file = path_file.Split('\\');
                string name_file = parts_parh_file[parts_parh_file.Length - 1];
                
                int idAfd=0;
                if(Int32.TryParse(txt_afd_id.Text,out idAfd))
                {
                    foreach(AFD d in AFD.conjAFDs)
                    {
                        if(d.IdAFD == idAfd)
                        {
                            MessageBox.Show("ID del AFD ya ocupado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    AnalizGram = new DescRecGram_Gram(path_file, idAfd);
                    lbl_file_name.Text = name_file;
                    lbl_file_name.Visible = true;
                }
                else
                {
                    MessageBox.Show("El ID del AFd debe de ser un numero entero", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
               
            }
            else
            {
                MessageBox.Show("Selecciones el archivo donde se encuentra el AFD", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbl_file_name.Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DescRecGram_Gram_Load(object sender, EventArgs e)
        {

        }

        private void txt_exp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
