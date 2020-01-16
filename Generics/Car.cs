namespace Generics
{

    public interface IVehiculo
    {
        string Marca { get; set; }
        string Modelo { get; set; }
    }

    public class Car : IVehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public Car()
        {

        }
        public Car(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }
    }
}
