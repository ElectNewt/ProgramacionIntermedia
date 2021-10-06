Queue<string> marcas = new Queue<string>();
marcas.Enqueue("Audi");
marcas.Enqueue("Opel");
marcas.Enqueue("BMW");


foreach(string marca in marcas)
    Console.WriteLine(marca);

Console.WriteLine($"La primera marca es {marcas.Peek()}"); //Audi
Console.WriteLine($"La primera marca (otra vez) es {marcas.Dequeue()}"); //Audi
Console.WriteLine($"La segunda marca es {marcas.Dequeue()}"); //Opel

