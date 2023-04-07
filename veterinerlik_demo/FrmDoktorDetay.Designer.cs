namespace veterinerlik_demo
{
    partial class FrmDoktorDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorDetay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Lbl_adSoyad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Lbl_Tc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Rch_sikayet = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Btn_cikis = new System.Windows.Forms.Button();
            this.Btn_duyurular = new System.Windows.Forms.Button();
            this.Btn_güncelle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Lbl_adSoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Lbl_Tc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(270, 109);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktor Bilgi";
            // 
            // Lbl_adSoyad
            // 
            this.Lbl_adSoyad.AutoSize = true;
            this.Lbl_adSoyad.Location = new System.Drawing.Point(78, 72);
            this.Lbl_adSoyad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_adSoyad.Name = "Lbl_adSoyad";
            this.Lbl_adSoyad.Size = new System.Drawing.Size(70, 19);
            this.Lbl_adSoyad.TabIndex = 3;
            this.Lbl_adSoyad.Text = "Null Null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ad Soyad:";
            // 
            // Lbl_Tc
            // 
            this.Lbl_Tc.AutoSize = true;
            this.Lbl_Tc.Location = new System.Drawing.Point(78, 36);
            this.Lbl_Tc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Tc.Name = "Lbl_Tc";
            this.Lbl_Tc.Size = new System.Drawing.Size(97, 19);
            this.Lbl_Tc.TabIndex = 1;
            this.Lbl_Tc.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC No:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Rch_sikayet);
            this.groupBox2.Location = new System.Drawing.Point(11, 124);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(269, 207);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Detay";
            // 
            // Rch_sikayet
            // 
            this.Rch_sikayet.Location = new System.Drawing.Point(5, 25);
            this.Rch_sikayet.Margin = new System.Windows.Forms.Padding(2);
            this.Rch_sikayet.Name = "Rch_sikayet";
            this.Rch_sikayet.Size = new System.Drawing.Size(231, 166);
            this.Rch_sikayet.TabIndex = 5;
            this.Rch_sikayet.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(284, 10);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(342, 428);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(2, 22);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(338, 404);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Btn_cikis);
            this.groupBox4.Controls.Add(this.Btn_duyurular);
            this.groupBox4.Controls.Add(this.Btn_güncelle);
            this.groupBox4.Location = new System.Drawing.Point(10, 335);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(269, 102);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // Btn_cikis
            // 
            this.Btn_cikis.Location = new System.Drawing.Point(6, 64);
            this.Btn_cikis.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_cikis.Name = "Btn_cikis";
            this.Btn_cikis.Size = new System.Drawing.Size(254, 24);
            this.Btn_cikis.TabIndex = 2;
            this.Btn_cikis.Text = "Çıkış";
            this.Btn_cikis.UseVisualStyleBackColor = true;
            this.Btn_cikis.Click += new System.EventHandler(this.Btn_cikis_Click);
            // 
            // Btn_duyurular
            // 
            this.Btn_duyurular.Location = new System.Drawing.Point(135, 36);
            this.Btn_duyurular.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_duyurular.Name = "Btn_duyurular";
            this.Btn_duyurular.Size = new System.Drawing.Size(125, 24);
            this.Btn_duyurular.TabIndex = 1;
            this.Btn_duyurular.Text = "Duyurular";
            this.Btn_duyurular.UseVisualStyleBackColor = true;
            // 
            // Btn_güncelle
            // 
            this.Btn_güncelle.Location = new System.Drawing.Point(5, 36);
            this.Btn_güncelle.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_güncelle.Name = "Btn_güncelle";
            this.Btn_güncelle.Size = new System.Drawing.Size(125, 24);
            this.Btn_güncelle.TabIndex = 0;
            this.Btn_güncelle.Text = "Bilgi Düzenle";
            this.Btn_güncelle.UseVisualStyleBackColor = true;
            this.Btn_güncelle.Click += new System.EventHandler(this.Btn_güncelle_Click);
            // 
            // FrmDoktorDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(632, 444);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmDoktorDetay";
            this.Text = "FrmDoktorDetay";
            this.Load += new System.EventHandler(this.FrmDoktorDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Lbl_adSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lbl_Tc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox Rch_sikayet;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Btn_cikis;
        private System.Windows.Forms.Button Btn_duyurular;
        private System.Windows.Forms.Button Btn_güncelle;
    }
}