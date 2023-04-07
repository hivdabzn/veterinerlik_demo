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
    public partial class FrmSahipKayıt : Form
    {
        public FrmSahipKayıt()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgln=new Sqlbaglantisi();
       

        private void Btn_KayıtYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut=new SqlCommand("insert into Tbl_HastaSahip (SahipAd,SahipSoyad,SahipTC,SahipTelefon,SahipSifre,HayvanTur,HayvanYas) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)",bgln.Baglanti());

            komut.Parameters.AddWithValue("@p1", Txt_Ad.Text);
            komut.Parameters.AddWithValue("@p2", Txt_soyad.Text);
            komut.Parameters.AddWithValue("@p3", Msk_TC.Text);
            komut.Parameters.AddWithValue("@p4", Msk_telefon.Text);
            komut.Parameters.AddWithValue("@p5", Txt_sifre.Text);
            komut.Parameters.AddWithValue("@p6", Cmb_hayvantur.Text);
            komut.Parameters.AddWithValue("@p7", Txt_HayvanYas.Text);

            komut.ExecuteNonQuery();

            bgln.Baglanti().Close();
            MessageBox.Show("Kayıt Başarılı");
           

        }
    }
}
