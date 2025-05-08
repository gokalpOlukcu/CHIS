using Microsoft.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;

namespace  CHIS
{
    class sqlConnection
    {
        public SqlConnection baglanti()
        {

            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-GOKALPP;Initial Catalog=chisDATA;Integrated Security=True;TrustServerCertificate=True");
            baglan.Open();
            return baglan;

        }
    }
}
