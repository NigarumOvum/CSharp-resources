string text = "pato";
string textResult = "";

// for(int i=text.Length-1; i<text.Length; i>=0; i--)
// {
//     textReslt += text[i];
// }

char[] chars = text.ToCharArray();
Array.Reverse(chars);
textReslt = new String(chars);

Console.WriteLine(textReslt);