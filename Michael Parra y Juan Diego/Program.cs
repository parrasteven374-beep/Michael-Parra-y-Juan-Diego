using System;

class Program
{
    static void Main(string[] args)
    {
        ConsolaVideojuegos consola = new ConsolaVideojuegos("Sony", "PS5", 2500, "Sobremesa");

        consola.mostrarInfo();
        consola.jugar();

        Console.WriteLine("----------------");

        Smartwatch reloj = new Smartwatch("Apple", "Watch 9", 1800, true);

        reloj.mostrarInfo();
        reloj.medirPulso();
    }
}