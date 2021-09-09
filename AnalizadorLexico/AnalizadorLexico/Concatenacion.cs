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
    public partial class Concatenacion : Form
    {
        public Concatenacion()
        {
            InitializeComponent();
            this.ActualizarListas();
        }

        public void ActualizarListas()
        {
            this.comboBox1.Text = "";
            this.comboBox2.Text = "";
            this.comboBox1.Items.Clear();
            this.comboBox2.Items.Clear();
            foreach (AFN f in AFN.ConjuntoAFNs)
            {
                this.comboBox1.Items.Add(f.idAFN);
                this.comboBox2.Items.Add(f.idAFN);
            }
        }
        private void Mensaje(String mensaje)
        {
            this.label5.Text = mensaje;
            this.label5.ForeColor = Color.Green;
            this.label5.BackColor = Color.FromArgb(125, 255, 125);
            this.label5.Visible = true;
        }

        
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedIndex < 0)
            {
                this.label3.Text = "Seleccione un automata 1";
                this.label3.ForeColor = Color.Red;
                this.label3.Visible = true;
                return;
            }
            if (this.comboBox2.SelectedIndex < 0)
            {
                this.label4.Text = "Seleccione un automata 2";
                this.label4.ForeColor = Color.Red;
                this.label4.Visible = true;
                return;
            }

            if (this.comboBox1.Text.Equals(this.comboBox2.Text))
            {
                this.label3.Text = "Seleccione un automatas Distintos";
                this.label3.ForeColor = Color.Red;
                this.label3.Visible = true;
                return;
            }

            Program.Concat(this.comboBox1.Text, this.comboBox2.Text);
            this.ActualizarListas();
            this.Mensaje("AFN´s Concatenados");
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            this.label5.Visible = false;
            this.label3.Visible = false;
            this.label4.Visible = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.label5.Visible = false;
            this.label3.Visible = false;
            this.label4.Visible = false;
        }

        
    }
}
