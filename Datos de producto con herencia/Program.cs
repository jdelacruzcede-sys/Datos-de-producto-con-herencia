
using System;

class Producto
{
    public string Nombre;
    public double Precio;

    public virtual void Mostrar()
    {
        Console.WriteLine("Producto: " + Nombre);
        Console.WriteLine("Precio: " + Precio);
    }
}

class Papel : Producto
{
    public int Hojas;

    public override void Mostrar()
    {
        base.Mostrar();
        Console.WriteLine("Hojas: " + Hojas);
    }
}

class Utensilio : Producto
{
    public string Material;

    public override void Mostrar()
    {
        base.Mostrar();
        Console.WriteLine("Material: " + Material);
    }
}

class Program
{
    static void Main()
    {
        Papel p = new Papel();
        Console.Write("Nombre del cuaderno: ");
        p.Nombre = Console.ReadLine()!;
        Console.Write("Precio: ");
        p.Precio = double.Parse(Console.ReadLine()!);
        Console.Write("Hojas: ");
        p.Hojas = int.Parse(Console.ReadLine()!);

        Utensilio u = new Utensilio();
        Console.Write("Nombre del lapiz: ");
        u.Nombre = Console.ReadLine()!;
        Console.Write("Precio: ");
        u.Precio = double.Parse(Console.ReadLine()!);
        Console.Write("Material: ");
        u.Material = Console.ReadLine()!;

        Console.WriteLine("\n--- RESULTADOS ---");
        p.Mostrar();
        u.Mostrar();
    }
}
