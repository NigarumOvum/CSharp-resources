using System;

namespace Solid_O
{
    class Program
    {
        static void Main(string[] args)
        {
            // Abierto para extension pero cerrado para su modificacion.
        }
        public interface IDrink
        {
            public string Name { get; set; }
            public string Price { get; set; }
            public string Invoice { get; set; }

            public decimal GetPrice();
            // {
            //     return Price * Invoice;
            // }

        }
        public class WaterDrink : IDrink
        {

            public string Name { get; set; }
            public string Price { get; set; }
            public string Invoice { get; set; }
            public decimal GetPrice()
            {
                return Price * Invoice;
            }
        }
        public class Alcohol : IDrink
        {
            public string Name { get; set; }
            public string Price { get; set; }
            public string Invoice { get; set; }
            public string Promo { get; set; }
            public decimal GetPrice()
            {
                return (Price * Invoice) - Promo;
            }
        }
        public class Sugary : IDrink
        {
            public string Name { get; set; }
            public string Price { get; set; }
            public string Invoice { get; set; }
            public string Expiration { get; set; }
            public decimal GetPrice()
            {
                return (Price * Invoice) - Expiration;
            }
        }
        public class Energyze : IDrink
        {
            public string Name { get; set; }
            public string Price { get; set; }
            public string Invoice { get; set; }
            public decimal GetPrice()
            {
                return Price * Invoice;
            }
        }
        public class Invoice
        {
            public decimal GetTotal(IEnumerable<IDrink> 1stDrink)
            {
                decimal total = 0;
                foreach (var drink in 1stDrink)
                {
                    total += drink.GetPrice();
                    //     if (drink.Type == "Agua")
                    //         total += drink.Price;
                    //     else if (drink.Type == "Azucar")
                    //         total += drink.Price * 0.333m;
                    //     else if (drink.Type == "Alcohol")
                    //         total += drink.Price * 0.16m;
                }
                return total;
            }
        }
    }
}
