using System;

public class ConsolaVideojuegos : DispositivoElectronico
{
    public string tipo;

    public ConsolaVideojuegos(string marca, string modelo, double precio, string tipo)
        : base(marca, modelo, precio)
    {
        this.tipo = tipo;
    }

    public void jugar()
    {
        Console.WriteLine("La consola está jugando videojuegos...");
    }
}