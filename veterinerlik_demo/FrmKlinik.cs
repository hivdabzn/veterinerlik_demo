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
    public partial class FrmKlinik : Form
    {
        public FrmKlinik()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl = new Sqlbaglantisi();
        private void FrmKlinik_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Klinik  ", bgl.Baglanti());
            da.Fill(dt);

        }

        private void Btn_girisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from Tbl_Klinik Where KlinikSehir=@p1 and KlinikSifre=@p2", bgl.Baglanti());

            komut.Parameters.AddWithValue("@p1", Msk_İD.Text);
            komut.Parameters.AddWithValue("@p2", Txt_sifre.Text);

            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmSahipDetay fr = new FrmSahipDetay();
                fr.tc = Msk_İD.Text;
                fr.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı İD & Şifre");
            }
            bgl.Baglanti().Close();
        }

        private void Lnk_üyeol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
