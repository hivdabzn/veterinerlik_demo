using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace veterinerlik_demo
{
    public partial class FrmBilgiDüzenle : Form
    {
        public FrmBilgiDüzenle()
        {
            InitializeComponent();
        }

        public string TCno;

        Sqlbaglantisi bgl = new Sqlbaglantisi();

        private void FrmBilgiDüzenle_Load(object sender, EventArgs e)
        {
            Msk_TC.Text = TCno;
            SqlCommand komutt = new SqlCommand("Select * From Tbl_HastaSahip where SahipTC=@p1", bgl.Baglanti());
            komutt.Parameters.AddWithValue("@p1", Msk_TC.Text);
            SqlDataReader dr = komutt.ExecuteReader();
            while (dr.Read())
            {
                Txt_Ad.Text = dr[1].ToString();
                Txt_soyad.Text = dr[2].ToString();
                Msk_telefon.Text = dr[4].ToString();
                Txt_sifre.Text = dr[5].ToString();
                Cmb_hayvantur.Text=dr[6].ToString();
                Txt_HayvanYas.Text = dr[7].ToString();
            }
            bgl.Baglanti().Close();
        }

        private void Btn_Güncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update Tbl_HastaSahip set SahipAd=@p1,SahipSoyad=@p2,SahipTelefon=@p3,SahipSifre=@p4,HayvanTur=@p5,HayvanYas=@p6 ",bgl.Baglanti());
            komut2.Parameters.AddWithValue("@p1", Txt_Ad.Text);
            komut2.Parameters.AddWithValue("@p2", Txt_soyad.Text);
            komut2.Parameters.AddWithValue("@p3", Msk_telefon.Text);
            komut2.Parameters.AddWithValue("@p4", Txt_sifre.Text);
            komut2.Parameters.AddWithValue("@p5", Cmb_hayvantur.Text);
            komut2.Parameters.AddWithValue("@p6", Txt_HayvanYas.Text);
            komut2.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }
    }
}
