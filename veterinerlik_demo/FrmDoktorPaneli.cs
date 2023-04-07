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
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl = new Sqlbaglantisi();
        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From Tbl_Doktorlar ", bgl.Baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;


        }

        private void Btn_Ekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Doktorlar (DoktorAd,DoktorSoyad,DoktorTC,DoktorSifre) values (@d1,@d2,@d3,@d4)", bgl.Baglanti());
            komut.Parameters.AddWithValue("@d1", Txt_Ad.Text);
            komut.Parameters.AddWithValue("@d2", Txt_Soyad.Text);
            komut.Parameters.AddWithValue("@d3", Msk_TC.Text);
            komut.Parameters.AddWithValue("@d4", Txt_sifre.Text);
            komut.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Doktor Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Tbl_Doktorlar where DoktorTC=@p1", bgl.Baglanti());
            komut.Parameters.AddWithValue("@p1", Msk_TC.Text);
            komut.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Kayıt Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            Txt_Ad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            Txt_Soyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            Msk_TC.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            Txt_sifre.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }

        private void Btn_Güncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Doktorlar set DoktorAd=@d1,Doktorsoyad=@d2,DoktorSifre=@d3 where DoktorTC=@d4", bgl.Baglanti());
            komut.Parameters.AddWithValue("@d1", Txt_Ad.Text);
            komut.Parameters.AddWithValue("@d2", Txt_Soyad.Text);
            komut.Parameters.AddWithValue("@d4", Msk_TC.Text);
            komut.Parameters.AddWithValue("@d3", Txt_sifre.Text);
            komut.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Doktor Bilgileri Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}
