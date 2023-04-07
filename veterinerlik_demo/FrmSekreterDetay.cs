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
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }
        public string TCNumara;


        Sqlbaglantisi bgl = new Sqlbaglantisi();
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            Lbl_TC.Text = TCNumara;



            //AD-SOYAD
            SqlCommand komut1 = new SqlCommand("Select SekreterAdSoyad from Tbl_Sekreter where SekreterTC=@p1", bgl.Baglanti());
            komut1.Parameters.AddWithValue("@p1", Lbl_TC.Text);
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                Lbl_AdSoyad.Text = dr[0].ToString();
            }
            bgl.Baglanti().Close();

            //Doktorları Listeye Aktarma
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DoktorAD +' '+DoktorSoyad) as 'Doktorlar' From Tbl_Doktorlar ", bgl.Baglanti());
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;

            /*//Branşı combobax'a aktarma
            SqlCommand komut2 = new SqlCommand("Select DoktorAd From Tbl_Doktorlar",bgl.Baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                Cmb_doktor.Items.Add(dr2[0]);
            }
            bgl.Baglanti().Close();
            */

            //Doktorları Combobox'a Aktarma

            SqlCommand komut2 = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar ", bgl.Baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                Cmb_doktor.Items.Add(dr2[0] + " " + dr2[1]);

            }
            bgl.Baglanti().Close();
        }

        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutKaydet = new SqlCommand("insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuDoktor) values (@r1,@r2,@r3) ", bgl.Baglanti());
            komutKaydet.Parameters.AddWithValue("@r1", Msk_Tarih.Text);
            komutKaydet.Parameters.AddWithValue("@r2", Msk_Saat.Text);
            komutKaydet.Parameters.AddWithValue("@r3", Cmb_doktor.Text);
            komutKaydet.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu");
        }

        private void Btn_DuyuruOluştur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Duyurular (Duyuru) values (@d1)", bgl.Baglanti());
            komut.Parameters.AddWithValue("@d1", Rch_Duyuru.Text);
            komut.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Duyurunuz Oluşturuldu.");

        }

        private void Btn_DoktorPaneli_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli drp = new FrmDoktorPaneli();
            drp.Show();
        }

        private void Btn_RandevuListe_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi rl = new FrmRandevuListesi();
            rl.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FrmDuyurular dy = new FrmDuyurular();
            dy.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
