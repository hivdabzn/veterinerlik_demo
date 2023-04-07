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
    public partial class FrmDoktorBilgiDüzenle : Form
    {
        public FrmDoktorBilgiDüzenle()
        {
            InitializeComponent();
        }
        public string TCno;
        Sqlbaglantisi bgl = new Sqlbaglantisi();
        private void FrmDoktorBilgiDüzenle_Load(object sender, EventArgs e)
        {
            Msk_TC.Text = TCno;
            SqlCommand komut = new SqlCommand("Select * From Tbl_Doktorlar where DoktorTC=@p1", bgl.Baglanti());
            komut.Parameters.AddWithValue("@p1", Msk_TC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Txt_Ad.Text = dr[1].ToString();
                Txt_soyad.Text = dr[2].ToString();
                Txt_sifre.Text = dr[4].ToString();
            }
            bgl.Baglanti().Close();

        }

        private void Btn_Güncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update  Tbl_doktorlar set DoktorAd=@d1,DoktorSoyad=@d2,DoktorSifre=@d3 where DoktorTC=@d4", bgl.Baglanti());
            komut2.Parameters.AddWithValue("@d1", Txt_Ad.Text);
            komut2.Parameters.AddWithValue("@d2", Txt_soyad.Text);
            komut2.Parameters.AddWithValue("@d3", Txt_sifre.Text);
            komut2.Parameters.AddWithValue("@d4", Msk_TC.Text);
            komut2.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi.", "Bilgi", MessageBoxButtons.OK);

        }
    }
}
