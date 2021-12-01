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
    partial class pAnalizadorLexico : Form
    {
        AFD afd;
        public pAnalizadorLexico()
        {
            InitializeComponent();
            this.MostrarAFDs();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            this.dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "Token";
            dataGridView1.Columns[1].Name = "Lexema";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path_file = openFileDialog1.FileName;
                string[] parts_parh_file = path_file.Split('\\');
                string name_file = parts_parh_file[parts_parh_file.Length - 1];
                lbl_file_name.Text = name_file;
                lbl_file_name.Visible = true;

                if(txt_afd_id.Text != null && txt_afd_id.Text != "")
                {
                    AFD afd_lectura = new AFD();

                    int afd_id;
                    if(Int32.TryParse(txt_afd_id.Text, out afd_id))
                    {
                        afd_lectura.LeerAFDdeArchivo(path_file, afd_id);
                        this.comboBox1.Items.Clear();
                        MostrarAFDs();
                    }
                    else
                    {
                        Console.WriteLine("The AFD ID is invalid");
                        MessageBox.Show("El id asignado para el AFD es invalido");
                    }
                }
                else
                {
                    Console.WriteLine("Textbox for AFD ID is empty");
                    MessageBox.Show("Por favor inserte el id del AFD");
                }
            }
            else
            {
                lbl_file_name.Visible = false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int resultado = afd.Guardar();
            if (resultado == 2)
            {
                MessageBox.Show("No se pudo guardar el AFD");
                return;
            }
            else if (resultado == 0)
            {
                MessageBox.Show("AFD Guardado");
                this.Close();
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        public void MostrarAFDs()
        {
            /*
            if (AFD.ConjAFDs.Count <= 0)
            {
                MessageBox.Show("No hay AFD's para guardar");
                this.Close();
            }
            */
            foreach (AFD afd in AFD.ConjAFDs)
            {
                this.comboBox1.Items.Add(afd.IdAFD);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            int afd_id = Int32.Parse(this.comboBox1.SelectedItem.ToString());
            foreach (AFD afd in AFD.ConjAFDs)
            {
                if (afd.IdAFD == afd_id)
                {
                    AnalizLexico al = new AnalizLexico(txt_cadena.Text, afd);
                    this.afd = al.AutomataFD;
                    int token = al.yylex();
                    while (token != SimbolosEspeciales.FIN )
                    {
                        mostrarAFD(al, token);
                        
                        token = al.yylex();
                    }
                    mostrarAFD(al, token);

                    break;
                }
            }
        }

        public void mostrarAFD(AnalizLexico al,int token)
        {
            

            dataGridView1.Rows.Add();
            int filas = dataGridView1.Rows.Count;

            dataGridView1.Rows[filas - 2].Cells[0].Value = token;
            dataGridView1.Rows[filas - 2].Cells[1].Value = al.Lexema;

            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // TODO: Cambiar por simbolo especial
            // TODO: Se debe agregar al lenguaje
            txt_cadena.Text += " epsilon ";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // TODO: Cambiar por simbolo especial
            // TODO: Se debe agregar al lenguaje
            txt_cadena.Text += " mas ";
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            // TODO: Cambiar por simbolo especial
            // TODO: Se debe agregar al lenguaje
            txt_cadena.Text += " menos ";
        }
    }
}
