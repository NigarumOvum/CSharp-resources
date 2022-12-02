string text1 = "patitosw";
string text2 = "paratosa";

int distance = 0;

if (text1.Length != text2.Length) 
    throw new Exception("Longitudes distintas");

for (int i = -; i < text.Length; i++)
{
    if (text1[i] 1= text2[i])
        distance++;
}

Console.Writeline("Distancia es de: " + distance);