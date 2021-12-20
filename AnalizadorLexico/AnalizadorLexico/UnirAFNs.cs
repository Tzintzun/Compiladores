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
    public partial class UnirAFNs : Form
    {
        public UnirAFNs()
        {
            InitializeComponent();
            mostrarAFN();
            dataGridView1.AllowUserToAddRows = false;
        }

        public void mostrarAFN()
        {
            foreach (AFN afn in AFN.ConjuntoAFNs)
            {
                this.dataGridView1.Rows.Add(afn.idAFN,"",false);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 
            int id = Int32.Parse(this.textBox1.Text);

            foreach(AFN auxiliar in AFN.ConjuntoAFNs)
            {
                if(id == auxiliar.idAFN)
                {
                    this.label2.Visible = true;
                    return;
                }
            }

            HashSet<AFN> estados = new HashSet<AFN>();
            AFN afn;
            foreach(DataGridViewRow fila in this.dataGridView1.Rows)
            {
                
                if (Convert.ToBoolean(fila.Cells[2].Value))
                {
                    foreach(AFN auxiliar in AFN.ConjuntoAFNs)
                    {
                        if (auxiliar.idAFN == Int32.Parse(fila.Cells[0].Value.ToString()))
                        {
                            estados.Add(auxiliar);
                            foreach(Estado acept in auxiliar.EstadosAcept)
                            {
                                acept.Token = Int32.Parse(fila.Cells[1].Value.ToString());
                            }
                        }
                    }
                }
            }

            afn = AFN.UnionLexica(id, estados);
            MessageBox.Show("AFN's unidos correctamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.label2.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
