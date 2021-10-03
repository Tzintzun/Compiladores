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
    public partial class GuardarAFD : Form
    {
        public GuardarAFD()
        {
            InitializeComponent();
            this.MostrarAFDs();
        }

        public void MostrarAFDs()
        {
            if (AFD.ConjAFDs.Count <= 0)
            {
                MessageBox.Show("No hay AFD's para guardar");
                this.Close();
            }
            foreach(AFD afd in AFD.ConjAFDs)
            {
                this.comboBox1.Items.Add(afd.IdAFD);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un automata");
                return;
            }
            
            int idAFD = Int32.Parse(comboBox1.Text);

            AFD afdGuardar = null;

            foreach(AFD aux in AFD.conjAFDs)
            {
                if(idAFD == aux.IdAFD)
                {
                    afdGuardar = aux;
                    break;
                }
            }
            
            int resultado = afdGuardar.Guardar();
            if(resultado == 2)
            {
                MessageBox.Show("No se pudo guardar el AFD");
                return;
            }else if(resultado == 0)
            {
                MessageBox.Show("AFD Guardado");
                this.Close();
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
