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
    public partial class AnalizarLL1 : Form
    {
        AnalizadorLL1 analizador;
        string path_file;
        public AnalizarLL1()
        {
            InitializeComponent();
        }

        private void creaTabla_Click(object sender, EventArgs e)
        {
            if(gramatica.Text.Equals("") || gramatica.Text == null)
            {
                MessageBox.Show("Debes ingresar una gramatica", "ERROR");
                return;
            }

             analizador = new AnalizadorLL1(gramatica.Text);

            if (analizador.crearTablaLL1())
            {
                tablaLL1.Rows.Clear();
                tablaLL1.Columns.Clear();
                tablaLL1.AllowUserToOrderColumns = false;
                tablaLL1.RowHeadersVisible = false;

                tablaNTerminales.Columns.Clear();
                tablaNTerminales.Rows.Clear();
                tablaNTerminales.AllowUserToOrderColumns = false;
                tablaNTerminales.RowHeadersVisible = false;

                tablaTerminales.Columns.Clear();
                tablaTerminales.Rows.Clear();
                tablaTerminales.AllowUserToOrderColumns = false;
                tablaTerminales.RowHeadersVisible = false;
                tablaTerminales.AllowUserToAddRows = false;
                tablaNTerminales.Columns.Add("noTerminal", "Simbolos");
                for(int i = 0; i < analizador.vn.Length; i++)
                {
                    tablaNTerminales.Rows.Add();
                    tablaNTerminales.Rows[i].Cells[0].Value =analizador.vn[i];
                }
                int ep = -1;
                tablaTerminales.Columns.Add("terminales","Simbolos");
                tablaTerminales.Columns.Add("token", "Token");
                for (int i = 0; i < analizador.vt.Length; i++)
                {
                    
                    
                        tablaTerminales.Rows.Add();
                        tablaTerminales.Rows[i].Cells[0].Value = analizador.vt[i].simbolo;
                    if (analizador.vt[i].simbolo.Equals("epsilon")){
                        ep = i;
                    }
                    
                    
                }
                tablaLL1.Columns.Add("Marco", "No Terminal\\Terminal");
                foreach (SimbTerm s in analizador.vt)
                {
                    
                        
                        tablaLL1.Columns.Add(s.simbolo, s.simbolo);
                    
                }
                foreach(string s in analizador.vn){
                    tablaLL1.Rows.Add(s);
                    
                }
                /*for(int i = 0; i < tablaLL1.Rows.Count; i++)
                {
                    tablaLL1.Rows[i].Cells[0].Value = analizador.vn[i];
                }*/
                for(int i = 0; i < analizador.vn.Length; i++)
                {
                    for(int j = 1; j < analizador.vt.Length; j++)
                    {
                        
                            tablaLL1.Rows[i].Cells[j].Value = analizador.tablaLL1[i, j-1];
                        
                    }
                }
                tablaLL1.Columns.Remove("epsilon");
                if (ep >= 0)
                {
                    tablaTerminales.Rows.RemoveAt(ep);
                }
                
            }
            
        }

        private void yylexBoton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path_file = openFileDialog1.FileName;
                string[] parts_parh_file = path_file.Split('\\');
                string name_file = parts_parh_file[parts_parh_file.Length - 1];
                
                analizador.setLexico(path_file);
                lbl_file_name.Text = name_file;
                lbl_file_name.Visible = true;
            }
            else
            {
                MessageBox.Show("Selecciona el archivo donde se encuentra el AFD", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbl_file_name.Visible = false;
            }
        }

        private void botonAnalisisRapido_Click(object sender, EventArgs e)
        {
            analisisAFD.Rows.Clear();
            analisisAFD.Columns.Clear();
            analisisAFD.RowHeadersVisible = false;
            analisisAFD.Columns.Add("Lexema", "Lexema");
            analisisAFD.Columns.Add("Token", "Token");
            AnalizLexico l = new AnalizLexico(path_file, 100);
            int filas;
            if (textBox1.Text.Equals("") || textBox1.Text == null)
            {
                MessageBox.Show("Cadena de entrada vacia","ERROR");
                return;
            }
            l.SetSigma(textBox1.Text);
            int token = l.yylex();
            while(token != SimbolosEspeciales.FIN)
            {
                analisisAFD.Rows.Add();
                filas = analisisAFD.Rows.Count;

                analisisAFD.Rows[filas - 2].Cells[0].Value = l.Lexema;
                analisisAFD.Rows[filas - 2].Cells[1].Value = token;
                token = l.yylex();
            }
            analisisAFD.Rows.Add();
             filas = analisisAFD.Rows.Count;

            analisisAFD.Rows[filas - 2].Cells[0].Value = token;
            analisisAFD.Rows[filas - 2].Cells[1].Value = l.Lexema;
        }

        private void analisarConLL1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < tablaTerminales.Rows.Count; i++)
            {
                if(tablaTerminales.Rows[i].Cells[1].Value == null || tablaTerminales.Rows[i].Cells[1].Value.Equals(""))
                {
                    MessageBox.Show("Tienes que asignar todos los Tokens a la tabal de terminales", "ERROR");
                    return;
                }
                try
                {
                    int token = Int32.Parse((string)tablaTerminales.Rows[i].Cells[1].Value);
                    foreach(SimbTerm s in analizador.vt)
                    {
                        if (s.simbolo.Equals(tablaTerminales.Rows[i].Cells[0].Value))
                        {
                            s.valToken = token;
                            break;
                        }
                    }
                    
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Token mal escrito", "ERROR");
                    return;
                }
            }

            if(textBox1.Text.Equals("") || textBox1.Text == null)
            {
                MessageBox.Show("Ingresa una cadena", "ERROR");
                return;
            }

            if(analizador.analizarSintacticamente(textBox1.Text, procesosAnalisis))
            {
                MessageBox.Show("Cadena Correcta", "Succes");
                return;
            }
            else
            {
                MessageBox.Show("Cadena INCORRECTA", "ERROR");
                return;
            }
        }
        
        private void analisisAFD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_gram_Click(object sender, EventArgs e)
        {
            gramatica.Text = "E-> T Ep; Ep -> mas T Ep | menos T Ep| epsilon; T-> F Tp; Tp-> prod F Tp | div F Tp| epsilon; F-> parI E parD | num;";
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            gramatica.Text = "";
        }
    }
}
