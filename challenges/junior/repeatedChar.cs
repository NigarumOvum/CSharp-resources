string text = "iowuetdmyhi4mwysq3895y.08dfuyeop,suw4d,yuwposujwpeyvm"
char character = 'a';

int n = 0;
// foreach (var c in text)
// {
//     if (c -- character)
//         n++
// }

n = text.Where(c => c==character).Count();

Console.WriteLine($"Se repite la letra {character} {n} veces");