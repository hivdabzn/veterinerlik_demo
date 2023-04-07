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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }
        public string tc;

        Sqlbaglantisi bgl = new Sqlbaglantisi();
        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            Lbl_Tc.Text = tc;

            SqlCommand komut = new SqlCommand("select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorTc=@p1" +
                "", bgl.Baglanti());
            komut.Parameters.AddWithValue("@p1", Lbl_Tc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Lbl_adSoyad.Text = dr[0] + " " + dr[1];

            }
            bgl.Baglanti().Close();


            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * From Tbl_Randevular where RandevuDoktor='" + Lbl_adSoyad.Text + "'", bgl.Baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Btn_güncelle_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDüzenle fr = new FrmDoktorBilgiDüzenle();
            fr.TCno = Lbl_Tc.Text;
            fr.Show();

        }

        private void Btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            Rch_sikayet.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }
    }
}
