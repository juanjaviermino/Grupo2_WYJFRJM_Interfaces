namespace MinoArboledaJuanJavier01062023_1
{
    public interface IVehiculo
    {
        public string movilizarse(int direccion);
        public string aumentarVelocidad();
        public string disminuirVelocidad(int desaceleracion);
        public string detallesVehiculo();
    }
}
