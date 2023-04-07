namespace veterinerlik_demo
{
    partial class FrmGirisler
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirisler));
            this.Btn_SahipGiris = new System.Windows.Forms.Button();
            this.Btn_DoktorGiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_VetYönetim = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_SahipGiris
            // 
            this.Btn_SahipGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_SahipGiris.BackgroundImage")));
            this.Btn_SahipGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_SahipGiris.Location = new System.Drawing.Point(13, 128);
            this.Btn_SahipGiris.Name = "Btn_SahipGiris";
            this.Btn_SahipGiris.Size = new System.Drawing.Size(231, 101);
            this.Btn_SahipGiris.TabIndex = 0;
            this.Btn_SahipGiris.UseVisualStyleBackColor = true;
            this.Btn_SahipGiris.Click += new System.EventHandler(this.Btn_SahipGiris_Click);
            // 
            // Btn_DoktorGiris
            // 
            this.Btn_DoktorGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_DoktorGiris.BackgroundImage")));
            this.Btn_DoktorGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_DoktorGiris.Location = new System.Drawing.Point(300, 128);
            this.Btn_DoktorGiris.Name = "Btn_DoktorGiris";
            this.Btn_DoktorGiris.Size = new System.Drawing.Size(231, 101);
            this.Btn_DoktorGiris.TabIndex = 1;
            this.Btn_DoktorGiris.UseVisualStyleBackColor = true;
            this.Btn_DoktorGiris.Click += new System.EventHandler(this.Btn_DoktorGiris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sahip";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doktor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Vet Yönetim";
            // 
            // Btn_VetYönetim
            // 
            this.Btn_VetYönetim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_VetYönetim.BackgroundImage")));
            this.Btn_VetYönetim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_VetYönetim.Location = new System.Drawing.Point(171, 269);
            this.Btn_VetYönetim.Name = "Btn_VetYönetim";
            this.Btn_VetYönetim.Size = new System.Drawing.Size(231, 101);
            this.Btn_VetYönetim.TabIndex = 6;
            this.Btn_VetYönetim.UseVisualStyleBackColor = true;
            this.Btn_VetYönetim.Click += new System.EventHandler(this.Btn_VetYönetim_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(334, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(19, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 36);
            this.label5.TabIndex = 9;
            this.label5.Text = "AD Veterinerlik";
            // 
            // FrmGirisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Bisque;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(556, 404);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Btn_VetYönetim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_DoktorGiris);
            this.Controls.Add(this.Btn_SahipGiris);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmGirisler";
            this.Text = "Ad Veterinerlik Giriş";
            this.Load += new System.EventHandler(this.FrmGirisler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_SahipGiris;
        private System.Windows.Forms.Button Btn_DoktorGiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_VetYönetim;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
    }
}

