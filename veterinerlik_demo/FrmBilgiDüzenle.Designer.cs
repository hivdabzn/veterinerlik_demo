namespace veterinerlik_demo
{
    partial class FrmBilgiDüzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBilgiDüzenle));
            this.Btn_Güncelle = new System.Windows.Forms.Button();
            this.Cmb_hayvantur = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Msk_telefon = new System.Windows.Forms.MaskedTextBox();
            this.Txt_sifre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_soyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Ad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Msk_TC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_HayvanYas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Güncelle
            // 
            this.Btn_Güncelle.BackColor = System.Drawing.Color.OrangeRed;
            this.Btn_Güncelle.Location = new System.Drawing.Point(166, 278);
            this.Btn_Güncelle.Name = "Btn_Güncelle";
            this.Btn_Güncelle.Size = new System.Drawing.Size(136, 35);
            this.Btn_Güncelle.TabIndex = 7;
            this.Btn_Güncelle.Text = "Güncelle";
            this.Btn_Güncelle.UseVisualStyleBackColor = false;
            this.Btn_Güncelle.Click += new System.EventHandler(this.Btn_Güncelle_Click);
            // 
            // Cmb_hayvantur
            // 
            this.Cmb_hayvantur.FormattingEnabled = true;
            this.Cmb_hayvantur.Items.AddRange(new object[] {
            "Evcil Hayvan",
            "Çiftlik Hayvanları"});
            this.Cmb_hayvantur.Location = new System.Drawing.Point(166, 198);
            this.Cmb_hayvantur.Name = "Cmb_hayvantur";
            this.Cmb_hayvantur.Size = new System.Drawing.Size(136, 31);
            this.Cmb_hayvantur.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-1, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 23);
            this.label6.TabIndex = 30;
            this.label6.Text = "Evcil Hayvan Türü:";
            // 
            // Msk_telefon
            // 
            this.Msk_telefon.Location = new System.Drawing.Point(166, 124);
            this.Msk_telefon.Mask = "(999) 000-0000";
            this.Msk_telefon.Name = "Msk_telefon";
            this.Msk_telefon.Size = new System.Drawing.Size(136, 31);
            this.Msk_telefon.TabIndex = 4;
            // 
            // Txt_sifre
            // 
            this.Txt_sifre.Location = new System.Drawing.Point(166, 161);
            this.Txt_sifre.Name = "Txt_sifre";
            this.Txt_sifre.Size = new System.Drawing.Size(136, 31);
            this.Txt_sifre.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 23);
            this.label5.TabIndex = 27;
            this.label5.Text = "Şifre:";
            // 
            // Txt_soyad
            // 
            this.Txt_soyad.Location = new System.Drawing.Point(166, 49);
            this.Txt_soyad.Name = "Txt_soyad";
            this.Txt_soyad.Size = new System.Drawing.Size(136, 31);
            this.Txt_soyad.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 23);
            this.label4.TabIndex = 25;
            this.label4.Text = "Soyad:";
            // 
            // Txt_Ad
            // 
            this.Txt_Ad.Location = new System.Drawing.Point(166, 12);
            this.Txt_Ad.Name = "Txt_Ad";
            this.Txt_Ad.Size = new System.Drawing.Size(136, 31);
            this.Txt_Ad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Ad:";
            // 
            // Msk_TC
            // 
            this.Msk_TC.Location = new System.Drawing.Point(166, 86);
            this.Msk_TC.Mask = "00000000000";
            this.Msk_TC.Name = "Msk_TC";
            this.Msk_TC.Size = new System.Drawing.Size(136, 31);
            this.Msk_TC.TabIndex = 3;
            this.Msk_TC.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Telefon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "TC Kimlik No:";
            // 
            // Txt_HayvanYas
            // 
            this.Txt_HayvanYas.Location = new System.Drawing.Point(166, 235);
            this.Txt_HayvanYas.Name = "Txt_HayvanYas";
            this.Txt_HayvanYas.Size = new System.Drawing.Size(136, 31);
            this.Txt_HayvanYas.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 23);
            this.label7.TabIndex = 32;
            this.label7.Text = "Hayvanın Yaşı:";
            // 
            // FrmBilgiDüzenle
            // 
            this.AcceptButton = this.Btn_Güncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(331, 330);
            this.Controls.Add(this.Txt_HayvanYas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Btn_Güncelle);
            this.Controls.Add(this.Cmb_hayvantur);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Msk_telefon);
            this.Controls.Add(this.Txt_sifre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_soyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_Ad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Msk_TC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FrmBilgiDüzenle";
            this.Text = "FrmBilgiDüzenle";
            this.Load += new System.EventHandler(this.FrmBilgiDüzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Güncelle;
        private System.Windows.Forms.ComboBox Cmb_hayvantur;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox Msk_telefon;
        private System.Windows.Forms.TextBox Txt_sifre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_soyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Ad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox Msk_TC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_HayvanYas;
        private System.Windows.Forms.Label label7;
    }
}