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
            if(AnalizGram == null)
            {
                MessageBox.Show("Porfavor cargue una gramatica", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            AnalizGram.SetGramatica(texto);

            if (AnalizGram.AnalizarGramatica())
            {
                int i= 0;

                dgrid_reglas.Rows.Clear();
                dgrid_reglas.Columns.Clear();

                dgrid_noTerminal.Rows.Clear();
                dgrid_noTerminal.Columns.Clear();

                dgrid_reglas.ColumnCount = 2;
                dgrid_reglas.Columns[0].Name = "Simbolo";
                dgrid_reglas.Columns[1].Name = "¿Es Terminal?";

                dgrid_noTerminal.ColumnCount = 1;
                dgrid_noTerminal.Columns[0].Name = "Simbolo";

                foreach (string simbolo in AnalizGram.vn)
                {
                    dgrid_reglas.Rows.Add();
                    dgrid_noTerminal.Rows.Add();

                    dgrid_reglas.Rows[i].Cells[0].Value = simbolo;
                    dgrid_reglas.Rows[i].Cells[1].Value = "No terminal";

                    dgrid_noTerminal.Rows[i].Cells[0].Value = simbolo;
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgrid_reglas_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string simbolo = (string)dgrid_reglas.Rows[e.RowIndex].Cells[0].Value;
            txt_first.Text += simbolo + " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt_first.Text = "";
            dgrid_first.Rows.Clear();
            dgrid_first.Columns.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i, j;
            bool terminal;
            string cadena = txt_first.Text;
            string[] simbolos = cadena.Split(' ');
            List<Nodo> lista = new List<Nodo>();
            HashSet<string> first_simbolos;

            dgrid_first.Rows.Clear();
            dgrid_first.Columns.Clear();

            dgrid_first.ColumnCount = 1;
            dgrid_first.Columns[0].Name = "Simbolo";

            for (i = 0; i < simbolos.Length - 1; i++)
            {
                terminal = true;
                for(j = 0; j < AnalizGram.NumReglas; j++)
                {
                    if (AnalizGram.arrReglas[j].infSimbolo.simbolo.Equals(simbolos[i]))
                    {
                        Console.WriteLine(simbolos[i]);
                        lista.Add(AnalizGram.arrReglas[j].infSimbolo);
                        terminal = false;
                        break;
                    }
                }
                if (terminal)
                {
                    lista.Add(new Nodo(simbolos[i], true));
                }
            }
            first_simbolos = AnalizGram.First(lista);

            i = 0;
            foreach (string simbolo in first_simbolos)
            {
                dgrid_first.Rows.Add();

                dgrid_first.Rows[i].Cells[0].Value = simbolo;
                i++;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txt_follow.Text = "";
            dgrid_follow.Rows.Clear();
            dgrid_follow.Columns.Clear();
        }

        private void dgrid_noTerminal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = 0;
            string simb = (string)dgrid_noTerminal.Rows[e.RowIndex].Cells[0].Value;
            txt_follow.Text = simb;
            HashSet<String> follow_simbolos = AnalizGram.Follow(simb);

            dgrid_follow.Rows.Clear();
            dgrid_follow.Columns.Clear();

            dgrid_follow.ColumnCount = 1;
            dgrid_follow.Columns[0].Name = "Simbolo";

            foreach (string simbolo in follow_simbolos)
            {
                dgrid_follow.Rows.Add();

                dgrid_follow.Rows[i].Cells[0].Value = simbolo;
                i++;
            }
        }
    }
}
