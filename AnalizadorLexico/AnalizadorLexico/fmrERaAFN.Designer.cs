
namespace AnalizadorLexico
{
    partial class fmrERaAFN
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_file_name = new System.Windows.Forms.Label();
            this.afd_id = new System.Windows.Forms.Label();
            this.txt_afd_id = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txt_exp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_afn_id = new System.Windows.Forms.TextBox();
            this.btn_crear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_file_name);
            this.groupBox1.Controls.Add(this.afd_id);
            this.groupBox1.Controls.Add(this.txt_afd_id);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(25, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(230, 122);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Analizador Léxico";
            // 
            // lbl_file_name
            // 
            this.lbl_file_name.AutoSize = true;
            this.lbl_file_name.Location = new System.Drawing.Point(88, 97);
            this.lbl_file_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_file_name.Name = "lbl_file_name";
            this.lbl_file_name.Size = new System.Drawing.Size(23, 13);
            this.lbl_file_name.TabIndex = 8;
            this.lbl_file_name.Text = "File";
            this.lbl_file_name.Visible = false;
            // 
            // afd_id
            // 
            this.afd_id.AutoSize = true;
            this.afd_id.Location = new System.Drawing.Point(20, 32);
            this.afd_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.afd_id.Name = "afd_id";
            this.afd_id.Size = new System.Drawing.Size(66, 13);
            this.afd_id.TabIndex = 6;
            this.afd_id.Text = "Id Asignado:";
            // 
            // txt_afd_id
            // 
            this.txt_afd_id.Location = new System.Drawing.Point(89, 29);
            this.txt_afd_id.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_afd_id.Name = "txt_afd_id";
            this.txt_afd_id.Size = new System.Drawing.Size(76, 20);
            this.txt_afd_id.TabIndex = 7;
            this.txt_afd_id.TextChanged += new System.EventHandler(this.txt_afd_id_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 59);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Seleccionar archivo del AFD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txt_exp
            // 
            this.txt_exp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_exp.Location = new System.Drawing.Point(170, 179);
            this.txt_exp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_exp.Name = "txt_exp";
            this.txt_exp.Size = new System.Drawing.Size(354, 23);
            this.txt_exp.TabIndex = 10;
            this.txt_exp.TextChanged += new System.EventHandler(this.txt_exp_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 179);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Expresión Regular:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 214);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Id del AFN:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_afn_id
            // 
            this.txt_afn_id.Location = new System.Drawing.Point(169, 214);
            this.txt_afn_id.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_afn_id.Name = "txt_afn_id";
            this.txt_afn_id.Size = new System.Drawing.Size(54, 20);
            this.txt_afn_id.TabIndex = 13;
            this.txt_afn_id.TextChanged += new System.EventHandler(this.txt_afn_id_TextChanged);
            // 
            // btn_crear
            // 
            this.btn_crear.Location = new System.Drawing.Point(48, 259);
            this.btn_crear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_crear.Name = "btn_crear";
            this.btn_crear.Size = new System.Drawing.Size(72, 35);
            this.btn_crear.TabIndex = 14;
            this.btn_crear.Text = "Crear AFN";
            this.btn_crear.UseVisualStyleBackColor = true;
            this.btn_crear.Click += new System.EventHandler(this.button2_Click);
            // 
            // fmrERaAFN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.ControlBox = false;
            this.Controls.Add(this.btn_crear);
            this.Controls.Add(this.txt_afn_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_exp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fmrERaAFN";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_file_name;
        private System.Windows.Forms.Label afd_id;
        private System.Windows.Forms.TextBox txt_afd_id;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txt_exp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_afn_id;
        private System.Windows.Forms.Button btn_crear;
    }
}