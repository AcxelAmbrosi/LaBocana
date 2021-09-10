using Logica.inventario;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Datos.inventario
{
    public class CajaD
    {
        public bool InsertarCaja(Caja parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("InsertarCaja",CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SaldoApertura", parametros.SaldoApertura1);
                cmd.Parameters.AddWithValue("@SaldoCierre", parametros.SaldoCierre1);
                cmd.Parameters.AddWithValue("@SaldoActual", parametros.SaldoActual1);
                cmd.Parameters.AddWithValue("@Observacion", parametros.Observacion1);
                cmd.Parameters.AddWithValue("@Fecha", parametros.Fecha1);
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
        public bool CerrarCaja(Caja parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("CerrarCaja", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Caja", parametros.IdCaja1);
                
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
        public bool AnularCaja(Caja parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("AnularCaja", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Caja", parametros.IdCaja1);

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
        public void MostrarCaja(ref DataTable dataTable)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("MostrarCaja", CONEXIONMAESTRA.conectar);
                da.Fill(dataTable);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
        }
        public bool MovimientoCaja(Caja parametros, decimal subtotal)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("MovimientoCaja", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Caja", parametros.IdCaja1);
                cmd.Parameters.AddWithValue("@Subtotal", subtotal);

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
        public void CajaActual(ref DataTable dataTable)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("CajaActual", CONEXIONMAESTRA.conectar);
                da.Fill(dataTable);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
        }
    }
}
