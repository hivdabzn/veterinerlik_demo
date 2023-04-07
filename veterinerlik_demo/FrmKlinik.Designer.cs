namespace veterinerlik_demo
{
    partial class FrmKlinik
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
            this.Lnk_üyeol = new System.Windows.Forms.LinkLabel();
            this.Txt_sifre = new System.Windows.Forms.TextBox();
            this.Msk_İD = new System.Windows.Forms.MaskedTextBox();
            this.Btn_girisYap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cmb_sehir = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lnk_üyeol
            // 
            this.Lnk_üyeol.AutoSize = true;
            this.Lnk_üyeol.Location = new System.Drawing.Point(323, 172);
            this.Lnk_üyeol.Name = "Lnk_üyeol";
            this.Lnk_üyeol.Size = new System.Drawing.Size(65, 23);
            this.Lnk_üyeol.TabIndex = 13;
            this.Lnk_üyeol.TabStop = true;
            this.Lnk_üyeol.Text = "Üye Ol";
            this.Lnk_üyeol.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Lnk_üyeol_LinkClicked);
            // 
            // Txt_sifre
            // 
            this.Txt_sifre.Location = new System.Drawing.Point(171, 164);
            this.Txt_sifre.Name = "Txt_sifre";
            this.Txt_sifre.Size = new System.Drawing.Size(136, 31);
            this.Txt_sifre.TabIndex = 12;
            this.Txt_sifre.UseSystemPasswordChar = true;
            // 
            // Msk_İD
            // 
            this.Msk_İD.Location = new System.Drawing.Point(171, 93);
            this.Msk_İD.Mask = "00000000000";
            this.Msk_İD.Name = "Msk_İD";
            this.Msk_İD.Size = new System.Drawing.Size(136, 31);
            this.Msk_İD.TabIndex = 11;
            this.Msk_İD.ValidatingType = typeof(int);
            // 
            // Btn_girisYap
            // 
            this.Btn_girisYap.Location = new System.Drawing.Point(199, 210);
            this.Btn_girisYap.Name = "Btn_girisYap";
            this.Btn_girisYap.Size = new System.Drawing.Size(108, 37);
            this.Btn_girisYap.TabIndex = 10;
            this.Btn_girisYap.Text = "Giriş Yap";
            this.Btn_girisYap.UseVisualStyleBackColor = true;
            this.Btn_girisYap.Click += new System.EventHandler(this.Btn_girisYap_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Klinik İD:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(84, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "Klinik Giriş Paneli";
            // 
            // Cmb_sehir
            // 
            this.Cmb_sehir.FormattingEnabled = true;
            this.Cmb_sehir.Location = new System.Drawing.Point(171, 127);
            this.Cmb_sehir.Name = "Cmb_sehir";
            this.Cmb_sehir.Size = new System.Drawing.Size(136, 31);
            this.Cmb_sehir.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "Şehir:";
            // 
            // FrmKlinik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 284);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cmb_sehir);
            this.Controls.Add(this.Lnk_üyeol);
            this.Controls.Add(this.Txt_sifre);
            this.Controls.Add(this.Msk_İD);
            this.Controls.Add(this.Btn_girisYap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FrmKlinik";
            this.Text = "FrmKlinik";
            this.Load += new System.EventHandler(this.FrmKlinik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel Lnk_üyeol;
        private System.Windows.Forms.TextBox Txt_sifre;
        private System.Windows.Forms.MaskedTextBox Msk_İD;
        private System.Windows.Forms.Button Btn_girisYap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cmb_sehir;
        private System.Windows.Forms.Label label4;
    }
}