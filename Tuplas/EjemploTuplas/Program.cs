using System;


#region Tupla
Tuple<string, string, int> coche
    = new Tuple<string, string, int>("Audi", "A3", 2008);

var coche2 = Tuple.Create("Opel", "Astra", 2005);

Console.WriteLine($"El primer coche es un {coche.Item1} {coche.Item2} del año {coche.Item3}");
Console.WriteLine($"El segundo coche es un {coche2.Item1} {coche2.Item2} del año {coche2.Item3}");



var coche3 = CalcularCoche3();
Console.WriteLine($"El Tercer coche es un {coche3.Item1} {coche3.Item2} del año {coche3.Item3}");

Tuple<string, string, int> CalcularCoche3()
{
    return Tuple.Create("Ford", "Fiesta", 1995); 
}

void ImprimirMensaje(Tuple<string, string, int> coche){
    Console.WriteLine($"El coche es un {coche.Item1} {coche.Item2} del año {coche.Item3}");
}
#endregion

#region ValueTuple
(string, string, int) moto1 = ("Derbi", "Variant", 1980);
Console.WriteLine($"la moto es una {moto1.Item1} {moto1.Item2} del año {moto1.Item3}");

(string marca, string modelo, int year) moto2 = ("Bultaco", "Lobito", 1998);
Console.WriteLine($"la moto es una {moto2.marca} {moto2.modelo} del año {moto2.year}");


(string marcaMoto3, string modeloMoto3, int yearMoto3) = CalcularMoto3();
Console.WriteLine($"la moto es una {marcaMoto3} {modeloMoto3} del año {yearMoto3}");



(string, string, int) CalcularMoto3(){
    return ("Honda", "CBR", 2005);
}

void ImprimirMensajeMoto((string marca, string modelo, int year) moto)
{
    Console.WriteLine($"la moto es una {moto.marca} {moto.modelo} del año {moto.year}");
}

#endregion