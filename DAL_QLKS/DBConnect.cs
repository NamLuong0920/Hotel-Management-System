using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLKS
{
    public class DBConnect
    {
        protected SqlConnection _conn = new SqlConnection("server=.; database=QUANLIKHACHSAN;integrated security=true");
    }
}
