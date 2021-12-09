
namespace AnalizadorLexico
{
    partial class fmrAnalisisLL1
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
            this.txt_gram = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_crear_tabla = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.dgrid_no_terminal = new System.Windows.Forms.DataGridView();
            this.dgrid_terminales_token = new System.Windows.Forms.DataGridView();
            this.dgrid_tabla_ll1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_no_terminal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_terminales_token)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_tabla_ll1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_gram
            // 
            this.txt_gram.Location = new System.Drawing.Point(92, 42);
            this.txt_gram.Name = "txt_gram";
            this.txt_gram.Size = new System.Drawing.Size(682, 22);
            this.txt_gram.TabIndex = 0;
            this.txt_gram.Text = "E-> T Ep; Ep -> mas T Ep | menos T Ep| epsilon; T-> F Tp; Tp-> prod F Tp | div F " +
    "Tp| epsilon; F-> parI E parD | num;";
            this.txt_gram.TextChanged += new System.EventHandler(this.txt_gram_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Grámatica:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(335, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "ANÁLISIS LL(1)";
            // 
            // btn_crear_tabla
            // 
            this.btn_crear_tabla.Location = new System.Drawing.Point(92, 80);
            this.btn_crear_tabla.Name = "btn_crear_tabla";
            this.btn_crear_tabla.Size = new System.Drawing.Size(96, 33);
            this.btn_crear_tabla.TabIndex = 3;
            this.btn_crear_tabla.Text = "Crear tabla";
            this.btn_crear_tabla.UseVisualStyleBackColor = true;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(209, 80);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(96, 33);
            this.btn_reset.TabIndex = 4;
            this.btn_reset.Text = "Limpiar";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // dgrid_no_terminal
            // 
            this.dgrid_no_terminal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_no_terminal.Location = new System.Drawing.Point(15, 134);
            this.dgrid_no_terminal.Name = "dgrid_no_terminal";
            this.dgrid_no_terminal.RowHeadersWidth = 51;
            this.dgrid_no_terminal.RowTemplate.Height = 24;
            this.dgrid_no_terminal.Size = new System.Drawing.Size(187, 203);
            this.dgrid_no_terminal.TabIndex = 5;
            // 
            // dgrid_terminales_token
            // 
            this.dgrid_terminales_token.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_terminales_token.Location = new System.Drawing.Point(248, 134);
            this.dgrid_terminales_token.Name = "dgrid_terminales_token";
            this.dgrid_terminales_token.RowHeadersWidth = 51;
            this.dgrid_terminales_token.RowTemplate.Height = 24;
            this.dgrid_terminales_token.Size = new System.Drawing.Size(187, 203);
            this.dgrid_terminales_token.TabIndex = 6;
            // 
            // dgrid_tabla_ll1
            // 
            this.dgrid_tabla_ll1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_tabla_ll1.Location = new System.Drawing.Point(15, 385);
            this.dgrid_tabla_ll1.Name = "dgrid_tabla_ll1";
            this.dgrid_tabla_ll1.RowHeadersWidth = 51;
            this.dgrid_tabla_ll1.RowTemplate.Height = 24;
            this.dgrid_tabla_ll1.Size = new System.Drawing.Size(420, 203);
            this.dgrid_tabla_ll1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tabla LL(1)";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 612);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgrid_tabla_ll1);
            this.Controls.Add(this.dgrid_terminales_token);
            this.Controls.Add(this.dgrid_no_terminal);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_crear_tabla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_gram);
            this.Name = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_no_terminal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_terminales_token)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_tabla_ll1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_gram;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_crear_tabla;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.DataGridView dgrid_no_terminal;
        private System.Windows.Forms.DataGridView dgrid_terminales_token;
        private System.Windows.Forms.DataGridView dgrid_tabla_ll1;
        private System.Windows.Forms.Label label3;
    }
}