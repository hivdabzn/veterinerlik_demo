using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace veterinerlik_demo
{
    public partial class FrmGirisler : Form
    {
        public FrmGirisler()
        {
            InitializeComponent();
        }



        private void Btn_SahipGiris_Click(object sender, EventArgs e)
        {
            FrmSahipgiris fr = new FrmSahipgiris();
            fr.Show();
            this.Hide();
        }

        private void Btn_DoktorGiris_Click(object sender, EventArgs e)
        {
            Frmdoktorgiris fr = new Frmdoktorgiris();
            fr.Show();
            this.Hide();
        }

        private void Btn_VetYönetim_Click(object sender, EventArgs e)
        {
            FrmSekreterGiris fr = new FrmSekreterGiris();
            fr.Show();
            this.Hide();
        }

        private void FrmGirisler_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Klinik_Click(object sender, EventArgs e)
        {

            FrmKlinik fr = new FrmKlinik();
            fr.Show();
            this.Hide();
        }
    }
}
