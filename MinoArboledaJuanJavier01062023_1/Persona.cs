using System.Security.Cryptography.X509Certificates;

public class Persona
{
    public string nombre { get; set; }
    public int edad { get; set; }
    public string nacionalidad { get; set; }

    public Persona(string nombre_, int edad_, string nacionalidad_)
    {
        nombre = nombre_;
        edad = edad_;   
        nacionalidad = nacionalidad_;
    }

    public string imprimirDatos()
    {
        string datosPersona = "Nombre de la persona: " + this.nombre + ", de edad: " + this.edad.ToString() +" y nacionalidad: "+ this.nacionalidad;
        return datosPersona;
    }
}

    


