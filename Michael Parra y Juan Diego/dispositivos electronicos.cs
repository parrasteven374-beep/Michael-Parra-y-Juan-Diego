using System;

public class DispositivoElectronico
{
    public string marca;
    public string modelo;
    public double precio;

    public DispositivoElectronico(string marca, string modelo, double precio)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.precio = precio;
    }

    public void mostrarInfo()
    {
        Console.WriteLine("Marca : " + marca);
        Console.WriteLine("Modelo : " + modelo);
        Console.WriteLine("Precio : " + precio);
    }
}