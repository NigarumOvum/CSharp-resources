using System.Text.RegularExpressions;

string text = "   un   texto     que  tiene  palabras   "
int n = 0;

text = Regex.Replace(text, @"\s+", " ").Trim();
var words = text.Split(' ');
n = words.Length;

Console.Writeline("Numero de palabras: " + n);