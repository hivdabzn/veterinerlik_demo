using System.Data.SqlClient;


namespace veterinerlik_demo
{
    internal class Sqlbaglantisi
    {
        public SqlConnection Baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-8E0ATBG9;Initial Catalog=VeterinerlikProje;Integrated Security=True");
            baglan.Open();
            return baglan;

        }
    }
}
