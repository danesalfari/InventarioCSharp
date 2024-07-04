using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace InventarioCSharp.Controller
{
    public class Conexion
    {
        //Atributos
        public SqlConnection con; //atributo para la cadena de conexion
        public SqlCommand sen; //almacena las setencias sql
        public SqlDataReader rs; // recibe informacion de la base de datos

        //Metodos

        public Conexion()
        {
            //Data Source= nombre del servidor
            //Initial Catalog= nombre de la base de datos
            //Integrated Security=True

            this.con = new SqlConnection(@"Data Source=DESKTOP-O7NPTHS ;Initial Catalog=pcs ;" +
                "Integrated Security=True");
        }
    }
}
