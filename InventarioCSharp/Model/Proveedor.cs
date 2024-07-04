using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace InventarioCSharp.Model
{
    public class Proveedor
    {
        public int IdProveedor { get; set; }
        public string Nit { get; set; }
        public string Nombres { get; set; }    
        public string Telefono { get; set; }
        public string Email { get; set; }
	    public string Website { get; set; }

    }
}
