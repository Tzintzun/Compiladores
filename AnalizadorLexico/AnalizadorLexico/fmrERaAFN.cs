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
            int id_afd = Int32.Parse(txt_afd_id.Text);
            int id_afn = Int32.Parse(txt_afn_id.Text);

            foreach (AFN n in AFN.ConjuntoAFNs)
            {
                if (n.idAFN == id_afn)
                {
                    MessageBox.Show("ID del AFN ya seleccionado, seleccione otro", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            if (checkBox1.Checked)
            {
                foreach (AFD n in AFD.conjAFDs)
                {
                    if (n.IdAFD == id_afd)
                    {
                        MessageBox.Show("ID del AFD ya seleccionado, seleccione otro", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }


                er_afd = new ER_AFN(sigma, FileAFD, id_afd);
            }
            else
            {
                AFD aux = null;
                if (afds.SelectedIndex < 0)
                {
                    MessageBox.Show("Selecciona un AFD", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                foreach (AFD f in AFD.conjAFDs)
                {
                    if(f.IdAFD == (int)afds.SelectedItem)
                    {
                        aux = f;
                        break;
                    }
                }
                if(aux == null)
                {
                    MessageBox.Show("AFD no encontrado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                er_afd = new ER_AFN(sigma, aux) ;
            }
            bool result = er_afd.IniConversion();

            if (result)
            {
                MessageBox.Show("El AFN fue creado exitosamente", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                er_afd.AgregarAFN(id_afn);
            }
            else
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

        private void ambioOrigenAFD(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                afds.Enabled = false;
                txt_afd_id.Enabled = true;
                button1.Enabled = true;
            }
            else
            {
                afds.Enabled = true;
                txt_afd_id.Enabled = false;
                button1.Enabled = false;

                afds.Items.Clear();
                foreach(AFD f in AFD.conjAFDs)
                {
                    afds.Items.Add(f.IdAFD);
                }
            }
        }
    }
}
