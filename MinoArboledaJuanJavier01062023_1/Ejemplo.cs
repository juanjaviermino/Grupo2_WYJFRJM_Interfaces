namespace MinoArboledaJuanJavier01062023_1
{
    internal class Ejemplo
    {
        static void Main(string[] args)
        {
            Persona juanito = new Persona("Juan Javier", 22, "Ecuatoriana");
            Persona mateito = new Persona("Mateito", 21, "Ecuatoriana");
            Persona felipito = new Persona("Felipito", 21, "Ecuatoriana");

            Carro calvoMovil = new Carro(120, felipito);
            Carro mateoMovil = new Carro(140, mateito);
            Avion aeroCalvo = new Avion(300, 80, felipito);
            Avion jhayPlane = new Avion(350, 80, juanito);

            Console.WriteLine(calvoMovil.detallesVehiculo());
            Console.WriteLine(mateoMovil.detallesVehiculo());
            Console.WriteLine(aeroCalvo.detallesVehiculo());
            Console.WriteLine(jhayPlane.detallesVehiculo());
        }
    }
}
