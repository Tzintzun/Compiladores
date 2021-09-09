﻿using System;
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
    }
}
