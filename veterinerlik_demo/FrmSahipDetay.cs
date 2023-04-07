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
    public partial class FrmSahipDetay : Form
    {
        public FrmSahipDetay()
        {
            InitializeComponent();
        }
        public string tc;
        Sqlbaglantisi bgl = new Sqlbaglantisi();
        private void FrmSahipDetay_Load(object sender, EventArgs e)
        {
            Lbl_TC.Text = tc;

            //Ad-Soyad , Hayvantürü , HayvanYaş ÇEKME...  


            SqlCommand komut = new SqlCommand("select SahipAd,SahipSoyad,HayvanTur,HayvanYas from Tbl_HastaSahip where SahipTC=@p1", bgl.Baglanti());
            komut.Parameters.AddWithValue("@p1", Lbl_TC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Lbl_adsoyad.Text = dr[0] + " " + dr[1];
                Lbl_Hayvanturu.Text = dr[2].ToString();
                Lbl_HayvanYas.Text = dr[3].ToString();

            }
            bgl.Baglanti().Close();

            //Randevu Geçmişi ÇEKME...
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where SahipTC=" + tc, bgl.Baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Klinikleri ÇEKME.....

            SqlCommand komut2 = new SqlCommand("select KlinikSehir  from Tbl_Klinik ", bgl.Baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                Cmb_sehir.Items.Add(dr2[0]);
            }
            bgl.Baglanti().Close();

        }

        private void Cmb_sehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cmb_klinik.Items.Clear();
            SqlCommand komut3 = new SqlCommand("select klinikAd from Tbl_klinik where KlinikSehir=@p1", bgl.Baglanti());
            komut3.Parameters.AddWithValue("@p1", Cmb_sehir.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                Cmb_klinik.Items.Add(dr3[0]);
            }
            bgl.Baglanti().Close();
        }

        private void Cmb_klinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string sql = "Select * From Tbl_Klinik  where KlinikSehir='" + Cmb_sehir.Text + "'";
            sql += " and klinikid=11 ";
            SqlDataAdapter da = new SqlDataAdapter(sql, bgl.Baglanti());
            new SqlDataAdapter();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void Lnk_BilgiDüzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgiDüzenle fr = new FrmBilgiDüzenle();
            fr.TCno = Lbl_TC.Text;
            fr.Show();

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            Txt_İd.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();

        }

        private void Btn_RandevuAl_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Randevular set RandevuDurum=1,SahipTC=@p1,Sahipİslem=@p2 where Randevuid=@p3", bgl.Baglanti());
            komut.Parameters.AddWithValue("@p1", Lbl_TC.Text);
            komut.Parameters.AddWithValue("@p2", Rch_islem.Text);
            komut.Parameters.AddWithValue("@p3", Txt_İd.Text);
            komut.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Randevu Alındı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
