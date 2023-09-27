//Horner
// 32105 w systemie 6-wym --> na system 10-wy     (4361)
// 111001 w systemie 2-wym --> na system 10-wy    (57)

using System;
using System.Security.Claims;

int p = int.Parse(Console.ReadLine());
string a = Console.ReadLine();
int w = 0;

w = Convert.ToInt32(Convert.ToString(a[0]));

for (int i = 1; i < a.Length; i++)
{
    w = p * w + (a[i] - 48);
}

Console.WriteLine(w);

//Konwersja BIN-->DEC oraz DEC-->BIN

string a = Console.ReadLine();
int w = 0;

for (int i = a.Length - 1; i >= 0; i--)
{
    w = w + (a[i] - 48) * (int)Math.Pow(2, a.Length - i - 1);
}
Console.WriteLine(w);

//yufufjmjhfhfgkhghjf

int p = int.Parse(Console.ReadLine());
string w = "";
while (p > 0)
{
    w = p % 2 + w;
    p = p / 2;
}
Console.WriteLine(w);

//sdnjsbcnwjdk

void d2b(int p)
{
    if (p == 0) return;
    d2b(p / 2);
    Console.Write(p % 2);
    
}
d2b(11);
