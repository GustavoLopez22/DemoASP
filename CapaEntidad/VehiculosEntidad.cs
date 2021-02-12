namespace CapaEntidad
{
    public class VehiculosEntidad
    {
        private string numeroSerie, cilindros, color, numeroEjes;
        private string Estaus;

        public string numeroSerieVehiculo
        {
            get { return numeroSerie; }
            set { numeroSerie = value; }
        }
        public string CilindrosVehiculos
        {
            get { return cilindros; }
            set { cilindros = value; }
        }
        public string colorVehiculo
        {
            get { return color; }
            set { color = value; }
        }
        public string numeroEjesVehiculo
        {
            get { return numeroEjes; }
            set { numeroEjes = value; }
        }
        public string estatusVehiculo
        {    
            get { return Estaus; }
            set { Estaus = value; }
        }
    }
}
