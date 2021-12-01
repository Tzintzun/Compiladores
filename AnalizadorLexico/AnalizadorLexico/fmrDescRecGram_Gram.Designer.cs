
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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_eval
            // 
            this.btn_eval.Location = new System.Drawing.Point(341, 281);
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
            this.label1.Location = new System.Drawing.Point(52, 232);
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
            this.groupBox1.Location = new System.Drawing.Point(55, 28);
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
            this.txt_exp.Location = new System.Drawing.Point(283, 229);
            this.txt_exp.Name = "txt_exp";
            this.txt_exp.Size = new System.Drawing.Size(505, 22);
            this.txt_exp.TabIndex = 17;
            this.txt_exp.TextChanged += new System.EventHandler(this.txt_exp_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fmrDescRecGram_Gram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btn_eval);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_exp);
            this.Name = "fmrDescRecGram_Gram";
            this.Load += new System.EventHandler(this.DescRecGram_Gram_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}