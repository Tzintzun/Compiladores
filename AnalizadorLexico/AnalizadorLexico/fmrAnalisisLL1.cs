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
    public partial class fmrAnalisisLL1 : Form
    {
        public fmrAnalisisLL1()
        {
            InitializeComponent();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_gram.Text = "";
            reiniciar_campos();
        }

        private void reiniciar_campos()
        {
            dgrid_no_terminal.Rows.Clear();
            dgrid_terminales_token.Rows.Clear();
            dgrid_tabla_ll1.Rows.Clear();
        }

        private void txt_gram_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
