using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Agenda
{
    public class DBConexion
    {
        public static SqlConnection getConexion()
        {
            SqlConnection con = new SqlConnection("Data source=ROOT-PC\\SURPUSER; Initial Catalog=agenda; Integrated Security=true; User Id=ROOT-PC\\Root");
            con.Open();
             
            return con; 
        }
    }
}
