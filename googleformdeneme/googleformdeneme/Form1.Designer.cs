namespace googleformdeneme
{
    partial class Form1
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
            this.baglanbtn = new System.Windows.Forms.Button();
            this.txtbox1 = new System.Windows.Forms.TextBox();
            this.uploadbtn = new System.Windows.Forms.Button();
            this.txtbox2 = new System.Windows.Forms.TextBox();
            this.btnklasor = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // baglanbtn
            // 
            this.baglanbtn.Location = new System.Drawing.Point(52, 37);
            this.baglanbtn.Name = "baglanbtn";
            this.baglanbtn.Size = new System.Drawing.Size(656, 47);
            this.baglanbtn.TabIndex = 0;
            this.baglanbtn.Text = "Bağlan";
            this.baglanbtn.UseVisualStyleBackColor = true;
            this.baglanbtn.Click += new System.EventHandler(this.baglanbtn_Click);
            // 
            // txtbox1
            // 
            this.txtbox1.Location = new System.Drawing.Point(52, 135);
            this.txtbox1.Multiline = true;
            this.txtbox1.Name = "txtbox1";
            this.txtbox1.Size = new System.Drawing.Size(342, 37);
            this.txtbox1.TabIndex = 1;
            this.txtbox1.Text = "Dosya yolunu giriniz";
            // 
            // uploadbtn
            // 
            this.uploadbtn.Location = new System.Drawing.Point(499, 128);
            this.uploadbtn.Name = "uploadbtn";
            this.uploadbtn.Size = new System.Drawing.Size(193, 44);
            this.uploadbtn.TabIndex = 2;
            this.uploadbtn.Text = "Dosya Yükle";
            this.uploadbtn.UseVisualStyleBackColor = true;
            this.uploadbtn.Click += new System.EventHandler(this.uploadbtn_Click);
            // 
            // txtbox2
            // 
            this.txtbox2.Location = new System.Drawing.Point(52, 226);
            this.txtbox2.Multiline = true;
            this.txtbox2.Name = "txtbox2";
            this.txtbox2.Size = new System.Drawing.Size(342, 37);
            this.txtbox2.TabIndex = 3;
            // 
            // btnklasor
            // 
            this.btnklasor.Location = new System.Drawing.Point(499, 219);
            this.btnklasor.Name = "btnklasor";
            this.btnklasor.Size = new System.Drawing.Size(193, 44);
            this.btnklasor.TabIndex = 4;
            this.btnklasor.Text = "Klasör Yarat";
            this.btnklasor.UseVisualStyleBackColor = true;
            this.btnklasor.Click += new System.EventHandler(this.btnklasor_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(63, 316);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(658, 276);
            this.listBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 615);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnklasor);
            this.Controls.Add(this.txtbox2);
            this.Controls.Add(this.uploadbtn);
            this.Controls.Add(this.txtbox1);
            this.Controls.Add(this.baglanbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button baglanbtn;
        private System.Windows.Forms.TextBox txtbox1;
        private System.Windows.Forms.Button uploadbtn;
        private System.Windows.Forms.TextBox txtbox2;
        private System.Windows.Forms.Button btnklasor;
        private System.Windows.Forms.ListBox listBox1;
    }
}

