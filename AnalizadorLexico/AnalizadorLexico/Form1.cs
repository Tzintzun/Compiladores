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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void basicoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void basicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AbrirFormhija(new CrearAutomata());
        }

        private void unionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AbrirFormhija(new Union());
        }

        private void AbrirFormhija(Object hija)
        {
            if(this.panel1.Controls.Count > 0)
            {
                this.panel1.Controls.RemoveAt(0);
            }
            Form fh = hija as Form;

            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fh);

            this.panel1.Tag = fh;

            fh.Show();
        }

        private void opcionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AbrirFormhija(new Opcional());
        }

        private void cerraduraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.AbrirFormhija(new CrerraduraKleen());
        }

        private void cerraduraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AbrirFormhija(new CerraduraPos());
        }

        private void concatenacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AbrirFormhija(new Concatenacion());
        }

        private void unirAFNsParaAnalizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AbrirFormhija(new UnirAFNs());
        }

        private void convertirAFNAAFDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AbrirFormhija(new ConversorAFNAFD());
        }

        private void pruebaAnalizadorLexicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AbrirFormhija(new pAnalizadorLexico());
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AbrirFormhija(new fmrEvaluadorExpresiones());
        }

        private void eRAFNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AbrirFormhija(new fmrERaAFN());
        }

        private void descensoRecursivoGramáticaDeGramáticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AbrirFormhija(new fmrDescRecGram_Gram());
        }

        private void anállisisLL1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AbrirFormhija(new AnalisarLL1());
        }
    }
}
