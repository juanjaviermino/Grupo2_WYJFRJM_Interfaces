namespace MinoArboledaJuanJavier01062023_1
{
    public class Avion : IVehiculo
    {
        private float velocidad;
        private float aceleracion;
        private Persona piloto { get; set; }

        public Avion(float velocidad_, float aceleracion_, Persona piloto_)
        {
            velocidad = velocidad_;
            aceleracion = aceleracion_;
            this.piloto = piloto_;
        }

        public string aumentarVelocidad()
        {
            for(int i =0; i < 4; i++)
            {
                velocidad += aceleracion;
            }

            return velocidad.ToString();
        }

        public string disminuirVelocidad(int desaceleracion)
        {
            for (int i = 0; i < 4; i++)
            {
                velocidad -= desaceleracion;
            }

            return velocidad.ToString();
        }

        public string movilizarse(int direccion)
        {
            switch (direccion)
            {
                case 0:
                    return "arriba";
                case 1:
                    return "derecha";
                case 2:
                    return "abajo";
                case 3:
                    return "izquierda";
                default:
                    return "dirección inválida";
            }
        }

        public string detallesVehiculo()
        {
            string detalles = $"Piloto: {piloto.nombre}, Tipo vehículo: Avión, Velocidad: {velocidad}, Aceleración: {aceleracion}";
            return detalles;
        }
    }
}
