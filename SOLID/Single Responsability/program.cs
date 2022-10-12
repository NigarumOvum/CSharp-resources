using System;

namespace Solid_S
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

public class Beer
{
    public String Name { get; set; }
    public String Brand { get; set; }
        public String Alcohol { get; set; }


    public Beer(string Name, String Brand)
    {
        this.Name = Name;
        this.bran = Brand;
    }
}

public class BeerDB
{
    private Beer _beer;
    public BeerDB(Beer beer)
    {
        _beer = beer;
    }
    public void Save()
    {
        Console.WriteLine($"Guardamos {_beer.Name} y {_beer.Brand}");
    }
}

public class BeerRequest
{
    public void Send()  
    {
        Console.WriteLine($"Enviamos al otro {Name} y {Brand}");
    }
}
