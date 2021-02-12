using System.Data;
using CapaEntidad;
using CapaDatos;
namespace CapaNegocio
{
    public class VehiculoNegocio
    {
        VehiculoDatos _ClienteDatos = new VehiculoDatos();

        public bool InsertarCliente(VehiculosEntidad CliNegocio)
        {
            return _ClienteDatos.InsertarCliente(CliNegocio);
        }

        public bool ActualizarCliente(VehiculosEntidad CliNegocio)
        {
            return _ClienteDatos.ActualizarCliente(CliNegocio);
        }

        public bool EliminarCliente(VehiculosEntidad CliNegocio)
        {
            return _ClienteDatos.EliminarCliente(CliNegocio);
        }

        public DataTable ListarClientes(string parametro)
        {
            return _ClienteDatos.ListarClientes(parametro);
        }
        public VehiculosEntidad ConsultarCliente(string codigo)
        {
            return _ClienteDatos.ConsultarCliente(codigo);
        }
    }
}
