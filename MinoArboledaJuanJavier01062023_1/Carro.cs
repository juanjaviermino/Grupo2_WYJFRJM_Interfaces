namespace MinoArboledaJuanJavier01062023_1
{
    public class Carro : IVehiculo
    {
        private float velocidad;
        private Persona piloto { get; set; }

        public Carro(float velocidad_, Persona piloto_)
        {
            this.velocidad = velocidad_;
            this.piloto = piloto_;
        }

        public string aumentarVelocidad()
        {
            velocidad += 5;
            return velocidad.ToString();
        }

        public string disminuirVelocidad(int desaceleracion)
        {
            velocidad -= 0.5f*desaceleracion;
            return velocidad.ToString();
        }

        public string movilizarse(int direccion)
        {
            switch (direccion)
            {
                case 0:
                    return "derecha";
                case 1:
                    return "izquierda";
                case 2:
                    return "atras";
                case 3:
                    return "adelante";
                default:
                    return "dirección inválida";
            }
        }

        public string detallesVehiculo()
        {
            string detalles = $"Conductor: {piloto.nombre}, Tipo vehículo: Carro, Velocidad: {velocidad}";
            return detalles;
        }
    }
}
