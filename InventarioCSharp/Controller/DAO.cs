using InventarioCSharp.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioCSharp.Controller
{
    public class DAO:Conexion
    {
        //Atributo de clase
        private Conexion c;

        //Constructor

        public DAO()
        {
            //obtener la cadena de conexion
            c= new Conexion();
        }

        //Metodo generico
        private void ejecutar(string sql)
        {
            try
            {
                this.c.con.Open(); //obtener la cadena de conexion
                this.c.sen= new SqlCommand(sql,c.con); //traducir la cadena sql a una sentencia sql
                this.c.sen.ExecuteNonQuery();
                MessageBox.Show("La transacción ha sido aplicada en la base de datos");

            }
            catch (Exception ex)
            {               
                MessageBox.Show( ex.Message);
            }
            finally 
            { 
                this.c.con.Close(); //Cierra la cadena de conexion
            }
        }

        //Metodos CRUD

        //Metodos CRUD de Cuentadante
        public void CrearCuentadante(Cuentadante cue)
        {
            string insert = "INSERT into cuentadante(documento,nombres,apellidos,genero,cargo,celular,correo)"
                    + "VALUES('" + cue.Documento + "','" + cue.Nombres + "',"
                    + "'" + cue.Apellidos + "','" + cue.Genero + "','" + cue.Cargo + "',"
                    + "'" + cue.Celular+ "','" + cue.Correo + "')";
            ejecutar(insert);
        }

        public void ModificarCuentadante(Cuentadante cue)
        {
            string update = "UPDATE cuentadante set documento='" + cue.Documento + "', "
                    + "nombres='" + cue.Nombres + "', apellidos='" + cue.Apellidos + "', "
                    + "genero='" + cue.Genero + "', cargo='" + cue.Cargo + "', celular='" + cue.Celular + "',"
                    + " correo='" + cue.Correo + "' where idcuentadante='" + cue.IdCuentadante + "'";
            
            ejecutar(update);
        }
        public void EliminarCuentadante(Cuentadante cue)
        {
            string delete = " delete FROM cuentadante where idcuentadante= '" + cue.IdCuentadante + "' ";
            ejecutar(delete);
        }
        public Cuentadante BuscarCuentadante(string doc)
        {
            Cuentadante cue = null;
            string select = "select * from cuentadante where Documento= '"+doc+"'";
            try
            {
                this.c.con.Open(); //obtener la cadena de conexion
                this.c.sen = new SqlCommand(select, c.con); //traducir la cadena sql a una sentencia sql
                this.rs= this.c.sen.ExecuteReader();
                if (this.rs.Read())
                {
                    cue= new Cuentadante();
                    cue.IdCuentadante = int.Parse(this.rs["IdCuentadante"].ToString());
                    cue.Documento = this.rs["Documento"].ToString();
                    cue.Nombres = this.rs["Nombres"].ToString();
                    cue.Apellidos = this.rs["Apellidos"].ToString();
                    cue.Genero = this.rs["Genero"].ToString();
                    cue.Cargo = this.rs["Cargo"].ToString();
                    cue.Celular = this.rs["Celular"].ToString();
                    cue.Correo = this.rs["Correo"].ToString();
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.c.con.Close(); //Cierra la cadena de conexion
            }
            return cue;
        }

        //Metodos CRUD de proveedor

        public void CrearProveedor(Proveedor pro)
        {
            string insert = "INSERT into proveedor(nit,nombres,telefono,email,website)"
                    + "VALUES('" + pro.Nit + "','" + pro.Nombres + "',"
                    + "'" + pro.Telefono + "','" + pro.Email + "','" + pro.Website + "')";
            
            ejecutar(insert);
        }

        public void ModificarProveedor(Proveedor pro)
        {
            string update = "UPDATE proveedor set nit='" + pro.Nit + "', "
                    + "nombres='" + pro.Nombres + "', telefono='"+pro.Telefono+"', " +
                    "email='"+pro.Email+"', website= '"+pro.Website+"' " +
                    "where idproveedor='" + pro.IdProveedor + "' ";

            ejecutar(update);
        }

        public void EliminarProveedor(Proveedor pro)
        {
            string delete = " delete FROM proveedor where idproveedor= '" + pro.IdProveedor + "' ";
            ejecutar(delete);
        }

        public Proveedor BuscarProveedor(string nit)
        {
            Proveedor pro = null;
            string select = "select * from proveedor where nit= '" + nit + "'";
            try
            {
                this.c.con.Open(); //obtener la cadena de conexion
                this.c.sen = new SqlCommand(select, c.con); //traducir la cadena sql a una sentencia sql
                this.rs = this.c.sen.ExecuteReader();
                if (this.rs.Read())
                {
                    pro = new Proveedor();
                    pro.IdProveedor = int.Parse(this.rs["idproveedor"].ToString());
                    pro.Nit = this.rs["nit"].ToString();
                    pro.Nombres = this.rs["Nombres"].ToString();
                    pro.Telefono = this.rs["Telefono"].ToString();
                    pro.Email = this.rs["Email"].ToString();
                    pro.Website = this.rs["Website"].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.c.con.Close(); //Cierra la cadena de conexion
            }
            return pro;
        }

    }
}
