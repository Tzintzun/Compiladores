
namespace AnalizadorLexico
{
    partial class AnalizarLL1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gramatica = new System.Windows.Forms.TextBox();
            this.creaTabla = new System.Windows.Forms.Button();
            this.tablaNTerminales = new System.Windows.Forms.DataGridView();
            this.tablaTerminales = new System.Windows.Forms.DataGridView();
            this.tablaLL1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.yylexBoton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.botonAnalisisRapido = new System.Windows.Forms.Button();
            this.analisisAFD = new System.Windows.Forms.DataGridView();
            this.procesosAnalisis = new System.Windows.Forms.DataGridView();
            this.analisarConLL1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_gram = new System.Windows.Forms.Button();
            this.lbl_file_name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaNTerminales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaTerminales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaLL1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.analisisAFD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procesosAnalisis)).BeginInit();
            this.SuspendLayout();
            // 
            // gramatica
            // 
            this.gramatica.Location = new System.Drawing.Point(134, 47);
            this.gramatica.Margin = new System.Windows.Forms.Padding(4);
            this.gramatica.Name = "gramatica";
            this.gramatica.Size = new System.Drawing.Size(1039, 22);
            this.gramatica.TabIndex = 0;
            // 
            // creaTabla
            // 
            this.creaTabla.Location = new System.Drawing.Point(465, 77);
            this.creaTabla.Margin = new System.Windows.Forms.Padding(4);
            this.creaTabla.Name = "creaTabla";
            this.creaTabla.Size = new System.Drawing.Size(161, 39);
            this.creaTabla.TabIndex = 1;
            this.creaTabla.Text = "Crear tabla LL1";
            this.creaTabla.UseVisualStyleBackColor = true;
            this.creaTabla.Click += new System.EventHandler(this.creaTabla_Click);
            // 
            // tablaNTerminales
            // 
            this.tablaNTerminales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaNTerminales.Location = new System.Drawing.Point(52, 161);
            this.tablaNTerminales.Margin = new System.Windows.Forms.Padding(4);
            this.tablaNTerminales.Name = "tablaNTerminales";
            this.tablaNTerminales.RowHeadersWidth = 51;
            this.tablaNTerminales.Size = new System.Drawing.Size(265, 214);
            this.tablaNTerminales.TabIndex = 2;
            // 
            // tablaTerminales
            // 
            this.tablaTerminales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaTerminales.Location = new System.Drawing.Point(347, 162);
            this.tablaTerminales.Margin = new System.Windows.Forms.Padding(4);
            this.tablaTerminales.Name = "tablaTerminales";
            this.tablaTerminales.RowHeadersWidth = 51;
            this.tablaTerminales.Size = new System.Drawing.Size(279, 214);
            this.tablaTerminales.TabIndex = 3;
            // 
            // tablaLL1
            // 
            this.tablaLL1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaLL1.Location = new System.Drawing.Point(52, 384);
            this.tablaLL1.Margin = new System.Windows.Forms.Padding(4);
            this.tablaLL1.Name = "tablaLL1";
            this.tablaLL1.RowHeadersWidth = 51;
            this.tablaLL1.Size = new System.Drawing.Size(573, 330);
            this.tablaLL1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "No terminales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Terminales";
            // 
            // yylexBoton
            // 
            this.yylexBoton.Location = new System.Drawing.Point(648, 161);
            this.yylexBoton.Margin = new System.Windows.Forms.Padding(4);
            this.yylexBoton.Name = "yylexBoton";
            this.yylexBoton.Size = new System.Drawing.Size(165, 49);
            this.yylexBoton.TabIndex = 7;
            this.yylexBoton.Text = "Agregar AFD";
            this.yylexBoton.UseVisualStyleBackColor = true;
            this.yylexBoton.Click += new System.EventHandler(this.yylexBoton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(841, 162);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 22);
            this.textBox1.TabIndex = 8;
            // 
            // botonAnalisisRapido
            // 
            this.botonAnalisisRapido.Location = new System.Drawing.Point(841, 194);
            this.botonAnalisisRapido.Margin = new System.Windows.Forms.Padding(4);
            this.botonAnalisisRapido.Name = "botonAnalisisRapido";
            this.botonAnalisisRapido.Size = new System.Drawing.Size(183, 39);
            this.botonAnalisisRapido.TabIndex = 9;
            this.botonAnalisisRapido.Text = "Comprobar AFD";
            this.botonAnalisisRapido.UseVisualStyleBackColor = true;
            this.botonAnalisisRapido.Click += new System.EventHandler(this.botonAnalisisRapido_Click);
            // 
            // analisisAFD
            // 
            this.analisisAFD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.analisisAFD.Location = new System.Drawing.Point(1116, 162);
            this.analisisAFD.Margin = new System.Windows.Forms.Padding(4);
            this.analisisAFD.Name = "analisisAFD";
            this.analisisAFD.RowHeadersWidth = 51;
            this.analisisAFD.Size = new System.Drawing.Size(188, 185);
            this.analisisAFD.TabIndex = 10;
            this.analisisAFD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.analisisAFD_CellContentClick);
            // 
            // procesosAnalisis
            // 
            this.procesosAnalisis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.procesosAnalisis.Location = new System.Drawing.Point(648, 384);
            this.procesosAnalisis.Margin = new System.Windows.Forms.Padding(4);
            this.procesosAnalisis.Name = "procesosAnalisis";
            this.procesosAnalisis.RowHeadersWidth = 51;
            this.procesosAnalisis.Size = new System.Drawing.Size(656, 330);
            this.procesosAnalisis.TabIndex = 11;
            // 
            // analisarConLL1
            // 
            this.analisarConLL1.Location = new System.Drawing.Point(648, 335);
            this.analisarConLL1.Margin = new System.Windows.Forms.Padding(4);
            this.analisarConLL1.Name = "analisarConLL1";
            this.analisarConLL1.Size = new System.Drawing.Size(285, 40);
            this.analisarConLL1.TabIndex = 12;
            this.analisarConLL1.Text = "Analizar sintácticamente sigma";
            this.analisarConLL1.UseVisualStyleBackColor = true;
            this.analisarConLL1.Click += new System.EventHandler(this.analisarConLL1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Gramática:";
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(634, 77);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(4);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(161, 39);
            this.btn_reset.TabIndex = 14;
            this.btn_reset.Text = "Limpiar";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_gram
            // 
            this.btn_gram.Location = new System.Drawing.Point(1181, 47);
            this.btn_gram.Margin = new System.Windows.Forms.Padding(4);
            this.btn_gram.Name = "btn_gram";
            this.btn_gram.Size = new System.Drawing.Size(33, 24);
            this.btn_gram.TabIndex = 15;
            this.btn_gram.Text = "G";
            this.btn_gram.UseVisualStyleBackColor = true;
            this.btn_gram.Click += new System.EventHandler(this.btn_gram_Click);
            // 
            // lbl_file_name
            // 
            this.lbl_file_name.AutoSize = true;
            this.lbl_file_name.Location = new System.Drawing.Point(645, 216);
            this.lbl_file_name.Name = "lbl_file_name";
            this.lbl_file_name.Size = new System.Drawing.Size(30, 17);
            this.lbl_file_name.TabIndex = 16;
            this.lbl_file_name.Text = "File";
            this.lbl_file_name.Visible = false;
            // 
            // AnalizarLL1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 764);
            this.Controls.Add(this.lbl_file_name);
            this.Controls.Add(this.btn_gram);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.analisarConLL1);
            this.Controls.Add(this.procesosAnalisis);
            this.Controls.Add(this.analisisAFD);
            this.Controls.Add(this.botonAnalisisRapido);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.yylexBoton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tablaLL1);
            this.Controls.Add(this.tablaTerminales);
            this.Controls.Add(this.tablaNTerminales);
            this.Controls.Add(this.creaTabla);
            this.Controls.Add(this.gramatica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AnalizarLL1";
            this.Text = "AnalisarLL1";
            ((System.ComponentModel.ISupportInitialize)(this.tablaNTerminales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaTerminales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaLL1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.analisisAFD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.procesosAnalisis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox gramatica;
        private System.Windows.Forms.Button creaTabla;
        private System.Windows.Forms.DataGridView tablaNTerminales;
        private System.Windows.Forms.DataGridView tablaTerminales;
        private System.Windows.Forms.DataGridView tablaLL1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button yylexBoton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button botonAnalisisRapido;
        private System.Windows.Forms.DataGridView analisisAFD;
        private System.Windows.Forms.DataGridView procesosAnalisis;
        private System.Windows.Forms.Button analisarConLL1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_gram;
        private System.Windows.Forms.Label lbl_file_name;
    }
}