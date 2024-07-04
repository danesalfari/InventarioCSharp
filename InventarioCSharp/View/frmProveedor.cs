using InventarioCSharp.Controller;
using InventarioCSharp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioCSharp.View
{
    public partial class frmProveedor : Form
    {
        DAO objDAO= new DAO();
        public frmProveedor()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            crear();
        }
        private void crear()
        { 
            Proveedor pro= new Proveedor();
            pro.Nit= txtNit.Text;
            pro.Nombres= txtNombres.Text;
            pro.Telefono= txtTelefono.Text;
            pro.Email= txtEmail.Text;
            pro.Website= txtWebsite.Text;
            objDAO.CrearProveedor(pro);
            limpiar();
        }
        private void limpiar()
        {
            txtEmail.Clear();
            txtId.Clear();
            txtNit.Clear();
            txtNombres.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtWebsite.Clear();

        }
    }
}
