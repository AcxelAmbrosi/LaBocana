using Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datos.inventario
{
    public class ClienteD
    {
        public bool InsertarCliente(Cliente parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("InsertarCliente", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Cedula", parametros.Cedula1);
                cmd.Parameters.AddWithValue("@Nombres", parametros.Nombres1);
                cmd.Parameters.AddWithValue("@Apellidos", parametros.Apellidos1);
                cmd.Parameters.AddWithValue("@Direccion", parametros.Direccion1);
                cmd.Parameters.AddWithValue("@Telefono", parametros.Telefono1);
                cmd.Parameters.AddWithValue("@Id_Mesa", parametros.IdMesa1);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }
        }

        public bool EditarCliente(Cliente parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("EditarCliente", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Cliente", parametros.IdCliente1);
                cmd.Parameters.AddWithValue("@Cedula", parametros.Cedula1);
                cmd.Parameters.AddWithValue("@Nombres", parametros.Nombres1);
                cmd.Parameters.AddWithValue("@Apellidos", parametros.Apellidos1);
                cmd.Parameters.AddWithValue("@Direccion", parametros.Direccion1);
                cmd.Parameters.AddWithValue("@Telefono", parametros.Telefono1);
                cmd.Parameters.AddWithValue("@Id_Mesa", parametros.IdMesa1);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }
        }

        public void MostrarCliente(ref DataTable dataTable)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("MostrarCliente", CONEXIONMAESTRA.conectar);
                da.Fill(dataTable);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }
        }

        public void BuscarCliente( DataTable dataTable, string buscador)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("BuscarCliente", CONEXIONMAESTRA.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Buscar", buscador);
                da.Fill(dataTable);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }
        }

        public bool EliminarCliente(Cliente parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("EliminarCliente", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Cliente", parametros.IdCliente1);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }
        }
    }
}
