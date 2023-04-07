namespace veterinerlik_demo
{
    partial class FrmSekreterDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSekreterDetay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Lbl_AdSoyad = new System.Windows.Forms.Label();
            this.Lbl_TC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_DuyuruOluştur = new System.Windows.Forms.Button();
            this.Rch_Duyuru = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Cmb_doktor = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Btn_Kaydet = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Msk_TC = new System.Windows.Forms.MaskedTextBox();
            this.Msk_Saat = new System.Windows.Forms.MaskedTextBox();
            this.Msk_Tarih = new System.Windows.Forms.MaskedTextBox();
            this.Txt_id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Btn_RandevuListe = new System.Windows.Forms.Button();
            this.Btn_DoktorPaneli = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Lbl_AdSoyad);
            this.groupBox1.Controls.Add(this.Lbl_TC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sekreter Bilgi";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Lbl_AdSoyad
            // 
            this.Lbl_AdSoyad.AutoSize = true;
            this.Lbl_AdSoyad.Location = new System.Drawing.Point(102, 88);
            this.Lbl_AdSoyad.Name = "Lbl_AdSoyad";
            this.Lbl_AdSoyad.Size = new System.Drawing.Size(82, 23);
            this.Lbl_AdSoyad.TabIndex = 3;
            this.Lbl_AdSoyad.Text = "Null Null";
            // 
            // Lbl_TC
            // 
            this.Lbl_TC.AutoSize = true;
            this.Lbl_TC.Location = new System.Drawing.Point(102, 42);
            this.Lbl_TC.Name = "Lbl_TC";
            this.Lbl_TC.Size = new System.Drawing.Size(120, 23);
            this.Lbl_TC.TabIndex = 2;
            this.Lbl_TC.Text = "00000000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC No:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btn_DuyuruOluştur);
            this.groupBox2.Controls.Add(this.Rch_Duyuru);
            this.groupBox2.Location = new System.Drawing.Point(12, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 199);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duyuru Oluştur";
            // 
            // Btn_DuyuruOluştur
            // 
            this.Btn_DuyuruOluştur.Location = new System.Drawing.Point(8, 148);
            this.Btn_DuyuruOluştur.Name = "Btn_DuyuruOluştur";
            this.Btn_DuyuruOluştur.Size = new System.Drawing.Size(232, 35);
            this.Btn_DuyuruOluştur.TabIndex = 1;
            this.Btn_DuyuruOluştur.Text = "Oluştur";
            this.Btn_DuyuruOluştur.UseVisualStyleBackColor = true;
            this.Btn_DuyuruOluştur.Click += new System.EventHandler(this.Btn_DuyuruOluştur_Click);
            // 
            // Rch_Duyuru
            // 
            this.Rch_Duyuru.Location = new System.Drawing.Point(8, 30);
            this.Rch_Duyuru.Name = "Rch_Duyuru";
            this.Rch_Duyuru.Size = new System.Drawing.Size(232, 112);
            this.Rch_Duyuru.TabIndex = 0;
            this.Rch_Duyuru.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Cmb_doktor);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.Btn_Kaydet);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.Msk_TC);
            this.groupBox3.Controls.Add(this.Msk_Saat);
            this.groupBox3.Controls.Add(this.Msk_Tarih);
            this.groupBox3.Controls.Add(this.Txt_id);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(264, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(259, 362);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Paneli";
            // 
            // Cmb_doktor
            // 
            this.Cmb_doktor.FormattingEnabled = true;
            this.Cmb_doktor.Location = new System.Drawing.Point(84, 189);
            this.Cmb_doktor.Name = "Cmb_doktor";
            this.Cmb_doktor.Size = new System.Drawing.Size(136, 31);
            this.Cmb_doktor.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 23);
            this.label9.TabIndex = 15;
            this.label9.Text = "Doktor:";
            // 
            // Btn_Kaydet
            // 
            this.Btn_Kaydet.Location = new System.Drawing.Point(84, 280);
            this.Btn_Kaydet.Name = "Btn_Kaydet";
            this.Btn_Kaydet.Size = new System.Drawing.Size(154, 41);
            this.Btn_Kaydet.TabIndex = 2;
            this.Btn_Kaydet.Text = "Kaydet";
            this.Btn_Kaydet.UseVisualStyleBackColor = true;
            this.Btn_Kaydet.Click += new System.EventHandler(this.Btn_Kaydet_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(84, 226);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(85, 27);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Durum";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Msk_TC
            // 
            this.Msk_TC.Location = new System.Drawing.Point(84, 152);
            this.Msk_TC.Mask = "00000000000";
            this.Msk_TC.Name = "Msk_TC";
            this.Msk_TC.Size = new System.Drawing.Size(136, 31);
            this.Msk_TC.TabIndex = 12;
            this.Msk_TC.ValidatingType = typeof(int);
            // 
            // Msk_Saat
            // 
            this.Msk_Saat.Location = new System.Drawing.Point(84, 114);
            this.Msk_Saat.Mask = "00:00";
            this.Msk_Saat.Name = "Msk_Saat";
            this.Msk_Saat.Size = new System.Drawing.Size(136, 31);
            this.Msk_Saat.TabIndex = 11;
            this.Msk_Saat.ValidatingType = typeof(System.DateTime);
            // 
            // Msk_Tarih
            // 
            this.Msk_Tarih.Location = new System.Drawing.Point(84, 77);
            this.Msk_Tarih.Mask = "00/00/0000";
            this.Msk_Tarih.Name = "Msk_Tarih";
            this.Msk_Tarih.Size = new System.Drawing.Size(136, 31);
            this.Msk_Tarih.TabIndex = 10;
            this.Msk_Tarih.ValidatingType = typeof(System.DateTime);
            // 
            // Txt_id
            // 
            this.Txt_id.Location = new System.Drawing.Point(84, 39);
            this.Txt_id.Name = "Txt_id";
            this.Txt_id.Size = new System.Drawing.Size(136, 31);
            this.Txt_id.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "TC No:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Saat:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tarih:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "id:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(529, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(239, 469);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Doktorlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(233, 439);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.Btn_RandevuListe);
            this.groupBox5.Controls.Add(this.Btn_DoktorPaneli);
            this.groupBox5.Location = new System.Drawing.Point(12, 397);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(511, 84);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Hızlı Erişim";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(343, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Duyurular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_RandevuListe
            // 
            this.Btn_RandevuListe.Location = new System.Drawing.Point(174, 30);
            this.Btn_RandevuListe.Name = "Btn_RandevuListe";
            this.Btn_RandevuListe.Size = new System.Drawing.Size(147, 37);
            this.Btn_RandevuListe.TabIndex = 1;
            this.Btn_RandevuListe.Text = "Randevu Liste";
            this.Btn_RandevuListe.UseVisualStyleBackColor = true;
            this.Btn_RandevuListe.Click += new System.EventHandler(this.Btn_RandevuListe_Click);
            // 
            // Btn_DoktorPaneli
            // 
            this.Btn_DoktorPaneli.Location = new System.Drawing.Point(8, 30);
            this.Btn_DoktorPaneli.Name = "Btn_DoktorPaneli";
            this.Btn_DoktorPaneli.Size = new System.Drawing.Size(147, 37);
            this.Btn_DoktorPaneli.TabIndex = 0;
            this.Btn_DoktorPaneli.Text = "Doktor Paneli";
            this.Btn_DoktorPaneli.UseVisualStyleBackColor = true;
            this.Btn_DoktorPaneli.Click += new System.EventHandler(this.Btn_DoktorPaneli_Click);
            // 
            // FrmSekreterDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(778, 489);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FrmSekreterDetay";
            this.Text = "FrmSekreterDetay";
            this.Load += new System.EventHandler(this.FrmSekreterDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Lbl_AdSoyad;
        private System.Windows.Forms.Label Lbl_TC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btn_DuyuruOluştur;
        private System.Windows.Forms.RichTextBox Rch_Duyuru;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.MaskedTextBox Msk_TC;
        private System.Windows.Forms.MaskedTextBox Msk_Saat;
        private System.Windows.Forms.MaskedTextBox Msk_Tarih;
        private System.Windows.Forms.TextBox Txt_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Btn_Kaydet;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox Cmb_doktor;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button Btn_RandevuListe;
        private System.Windows.Forms.Button Btn_DoktorPaneli;
        private System.Windows.Forms.Button button1;
    }
}