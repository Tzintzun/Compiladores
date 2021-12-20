
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
            this.txt_sigma = new System.Windows.Forms.TextBox();
            this.botonAnalisisRapido = new System.Windows.Forms.Button();
            this.analisisAFD = new System.Windows.Forms.DataGridView();
            this.procesosAnalisis = new System.Windows.Forms.DataGridView();
            this.analisarConLL1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_gram = new System.Windows.Forms.Button();
            this.lbl_file_name = new System.Windows.Forms.Label();
            this.lbl_tabla_ll1 = new System.Windows.Forms.Label();
            this.btn_limpiar_cadena = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_subtitle_3 = new System.Windows.Forms.Label();
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
            this.gramatica.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gramatica.Name = "gramatica";
            this.gramatica.Size = new System.Drawing.Size(1039, 22);
            this.gramatica.TabIndex = 0;
            // 
            // creaTabla
            // 
            this.creaTabla.BackColor = System.Drawing.Color.Black;
            this.creaTabla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creaTabla.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creaTabla.ForeColor = System.Drawing.SystemColors.Window;
            this.creaTabla.Location = new System.Drawing.Point(465, 86);
            this.creaTabla.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.creaTabla.Name = "creaTabla";
            this.creaTabla.Size = new System.Drawing.Size(161, 39);
            this.creaTabla.TabIndex = 1;
            this.creaTabla.Text = "Crear tabla LL1";
            this.creaTabla.UseVisualStyleBackColor = false;
            this.creaTabla.Click += new System.EventHandler(this.creaTabla_Click);
            // 
            // tablaNTerminales
            // 
            this.tablaNTerminales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaNTerminales.Location = new System.Drawing.Point(53, 161);
            this.tablaNTerminales.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tablaNTerminales.Name = "tablaNTerminales";
            this.tablaNTerminales.RowHeadersWidth = 51;
            this.tablaNTerminales.Size = new System.Drawing.Size(265, 214);
            this.tablaNTerminales.TabIndex = 2;
            // 
            // tablaTerminales
            // 
            this.tablaTerminales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaTerminales.Location = new System.Drawing.Point(347, 162);
            this.tablaTerminales.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tablaTerminales.Name = "tablaTerminales";
            this.tablaTerminales.RowHeadersWidth = 51;
            this.tablaTerminales.Size = new System.Drawing.Size(279, 214);
            this.tablaTerminales.TabIndex = 3;
            // 
            // tablaLL1
            // 
            this.tablaLL1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaLL1.Location = new System.Drawing.Point(53, 409);
            this.tablaLL1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tablaLL1.Name = "tablaLL1";
            this.tablaLL1.RowHeadersWidth = 51;
            this.tablaLL1.Size = new System.Drawing.Size(573, 251);
            this.tablaLL1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "No terminales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Terminales";
            // 
            // yylexBoton
            // 
            this.yylexBoton.BackColor = System.Drawing.Color.Black;
            this.yylexBoton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yylexBoton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yylexBoton.ForeColor = System.Drawing.SystemColors.Window;
            this.yylexBoton.Location = new System.Drawing.Point(648, 170);
            this.yylexBoton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.yylexBoton.Name = "yylexBoton";
            this.yylexBoton.Size = new System.Drawing.Size(165, 37);
            this.yylexBoton.TabIndex = 7;
            this.yylexBoton.Text = "Seleccionar AFD";
            this.yylexBoton.UseVisualStyleBackColor = false;
            this.yylexBoton.Click += new System.EventHandler(this.yylexBoton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txt_sigma
            // 
            this.txt_sigma.Location = new System.Drawing.Point(843, 188);
            this.txt_sigma.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_sigma.Name = "txt_sigma";
            this.txt_sigma.Size = new System.Drawing.Size(265, 22);
            this.txt_sigma.TabIndex = 8;
            // 
            // botonAnalisisRapido
            // 
            this.botonAnalisisRapido.BackColor = System.Drawing.Color.Black;
            this.botonAnalisisRapido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonAnalisisRapido.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAnalisisRapido.ForeColor = System.Drawing.SystemColors.Window;
            this.botonAnalisisRapido.Location = new System.Drawing.Point(843, 220);
            this.botonAnalisisRapido.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.botonAnalisisRapido.Name = "botonAnalisisRapido";
            this.botonAnalisisRapido.Size = new System.Drawing.Size(167, 39);
            this.botonAnalisisRapido.TabIndex = 9;
            this.botonAnalisisRapido.Text = "Comprobar AFD";
            this.botonAnalisisRapido.UseVisualStyleBackColor = false;
            this.botonAnalisisRapido.Click += new System.EventHandler(this.botonAnalisisRapido_Click);
            // 
            // analisisAFD
            // 
            this.analisisAFD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.analisisAFD.Location = new System.Drawing.Point(1115, 162);
            this.analisisAFD.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.analisisAFD.Name = "analisisAFD";
            this.analisisAFD.RowHeadersWidth = 51;
            this.analisisAFD.Size = new System.Drawing.Size(187, 185);
            this.analisisAFD.TabIndex = 10;
            this.analisisAFD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.analisisAFD_CellContentClick);
            // 
            // procesosAnalisis
            // 
            this.procesosAnalisis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.procesosAnalisis.Location = new System.Drawing.Point(648, 384);
            this.procesosAnalisis.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.procesosAnalisis.Name = "procesosAnalisis";
            this.procesosAnalisis.RowHeadersWidth = 51;
            this.procesosAnalisis.Size = new System.Drawing.Size(656, 276);
            this.procesosAnalisis.TabIndex = 11;
            // 
            // analisarConLL1
            // 
            this.analisarConLL1.BackColor = System.Drawing.Color.Black;
            this.analisarConLL1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.analisarConLL1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analisarConLL1.ForeColor = System.Drawing.SystemColors.Window;
            this.analisarConLL1.Location = new System.Drawing.Point(648, 335);
            this.analisarConLL1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.analisarConLL1.Name = "analisarConLL1";
            this.analisarConLL1.Size = new System.Drawing.Size(285, 40);
            this.analisarConLL1.TabIndex = 12;
            this.analisarConLL1.Text = "Analizar sintácticamente sigma";
            this.analisarConLL1.UseVisualStyleBackColor = false;
            this.analisarConLL1.Click += new System.EventHandler(this.analisarConLL1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Gramática:";
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.Black;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_reset.Location = new System.Drawing.Point(648, 86);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(161, 39);
            this.btn_reset.TabIndex = 14;
            this.btn_reset.Text = "Limpiar todo";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_gram
            // 
            this.btn_gram.BackColor = System.Drawing.Color.Black;
            this.btn_gram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gram.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_gram.Location = new System.Drawing.Point(1181, 43);
            this.btn_gram.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_gram.Name = "btn_gram";
            this.btn_gram.Size = new System.Drawing.Size(33, 31);
            this.btn_gram.TabIndex = 15;
            this.btn_gram.Text = "G";
            this.btn_gram.UseVisualStyleBackColor = false;
            this.btn_gram.Click += new System.EventHandler(this.btn_gram_Click);
            // 
            // lbl_file_name
            // 
            this.lbl_file_name.AutoSize = true;
            this.lbl_file_name.Location = new System.Drawing.Point(645, 211);
            this.lbl_file_name.Name = "lbl_file_name";
            this.lbl_file_name.Size = new System.Drawing.Size(30, 17);
            this.lbl_file_name.TabIndex = 16;
            this.lbl_file_name.Text = "File";
            this.lbl_file_name.Visible = false;
            // 
            // lbl_tabla_ll1
            // 
            this.lbl_tabla_ll1.AutoSize = true;
            this.lbl_tabla_ll1.Location = new System.Drawing.Point(49, 388);
            this.lbl_tabla_ll1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_tabla_ll1.Name = "lbl_tabla_ll1";
            this.lbl_tabla_ll1.Size = new System.Drawing.Size(82, 17);
            this.lbl_tabla_ll1.TabIndex = 17;
            this.lbl_tabla_ll1.Text = "Tabla LL(1)";
            // 
            // btn_limpiar_cadena
            // 
            this.btn_limpiar_cadena.BackColor = System.Drawing.Color.Black;
            this.btn_limpiar_cadena.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiar_cadena.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar_cadena.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_limpiar_cadena.Location = new System.Drawing.Point(1018, 220);
            this.btn_limpiar_cadena.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_limpiar_cadena.Name = "btn_limpiar_cadena";
            this.btn_limpiar_cadena.Size = new System.Drawing.Size(91, 39);
            this.btn_limpiar_cadena.TabIndex = 18;
            this.btn_limpiar_cadena.Text = "Limpiar";
            this.btn_limpiar_cadena.UseVisualStyleBackColor = false;
            this.btn_limpiar_cadena.Click += new System.EventHandler(this.btn_limpiar_cadena_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.lbl_title.Location = new System.Drawing.Point(515, 1);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(209, 42);
            this.lbl_title.TabIndex = 19;
            this.lbl_title.Text = "Tabla LL(1)";
            // 
            // lbl_subtitle_3
            // 
            this.lbl_subtitle_3.AutoSize = true;
            this.lbl_subtitle_3.Location = new System.Drawing.Point(840, 163);
            this.lbl_subtitle_3.Name = "lbl_subtitle_3";
            this.lbl_subtitle_3.Size = new System.Drawing.Size(112, 17);
            this.lbl_subtitle_3.TabIndex = 20;
            this.lbl_subtitle_3.Text = "Cadena / Sigma:";
            this.lbl_subtitle_3.Visible = false;
            // 
            // AnalizarLL1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1367, 688);
            this.Controls.Add(this.lbl_subtitle_3);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_limpiar_cadena);
            this.Controls.Add(this.lbl_tabla_ll1);
            this.Controls.Add(this.lbl_file_name);
            this.Controls.Add(this.btn_gram);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.analisarConLL1);
            this.Controls.Add(this.procesosAnalisis);
            this.Controls.Add(this.analisisAFD);
            this.Controls.Add(this.botonAnalisisRapido);
            this.Controls.Add(this.txt_sigma);
            this.Controls.Add(this.yylexBoton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tablaLL1);
            this.Controls.Add(this.tablaTerminales);
            this.Controls.Add(this.tablaNTerminales);
            this.Controls.Add(this.creaTabla);
            this.Controls.Add(this.gramatica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
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
        private System.Windows.Forms.TextBox txt_sigma;
        private System.Windows.Forms.Button botonAnalisisRapido;
        private System.Windows.Forms.DataGridView analisisAFD;
        private System.Windows.Forms.DataGridView procesosAnalisis;
        private System.Windows.Forms.Button analisarConLL1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_gram;
        private System.Windows.Forms.Label lbl_file_name;
        private System.Windows.Forms.Label lbl_tabla_ll1;
        private System.Windows.Forms.Button btn_limpiar_cadena;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_subtitle_3;
    }
}