using System.Configuration;
namespace CapaDatos
{
    public class Conexion
    {
        public Conexion()
        {
        }
        public string GetConex()
        {
            string strConex = ConfigurationManager.ConnectionStrings["DBVehiculos"].ConnectionString;
            if (object.ReferenceEquals(strConex, string.Empty))
            {
                return string.Empty;
            }
            else
            {
                return strConex;
            }
        }
    }
}

