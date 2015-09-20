using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Agenda
{
    public class PersonaDAL
    {
        public static int Agregar(Persona pPersona)
        {
            int retorno = 0;
            using (SqlConnection con = DBConexion.getConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("insert into persona(nombre) VALUES('{0}')",pPersona.Nombre),con);
                retorno = comando.ExecuteNonQuery();  
            }
            return retorno;
        }
    }
}
