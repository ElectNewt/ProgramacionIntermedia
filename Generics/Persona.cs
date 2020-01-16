namespace Generics
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Persona()
        {

        }
        public Persona(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }

    }
}
