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
    public partial class AnalisarLL1 : Form
    {
        public AnalisarLL1()
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

            AnalizadorLL1 analizador = new AnalizadorLL1(gramatica.Text);

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
    }
}
