﻿namespace veterinerlik_demo
{
    partial class Frmdoktorgiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmdoktorgiris));
            this.Txt_sifre = new System.Windows.Forms.TextBox();
            this.Msk_TC = new System.Windows.Forms.MaskedTextBox();
            this.Btn_girisYap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_sifre
            // 
            this.Txt_sifre.Location = new System.Drawing.Point(191, 167);
            this.Txt_sifre.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Txt_sifre.Name = "Txt_sifre";
            this.Txt_sifre.Size = new System.Drawing.Size(173, 27);
            this.Txt_sifre.TabIndex = 12;
            this.Txt_sifre.Text = "12345";
            this.Txt_sifre.UseSystemPasswordChar = true;
            // 
            // Msk_TC
            // 
            this.Msk_TC.Location = new System.Drawing.Point(191, 119);
            this.Msk_TC.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Msk_TC.Mask = "00000000000";
            this.Msk_TC.Name = "Msk_TC";
            this.Msk_TC.Size = new System.Drawing.Size(173, 27);
            this.Msk_TC.TabIndex = 11;
            this.Msk_TC.Text = "33333333333";
            this.Msk_TC.ValidatingType = typeof(int);
            // 
            // Btn_girisYap
            // 
            this.Btn_girisYap.Location = new System.Drawing.Point(212, 202);
            this.Btn_girisYap.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Btn_girisYap.Name = "Btn_girisYap";
            this.Btn_girisYap.Size = new System.Drawing.Size(133, 33);
            this.Btn_girisYap.TabIndex = 10;
            this.Btn_girisYap.Text = "Giriş Yap";
            this.Btn_girisYap.UseVisualStyleBackColor = true;
            this.Btn_girisYap.Click += new System.EventHandler(this.Btn_girisYap_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "TC Kimlik No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(22, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "Doktor Giriş Paneli";
            // 
            // Frmdoktorgiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(424, 296);
            this.Controls.Add(this.Txt_sifre);
            this.Controls.Add(this.Msk_TC);
            this.Controls.Add(this.Btn_girisYap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "Frmdoktorgiris";
            this.Text = "Frmdoktorgiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_sifre;
        private System.Windows.Forms.MaskedTextBox Msk_TC;
        private System.Windows.Forms.Button Btn_girisYap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}