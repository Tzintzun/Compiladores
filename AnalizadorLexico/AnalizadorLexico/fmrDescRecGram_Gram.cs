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
                int i= 0;

                dgrid_reglas.Rows.Clear();
                dgrid_reglas.Columns.Clear();

                dgrid_reglas.ColumnCount = 2;
                dgrid_reglas.Columns[0].Name = "Simbolo";
                dgrid_reglas.Columns[1].Name = "¿Es Terminal?";

                foreach(string simbolo in AnalizGram.vn)
                {
                    dgrid_reglas.Rows.Add();

                    dgrid_reglas.Rows[i].Cells[0].Value = simbolo;
                    dgrid_reglas.Rows[i].Cells[1].Value = "No terminal";
                    i++;
                }

                foreach (string simbolo in AnalizGram.vt)
                {
                    dgrid_reglas.Rows.Add();

                    dgrid_reglas.Rows[i].Cells[0].Value = simbolo;
                    dgrid_reglas.Rows[i].Cells[1].Value = "Terminal";
                    i++;
                }

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
                lbl_file_name.Text = name_file;
                lbl_file_name.Visible = true;

                AnalizGram = new DescRecGram_Gram(path_file, -1);
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgrid_reglas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("ayudaaaa");
            string simbolo = (string)dgrid_reglas.Rows[e.RowIndex].Cells[0].Value;
            txt_first.Text += simbolo + " ";
        }

        private void dgrid_reglas_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("ayudaaaa");
            string simbolo = (string)dgrid_reglas.Rows[e.RowIndex].Cells[0].Value;
            txt_first.Text += simbolo + " ";
        }
    }
}
