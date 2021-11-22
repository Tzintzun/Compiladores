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
    public partial class fmrERaAFN : Form
    {
        string FileAFD;
        ER_AFN er_afd;
        public fmrERaAFN()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            string sigma = txt_exp.Text;
            int id_afn = Int32.Parse(txt_afn_id.Text);
            er_afd = new ER_AFN(sigma, FileAFD, id_afn);
            bool result = er_afd.IniConversion();

            if(result)
            {
                MessageBox.Show("El AFN fue creado exitosamente", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                er_afd.AgregarAFN(Int32.Parse(txt_afd_id.Text));
            }else
            {
                MessageBox.Show("AFN no se pudo crear", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_exp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_afd_id_TextChanged(object sender, EventArgs e)
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

                FileAFD = path_file;
            }
            else
            {
                MessageBox.Show("Selecciones el archivo donde se encuentra el AFD", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbl_file_name.Visible = false;
            }
        }

        private void txt_afn_id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
