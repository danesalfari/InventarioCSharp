using InventarioCSharp.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gestionarCuentadanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCuentadante cuentadante= new frmCuentadante();
            cuentadante.MdiParent= this;
            cuentadante.Show();
        }

        private void gestionarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProveedor proveedor = new frmProveedor();
            proveedor.MdiParent = this;
            proveedor .Show();
        }
    }
}
