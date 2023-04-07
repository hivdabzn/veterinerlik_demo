namespace veterinerlik_demo
{
    partial class FrmSahipgiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSahipgiris));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_girisYap = new System.Windows.Forms.Button();
            this.Msk_TC = new System.Windows.Forms.MaskedTextBox();
            this.Txt_sifre = new System.Windows.Forms.TextBox();
            this.Lnk_üyeol = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(63, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Giriş Paneli";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "TC Kimlik No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre:";
            // 
            // Btn_girisYap
            // 
            this.Btn_girisYap.Location = new System.Drawing.Point(166, 151);
            this.Btn_girisYap.Name = "Btn_girisYap";
            this.Btn_girisYap.Size = new System.Drawing.Size(108, 37);
            this.Btn_girisYap.TabIndex = 3;
            this.Btn_girisYap.Text = "Giriş Yap";
            this.Btn_girisYap.UseVisualStyleBackColor = true;
            this.Btn_girisYap.Click += new System.EventHandler(this.Btn_girisYap_Click);
            // 
            // Msk_TC
            // 
            this.Msk_TC.Location = new System.Drawing.Point(138, 85);
            this.Msk_TC.Mask = "00000000000";
            this.Msk_TC.Name = "Msk_TC";
            this.Msk_TC.Size = new System.Drawing.Size(136, 27);
            this.Msk_TC.TabIndex = 4;
            this.Msk_TC.Text = "11111111111";
            this.Msk_TC.ValidatingType = typeof(int);
            // 
            // Txt_sifre
            // 
            this.Txt_sifre.Location = new System.Drawing.Point(138, 118);
            this.Txt_sifre.Name = "Txt_sifre";
            this.Txt_sifre.Size = new System.Drawing.Size(136, 27);
            this.Txt_sifre.TabIndex = 5;
            this.Txt_sifre.Text = "1111";
            this.Txt_sifre.UseSystemPasswordChar = true;
            // 
            // Lnk_üyeol
            // 
            this.Lnk_üyeol.AutoSize = true;
            this.Lnk_üyeol.Location = new System.Drawing.Point(293, 121);
            this.Lnk_üyeol.Name = "Lnk_üyeol";
            this.Lnk_üyeol.Size = new System.Drawing.Size(54, 19);
            this.Lnk_üyeol.TabIndex = 6;
            this.Lnk_üyeol.TabStop = true;
            this.Lnk_üyeol.Text = "Üye Ol";
            this.Lnk_üyeol.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Lnk_üyeol_LinkClicked);
            // 
            // FrmSahipgiris
            // 
            this.AcceptButton = this.Btn_girisYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(401, 208);
            this.Controls.Add(this.Lnk_üyeol);
            this.Controls.Add(this.Txt_sifre);
            this.Controls.Add(this.Msk_TC);
            this.Controls.Add(this.Btn_girisYap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSahipgiris";
            this.Text = "FrmSahipgiris";
            this.Load += new System.EventHandler(this.FrmSahipgiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_girisYap;
        private System.Windows.Forms.MaskedTextBox Msk_TC;
        private System.Windows.Forms.TextBox Txt_sifre;
        private System.Windows.Forms.LinkLabel Lnk_üyeol;
    }
}