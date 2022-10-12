using System;
using System.Collections.Generic;

namespace Solid_L
{
    class Program
    {
        static void Main(string[] args)
        {
            SaleWithTaxes sale = new LocalSale(100, "Hector", 0.16m);
            sale.CalculateTaxes();
            sale.Generate();

            sale = new SaleInvoice(150, "Hector", 0.16m);
            sale.CalculateTaxes();
            sale.Generate();

            AbstractSale = new ForeignSale(200, "Pepe");
            sale.Generate();
        }
        public abstract class AbstractSale // T1
        {
            protected decimal amount;
            protected string customer;
            public abstract void Generate();
        }

        public abstract class SaleWithTaxes : AbstractSale // T2
        {
            protected string taxes;
            public abstract void CalculateTaxes();
        }

        public abstract class LocalSale : SaleWithTaxes // T2 S1
        {
            public LocalSale(decimal amount, string customer, decimal taxes)
            {
                this.amount = amount;
                this.customer = customer;
                this.taxes = taxes;
            }
            public override void Generate()
            {
                Console.WriteLine("Se genera la venta local");
            }
            public override void CalculateTaxes()
            {
                Console.WriteLine("Se calculan los impuestos");
            }
        }
        public abstract class SaleInvoice : SaleWithTaxes // T2 S2
        {
            public SaleInvoice(decimal amount, string customer, decimal taxes)
            {
                this.amount = amount;
                this.customer = customer;
                this.taxes = taxes;
            }
            public override void Generate()
            {
                Console.WriteLine("Se genera la venta local con factura");
            }
            public override void CalculateTaxes()
            {
                Console.WriteLine("Se calculan los impuestos");
            }
            public void XML()
            {
                Console.WriteLine("Factura");
            }
        }

        public class ForeignSale : AbstractSale // T1 S1
        {
            public ForeignSale(decimal amount, string Customer)
            {
                this.amount = amount;
            }
            public override void Generate()
            {
                Console.WriteLine("Se genera la venta extranjera");
            }
        }
    }
}