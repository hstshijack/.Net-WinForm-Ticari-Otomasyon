using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ticariotomasyon
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-10S04G1;Initial Catalog=ticariotomasyon;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
