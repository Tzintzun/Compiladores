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
    
    public partial class ConversorAFNAFD : Form
    {
        public AFD afdActual;
        public ConversorAFNAFD()
        {
            InitializeComponent();
            mostrarAFNs();
        }

        public void mostrarAFNs()
        {
            foreach (AFN afn in AFN.ConjuntoAFNs)
            {
                this.comboBox1.Items.Add(afn.idAFN);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id;
            if (!String.IsNullOrEmpty(this.textBox1.Text))
            {
                id = Int32.Parse(this.textBox1.Text);
                foreach(AFD afd in AFD.ConjAFDs)
                {
                    if(id == afd.IdAFD)
                    {
                        MessageBox.Show("ID ya ocupado");
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Indica un ID para el AFD");
                return;
            }

            AFN afnAConvertir = null;
            AFD afdResultado;
            if(this.comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Selecciona un AFN");
                return;
            }
            int idafn = 0;
            idafn = Int32.Parse(this.comboBox1.SelectedItem.ToString());
            foreach(AFN afn in AFN.ConjuntoAFNs)
            {
                if (afn.idAFN == idafn)
                {
                    afnAConvertir = afn;
                    break;
                }
            }
            afdResultado = afnAConvertir.ConvAFNaAFD();
            afdResultado.IdAFD = id;
            AFD.conjAFDs.Add(afdResultado);
            this.afdActual = afdResultado;

            this.mostrarAFD();
        }

        public void mostrarAFD()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            this.dataGridView1.ColumnCount = 257;
            for(int i=0;i<256; i++)
            {
                dataGridView1.Columns[i].Name = char.ConvertFromUtf32(i).ToString();
            }
            dataGridView1.Columns[256].Name = "Token";
            for (int i = 0; i < this.afdActual.NumEstados; i++)
            {
                dataGridView1.Rows.Add();
            }
            
            for(int i = 0; i < this.afdActual.NumEstados; i++)
            {
                for(int j = 0; j < 257; j++)
                {
                    this.dataGridView1.Rows[i].Cells[j].Value = this.afdActual.TablaAFD[i, j];
                }
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GuardarAFD guardado = new GuardarAFD();
            guardado.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
