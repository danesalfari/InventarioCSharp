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
    public partial class frmCuentadante : Form
    {
        DAO objDAO = new DAO();
        public frmCuentadante()
        {
            InitializeComponent();
        }

        private void frmCuentadante_Load(object sender, EventArgs e)
        {
            cbxGenero.SelectedIndex= 0;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            crearCuentadante();

        }
        private void crearCuentadante()
        { 
            Cuentadante cue= new Cuentadante();
            cue.Documento= txtDocumento.Text;
            cue.Nombres= txtNombres.Text;
            cue.Apellidos= txtApellidos.Text;
            cue.Cargo= txtCargo.Text;
            cue.Celular= txtCelular.Text;
            cue.Correo= txtCorreo.Text;
            cue.Genero = cbxGenero.Text;
            objDAO.CrearCuentadante(cue);
            limpiar();
        }
        private void limpiar()
        {
            txtApellidos.Clear();
            txtCargo.Clear();
            txtCelular.Clear();
            txtCorreo.Clear();
            txtDocumento.Clear();
            txtNombres.Clear();
            txtId.Clear();
            cbxGenero.SelectedIndex = 0;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarCuentadante();
        }
        private void buscarCuentadante()
        {
            Cuentadante obj = objDAO.BuscarCuentadante(txtDocumento.Text);
            if (obj != null)
            {
                txtApellidos.Text = obj.Apellidos;
                txtCargo.Text = obj.Cargo;
                txtCelular.Text = obj.Celular;
                txtCorreo.Text = obj.Correo;
                txtDocumento.Text = obj.Documento;
                txtId.Text = obj.IdCuentadante.ToString();
                txtNombres.Text = obj.Nombres;
                cbxGenero.Text = obj.Genero;
                
            }
            else 
            {
                MessageBox.Show(("El cuentadante con cedula ," 
                    + txtDocumento.Text +  " no se encuentra registrado"));
            }            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modificarCuentadante();
        }
        private void modificarCuentadante()
        {
            Cuentadante cue = new Cuentadante();
            cue.IdCuentadante= int.Parse(txtId.Text);
            cue.Documento = txtDocumento.Text;
            cue.Nombres = txtNombres.Text;
            cue.Apellidos = txtApellidos.Text;
            cue.Cargo = txtCargo.Text;
            cue.Celular = txtCelular.Text;
            cue.Correo = txtCorreo.Text;
            cue.Genero = cbxGenero.Text;
            objDAO.ModificarCuentadante(cue);
            limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }
        private void eliminar()
        {
            Cuentadante cue = new Cuentadante();
            cue.IdCuentadante = int.Parse(txtId.Text);
            cue.Documento = txtDocumento.Text;
            cue.Nombres = txtNombres.Text;
            cue.Apellidos = txtApellidos.Text;
            cue.Cargo = txtCargo.Text;
            cue.Celular = txtCelular.Text;
            cue.Correo = txtCorreo.Text;
            cue.Genero = cbxGenero.Text;
            var x = MessageBox.Show("Esta seguro de eliminar este registro?",
                "Eliminar!", MessageBoxButtons.YesNoCancel);
            
            if (x.ToString().Equals("Yes"))
            {
                objDAO.EliminarCuentadante(cue);
                limpiar();
                
            }           
        }
    }
}
