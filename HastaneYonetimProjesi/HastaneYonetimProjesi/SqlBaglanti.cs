using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HastaneYonetimProjesi
{
    public class SqlBaglanti
    {

        public SqlConnection Baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=ARDACIMEN\\SQLEXPRESS;Initial Catalog=HastaneProje;Integrated Security=True;");


            baglan.Open();

            return baglan;




        }


    }
}
