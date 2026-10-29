
using System;

class Celular
{
    public string Marca { get; set; }
    public string Modelo { get; set; }

    public Celular(string marca, string modelo)
    {
        Marca = marca;
        Modelo = modelo;
    }

    public virtual void Ligar()
    {
        Console.WriteLine($"{Marca} {Modelo} está realizando uma ligação.");
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Modelo: {Modelo}");
    }
}

class Iphone : Celular
{
    public Iphone(string modelo) : base("Apple", modelo)
    {
    }

    public override void Ligar()
    {
        Console.WriteLine($"O {Modelo} está ligando usando o sistema iOS.");
    }
}

class Samsung : Celular
{
    public Samsung(string modelo) : base("Samsung", modelo)
    {
    }

    public override void Ligar()
    {
        Console.WriteLine($"O {Modelo} está ligando usando o sistema Android.");
    }
}

class Program
{
    static void Main()
    {
        Celular celular1 = new Iphone("iPhone 17");
        Celular celular2 = new Samsung("Galaxy S25");

        celular1.ExibirInformacoes();
        celular1.Ligar();

        Console.WriteLine();

        celular2.ExibirInformacoes();
        celular2.Ligar();
    }
}
