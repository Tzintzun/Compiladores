
namespace AnalizadorLexico
{
    partial class fmrDescRecGram_Gram
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
            this.btn_eval = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_file_name = new System.Windows.Forms.Label();
            this.afd_id = new System.Windows.Forms.Label();
            this.txt_afd_id = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_exp = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dgrid_reglas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_first = new System.Windows.Forms.TextBox();
            this.dgrid_first = new System.Windows.Forms.DataGridView();
            this.Simbolo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dgrid_follow = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_follow = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgrid_noTerminal = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_reglas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_first)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_follow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_noTerminal)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_eval
            // 
            this.btn_eval.Location = new System.Drawing.Point(633, 101);
            this.btn_eval.Name = "btn_eval";
            this.btn_eval.Size = new System.Drawing.Size(92, 44);
            this.btn_eval.TabIndex = 18;
            this.btn_eval.Text = "Analizar";
            this.btn_eval.UseVisualStyleBackColor = true;
            this.btn_eval.Click += new System.EventHandler(this.btn_eval_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Cadena a analizar sintácticamente:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_file_name);
            this.groupBox1.Controls.Add(this.afd_id);
            this.groupBox1.Controls.Add(this.txt_afd_id);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(24, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 150);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Analizador Léxico";
            // 
            // lbl_file_name
            // 
            this.lbl_file_name.AutoSize = true;
            this.lbl_file_name.Location = new System.Drawing.Point(118, 119);
            this.lbl_file_name.Name = "lbl_file_name";
            this.lbl_file_name.Size = new System.Drawing.Size(30, 17);
            this.lbl_file_name.TabIndex = 8;
            this.lbl_file_name.Text = "File";
            this.lbl_file_name.Visible = false;
            // 
            // afd_id
            // 
            this.afd_id.AutoSize = true;
            this.afd_id.Location = new System.Drawing.Point(27, 39);
            this.afd_id.Name = "afd_id";
            this.afd_id.Size = new System.Drawing.Size(86, 17);
            this.afd_id.TabIndex = 6;
            this.afd_id.Text = "Id Asignado:";
            // 
            // txt_afd_id
            // 
            this.txt_afd_id.Location = new System.Drawing.Point(119, 36);
            this.txt_afd_id.Name = "txt_afd_id";
            this.txt_afd_id.Size = new System.Drawing.Size(100, 22);
            this.txt_afd_id.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "Seleccionar archivo del AFD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_exp
            // 
            this.txt_exp.Location = new System.Drawing.Point(349, 49);
            this.txt_exp.Name = "txt_exp";
            this.txt_exp.Size = new System.Drawing.Size(667, 22);
            this.txt_exp.TabIndex = 17;
            this.txt_exp.TextChanged += new System.EventHandler(this.txt_exp_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dgrid_reglas
            // 
            this.dgrid_reglas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_reglas.Location = new System.Drawing.Point(24, 248);
            this.dgrid_reglas.MultiSelect = false;
            this.dgrid_reglas.Name = "dgrid_reglas";
            this.dgrid_reglas.ReadOnly = true;
            this.dgrid_reglas.RowHeadersWidth = 51;
            this.dgrid_reglas.RowTemplate.Height = 24;
            this.dgrid_reglas.Size = new System.Drawing.Size(307, 199);
            this.dgrid_reglas.TabIndex = 19;
            this.dgrid_reglas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_reglas_CellClick_1);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(21, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 39);
            this.label2.TabIndex = 20;
            this.label2.Text = "Doble clic para agregar a la cadena dónde se calculará Fisrt";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Lista de símbolos para calcular el First:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_first
            // 
            this.txt_first.Location = new System.Drawing.Point(349, 248);
            this.txt_first.Name = "txt_first";
            this.txt_first.ReadOnly = true;
            this.txt_first.Size = new System.Drawing.Size(283, 22);
            this.txt_first.TabIndex = 22;
            // 
            // dgrid_first
            // 
            this.dgrid_first.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_first.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Simbolo});
            this.dgrid_first.Location = new System.Drawing.Point(349, 276);
            this.dgrid_first.Name = "dgrid_first";
            this.dgrid_first.RowHeadersWidth = 51;
            this.dgrid_first.RowTemplate.Height = 24;
            this.dgrid_first.Size = new System.Drawing.Size(179, 171);
            this.dgrid_first.TabIndex = 23;
            this.dgrid_first.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Simbolo
            // 
            this.Simbolo.HeaderText = "Simbolo";
            this.Simbolo.MinimumWidth = 6;
            this.Simbolo.Name = "Simbolo";
            this.Simbolo.Width = 125;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(534, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 36);
            this.button2.TabIndex = 24;
            this.button2.Text = "Calcular Fist";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(534, 318);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 36);
            this.button3.TabIndex = 25;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(844, 248);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 36);
            this.button4.TabIndex = 30;
            this.button4.Text = "Reset";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dgrid_follow
            // 
            this.dgrid_follow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_follow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dgrid_follow.Location = new System.Drawing.Point(650, 276);
            this.dgrid_follow.Name = "dgrid_follow";
            this.dgrid_follow.RowHeadersWidth = 51;
            this.dgrid_follow.RowTemplate.Height = 24;
            this.dgrid_follow.Size = new System.Drawing.Size(180, 171);
            this.dgrid_follow.TabIndex = 28;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Simbolo";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // txt_follow
            // 
            this.txt_follow.Location = new System.Drawing.Point(650, 248);
            this.txt_follow.Name = "txt_follow";
            this.txt_follow.ReadOnly = true;
            this.txt_follow.Size = new System.Drawing.Size(180, 22);
            this.txt_follow.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(647, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(327, 39);
            this.label4.TabIndex = 26;
            this.label4.Text = "Lista de símbolos para calcular el Follow: (Clic en simbolo para buscar)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dgrid_noTerminal
            // 
            this.dgrid_noTerminal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_noTerminal.Location = new System.Drawing.Point(844, 290);
            this.dgrid_noTerminal.MultiSelect = false;
            this.dgrid_noTerminal.Name = "dgrid_noTerminal";
            this.dgrid_noTerminal.ReadOnly = true;
            this.dgrid_noTerminal.RowHeadersWidth = 51;
            this.dgrid_noTerminal.RowTemplate.Height = 24;
            this.dgrid_noTerminal.Size = new System.Drawing.Size(172, 157);
            this.dgrid_noTerminal.TabIndex = 31;
            this.dgrid_noTerminal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_noTerminal_CellClick);
            // 
            // fmrDescRecGram_Gram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 478);
            this.ControlBox = false;
            this.Controls.Add(this.dgrid_noTerminal);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dgrid_follow);
            this.Controls.Add(this.txt_follow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgrid_first);
            this.Controls.Add(this.txt_first);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgrid_reglas);
            this.Controls.Add(this.btn_eval);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_exp);
            this.Name = "fmrDescRecGram_Gram";
            this.Load += new System.EventHandler(this.DescRecGram_Gram_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_reglas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_first)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_follow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_noTerminal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_eval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_file_name;
        private System.Windows.Forms.Label afd_id;
        private System.Windows.Forms.TextBox txt_afd_id;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_exp;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dgrid_reglas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_first;
        private System.Windows.Forms.DataGridView dgrid_first;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Simbolo;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgrid_follow;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.TextBox txt_follow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgrid_noTerminal;
    }
}