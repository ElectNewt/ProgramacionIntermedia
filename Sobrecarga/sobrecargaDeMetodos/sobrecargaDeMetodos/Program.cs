using System;

namespace sobrecargaDeMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Sobrecarga sobrecarga = new Sobrecarga();
            sobrecarga.Suma(10, "10");
           
            Console.WriteLine(sobrecarga.Suma(10, 15,20));
        }
    }
}
