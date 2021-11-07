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
    public partial class fmrEvaluadorExpresiones : Form
    {
        EvaluadorExpr Evaluador;
        public fmrEvaluadorExpresiones()
        {
            InitializeComponent();
        }

        private void fmrEvaluadorExpresiones_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_eval_Click(object sender, EventArgs e)
        {
            string texto = txt_exp.Text;
            Console.WriteLine(texto);
            Evaluador.setExpresion(texto);

            if (Evaluador.IniEval())
            {
                MessageBox.Show("Expresión sintácticamente correcta", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_result.Text = Evaluador.result.ToString();
                txt_postfijo.Text = Evaluador.ExprPost;
            } else
            {
                MessageBox.Show("Expresión sintácticamente incorrecta", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_result.Text = "ERROR";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

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

                Evaluador = new EvaluadorExpr(path_file, -1);
            }
            else
            {
                MessageBox.Show("Selecciones el archivo donde se encuentra el AFD", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbl_file_name.Visible = false;
            }
        }

        private void txt_afd_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void txt_exp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
