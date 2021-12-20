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
    public partial class CrearAutomata : Form
    {
        public CrearAutomata()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                String mensaje = "Introduce el caracter Inferior";
                _ = MessageBox.Show(mensaje);
                return;
            }
            char cInf = textBox1.Text[0];

            int id;
            try
            {
                id = Int32.Parse(textBox3.Text);
            }
            catch (FormatException)
            {
                String mensaje = "Ingrese un numero en \"ID del AFN\"";
                _ = MessageBox.Show(mensaje);
                return;

            }
            foreach (AFN afn in AFN.ConjuntoAFNs)
            {
                if (afn.idAFN == id)
                {
                    String mensaje = "ID del AFN ya ocupado";
                    _ = MessageBox.Show(mensaje);
                    return;
                }
            }
            char aux;

            if (String.IsNullOrEmpty(textBox2.Text))
            {
                Program.AgregarNuevoAFN(cInf, id);
                this.Mensaje("AFN Creado");
            }
            else
            {
                char cSup = textBox2.Text[0];
                if (cInf > cSup)
                {
                    aux = cInf;
                    cInf = cSup;
                    cSup = aux;
                }

                Program.AgregarNuevoAFN(cInf, cSup, id);
                this.Mensaje("AFN Creado");
            }
        }

        private void Mensaje(String mensaje)
        {
            this.label4.Text = mensaje;
            this.label4.ForeColor = Color.Green;
            this.label4.BackColor = Color.FromArgb(125, 255, 125);
            this.label4.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.label4.Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.label4.Visible = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            this.label4.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            this.label4.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
