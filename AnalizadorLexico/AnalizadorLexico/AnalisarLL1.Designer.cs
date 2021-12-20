
namespace AnalizadorLexico
{
    partial class AnalisarLL1
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
            ((System.ComponentModel.ISupportInitialize)(this.tablaNTerminales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaTerminales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaLL1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.analisisAFD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procesosAnalisis)).BeginInit();
            this.SuspendLayout();
            // 
            // gramatica
            // 
            this.gramatica.Location = new System.Drawing.Point(63, 38);
            this.gramatica.Name = "gramatica";
            this.gramatica.Size = new System.Drawing.Size(843, 20);
            this.gramatica.TabIndex = 0;
            // 
            // creaTabla
            // 
            this.creaTabla.Location = new System.Drawing.Point(422, 64);
            this.creaTabla.Name = "creaTabla";
            this.creaTabla.Size = new System.Drawing.Size(121, 23);
            this.creaTabla.TabIndex = 1;
            this.creaTabla.Text = "Crear tabla LL1";
            this.creaTabla.UseVisualStyleBackColor = true;
            this.creaTabla.Click += new System.EventHandler(this.creaTabla_Click);
            // 
            // tablaNTerminales
            // 
            this.tablaNTerminales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaNTerminales.Location = new System.Drawing.Point(39, 131);
            this.tablaNTerminales.Name = "tablaNTerminales";
            this.tablaNTerminales.Size = new System.Drawing.Size(199, 174);
            this.tablaNTerminales.TabIndex = 2;
            // 
            // tablaTerminales
            // 
            this.tablaTerminales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaTerminales.Location = new System.Drawing.Point(260, 132);
            this.tablaTerminales.Name = "tablaTerminales";
            this.tablaTerminales.Size = new System.Drawing.Size(209, 174);
            this.tablaTerminales.TabIndex = 3;
            // 
            // tablaLL1
            // 
            this.tablaLL1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaLL1.Location = new System.Drawing.Point(39, 312);
            this.tablaLL1.Name = "tablaLL1";
            this.tablaLL1.Size = new System.Drawing.Size(430, 268);
            this.tablaLL1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "No terminales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Terminales";
            // 
            // yylexBoton
            // 
            this.yylexBoton.Location = new System.Drawing.Point(520, 132);
            this.yylexBoton.Name = "yylexBoton";
            this.yylexBoton.Size = new System.Drawing.Size(75, 43);
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
            this.textBox1.Location = new System.Drawing.Point(631, 132);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 8;
            // 
            // botonAnalisisRapido
            // 
            this.botonAnalisisRapido.Location = new System.Drawing.Point(631, 158);
            this.botonAnalisisRapido.Name = "botonAnalisisRapido";
            this.botonAnalisisRapido.Size = new System.Drawing.Size(137, 23);
            this.botonAnalisisRapido.TabIndex = 9;
            this.botonAnalisisRapido.Text = "Comprobar AFD";
            this.botonAnalisisRapido.UseVisualStyleBackColor = true;
            this.botonAnalisisRapido.Click += new System.EventHandler(this.botonAnalisisRapido_Click);
            // 
            // analisisAFD
            // 
            this.analisisAFD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.analisisAFD.Location = new System.Drawing.Point(837, 132);
            this.analisisAFD.Name = "analisisAFD";
            this.analisisAFD.Size = new System.Drawing.Size(141, 150);
            this.analisisAFD.TabIndex = 10;
            // 
            // procesosAnalisis
            // 
            this.procesosAnalisis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.procesosAnalisis.Location = new System.Drawing.Point(486, 312);
            this.procesosAnalisis.Name = "procesosAnalisis";
            this.procesosAnalisis.Size = new System.Drawing.Size(492, 268);
            this.procesosAnalisis.TabIndex = 11;
            // 
            // analisarConLL1
            // 
            this.analisarConLL1.Location = new System.Drawing.Point(520, 258);
            this.analisarConLL1.Name = "analisarConLL1";
            this.analisarConLL1.Size = new System.Drawing.Size(139, 23);
            this.analisarConLL1.TabIndex = 12;
            this.analisarConLL1.Text = "Analisar cadena";
            this.analisarConLL1.UseVisualStyleBackColor = true;
            this.analisarConLL1.Click += new System.EventHandler(this.analisarConLL1_Click);
            // 
            // AnalisarLL1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 621);
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
            this.Name = "AnalisarLL1";
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
    }
}