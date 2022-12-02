using System.Text.RegularExpressions;

string text = "an12390u-090+>OIjnfiudghd45e56424";
string digitpattern = @"[0-9]";
// string chatpattern = @"[a-zA-Z]";

var regex = new Regex(digitpattern);
int n = regex.Matches(text).Count;

Console.WriteLine("cantidad: "+ n);