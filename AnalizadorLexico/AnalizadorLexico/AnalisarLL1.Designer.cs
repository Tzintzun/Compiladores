
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
            ((System.ComponentModel.ISupportInitialize)(this.tablaNTerminales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaTerminales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaLL1)).BeginInit();
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
            // AnalisarLL1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 621);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox gramatica;
        private System.Windows.Forms.Button creaTabla;
        private System.Windows.Forms.DataGridView tablaNTerminales;
        private System.Windows.Forms.DataGridView tablaTerminales;
        private System.Windows.Forms.DataGridView tablaLL1;
    }
}