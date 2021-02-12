using System;
using System.Data;
using CapaEntidad;
using System.Data.SqlClient;
namespace CapaDatos
{
   public class VehiculoDatos
    {
        SqlConnection cnx;
        VehiculosEntidad mcEntidad = new VehiculosEntidad();
        Conexion MiConexi = new Conexion();
        SqlCommand cmd = new SqlCommand();
        bool vexito;
        public VehiculoDatos()
        {
            cnx = new SqlConnection(MiConexi.GetConex());
        }
        public bool InsertarCliente(VehiculosEntidad mcEntidad)
        {
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc_insertarTBVL";
            try
            {
                cmd.Parameters.Add(new SqlParameter("@NumeroSerie", SqlDbType.VarChar, 50));
                cmd.Parameters["@NumeroSerie"].Value = mcEntidad.numeroSerieVehiculo;
                cmd.Parameters.Add(new SqlParameter("@Cilindros", SqlDbType.VarChar, 10));
                cmd.Parameters["@Cilindros"].Value = mcEntidad.CilindrosVehiculos;
                cmd.Parameters.Add(new SqlParameter("@Color", SqlDbType.VarChar, 50));
                cmd.Parameters["@Color"].Value = mcEntidad.colorVehiculo;
                cmd.Parameters.Add(new SqlParameter("@NumeroEjes", SqlDbType.VarChar, 20));
                cmd.Parameters["@NumeroEjes"].Value = mcEntidad.numeroEjesVehiculo;    
                cmd.Parameters.Add(new SqlParameter("@Estatus", SqlDbType.VarChar,10));
                cmd.Parameters["@Estatus"].Value = mcEntidad.estatusVehiculo;                
                cnx.Open();
                cmd.ExecuteNonQuery();
                vexito = true;
            }
            catch (SqlException)
            {
                vexito = false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
                cmd.Parameters.Clear();
            }
            return vexito;
        }
        public bool ActualizarCliente(VehiculosEntidad mcEntidad)
        {
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc_actualizarTBVL";
            try
            {
                cmd.Parameters.Add(new SqlParameter("@NumeroSerie", SqlDbType.VarChar, 50));
                cmd.Parameters["@NumeroSerie"].Value = mcEntidad.numeroSerieVehiculo;
                cmd.Parameters.Add(new SqlParameter("@Cilindros", SqlDbType.VarChar, 10));
                cmd.Parameters["@Cilindros"].Value = mcEntidad.CilindrosVehiculos;
                cmd.Parameters.Add(new SqlParameter("@Color", SqlDbType.VarChar, 50));
                cmd.Parameters["@Color"].Value = mcEntidad.colorVehiculo;
                cmd.Parameters.Add(new SqlParameter("@NumeroEjes", SqlDbType.VarChar, 20));
                cmd.Parameters["@NumeroEjes"].Value = mcEntidad.numeroEjesVehiculo;
                cmd.Parameters.Add(new SqlParameter("@Estatus", SqlDbType.VarChar, 10));
                cmd.Parameters["@Estatus"].Value = mcEntidad.estatusVehiculo;
                cnx.Open();
                cmd.ExecuteNonQuery();
                vexito = true;
            }
            catch (SqlException)
            {
                vexito = false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
                cmd.Parameters.Clear();
            }
            return vexito;
        }
        public bool EliminarCliente(VehiculosEntidad mcEntidad)
        {
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc_eliminar";
            try
            {
                cmd.Parameters.Add(new SqlParameter("@NumeroSerie", SqlDbType.VarChar, 50));
                cmd.Parameters["@NumeroSerie"].Value = mcEntidad.numeroSerieVehiculo;
               // cmd.Parameters.Add(new SqlParameter("@Estatus", SqlDbType.VarChar,10));
               // cmd.Parameters["@Estatus"].Value = mcEntidad.estatusVehiculo;
                cnx.Open();
                cmd.ExecuteNonQuery();
                vexito = true;
            }
            catch (SqlException)
            {
                vexito = false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
                cmd.Parameters.Clear();
            }
            return vexito;
        }
        public DataTable ListarClientes(string parametro)
        {
            DataSet dts = new DataSet();
            try
            { 
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "proc_listar";
                //cmd.Parameters.Add(new SqlParameter("@Estatus", parametro));
                SqlDataAdapter mda;
                mda = new SqlDataAdapter(cmd);
                mda.Fill(dts, "TBL_vehiculos");
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cmd.Parameters.Clear();
            }
            return (dts.Tables["TBL_vehiculos"]);
        }
        public VehiculosEntidad ConsultarCliente(string codigo)
        {
            try
            {
                SqlDataReader dtr;
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "proc_consultar";
                cmd.Parameters.Add(new SqlParameter("@NumeroSerie", SqlDbType.VarChar, 50));
                cmd.Parameters["@NumeroSerie"].Value = codigo;
                if (cnx.State == ConnectionState.Closed)
                {
                    cnx.Open();
                }
                dtr = cmd.ExecuteReader();
                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    mcEntidad.numeroSerieVehiculo = Convert.ToString(dtr[0]);
                    mcEntidad.CilindrosVehiculos = Convert.ToString(dtr[1]);
                    mcEntidad.colorVehiculo = Convert.ToString(dtr[2]);
                    mcEntidad.numeroEjesVehiculo = Convert.ToString(dtr[3]);
                    mcEntidad.estatusVehiculo = Convert.ToString(dtr[4]);
                }
                cnx.Close();
                cmd.Parameters.Clear();
                return mcEntidad;
            }
            catch (SqlException)
            {
                throw new Exception();
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
                cmd.Parameters.Clear();
            }
        }
    }
}