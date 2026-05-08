using System;

public class Smartwatch : DispositivoElectronico
{
    public bool tieneGPS;

    public Smartwatch(string marca, string modelo, double precio, bool tieneGPS)
        : base(marca, modelo, precio)
    {
        this.tieneGPS = tieneGPS;
    }

    public void medirPulso()
    {
        Console.WriteLine("Midiendo pulso...");
    }
}