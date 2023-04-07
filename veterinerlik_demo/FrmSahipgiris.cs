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
    public partial class FrmSahipgiris : Form
    {
        public FrmSahipgiris()
        {
            InitializeComponent();
        }
        Sqlbaglantisi baglan = new Sqlbaglantisi();
       

        private void Lnk_üyeol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSahipKayıt fr=new FrmSahipKayıt();
            fr.Show();
            

        }

        private void Btn_girisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from Tbl_HastaSahip Where SahipTC=@p1 and SahipSifre=@p2" ,baglan.Baglanti());

            komut.Parameters.AddWithValue("@p1", Msk_TC.Text);
            komut.Parameters.AddWithValue("@p2", Txt_sifre.Text);

            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmSahipDetay fr=new FrmSahipDetay();
                fr.tc = Msk_TC.Text;
                fr.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı TC & Şifre");
            }
            baglan.Baglanti().Close();
        }

        private void FrmSahipgiris_Load(object sender, EventArgs e)
        {

        }
    }
}
