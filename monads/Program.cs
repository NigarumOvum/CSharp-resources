Func<decimal, decimal> iva = (decimal amount) => amount + (amount * 0.16m);
var discount = (decimal amount) => amount - (amount * 0.1m);
var surcharge = (decimal amount) => amount + (amount * 0.2m);
var annualPartialities = (decimal amount) => amount / 12;

Console.WriteLine(annualPartialities(discount(iva(surcharge(100)))));

// Or 

decimal amount = 100;
decimal total = amount
    .Pipe(surcharge)
    .Pipe(iva)
    .Pipe(discount)
    .Pipe(annualPartialities);
Console.WriteLine(total);

var reverse = (string s) =>
{
    var charArray = s.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
};
Func<string, string> upper = (string s) => s.ToUpper();

string name = "brealy";
string nameResult = name.P(reverse).P(upper);
console.Writeline(nameResult);

var upperList = (List<string> l) => l.Select(e => e.ToUpper()).ToList();
var orderedList = (List<string> l) => l.OrderBy(d => d).ToList();

var beer = new List<string>()
{
    "Erdinger", "Corona", "Colimita", "Amstel"
};
var orderedUpperBeers = beers.P(upperList).P(orderedList);

orderedUpperBeers.ForEach(e => Console.Writeline(e));

public static class Methods
{
    public static TOut Pipe<TIn, TOut>(this TIn v, Func<TIn, TOut> fnOut)
        where TIn : class
        where TOut : class
    {
        if (v == null)
            return null;

        return fnOut(v);
    }
}