using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
  }
}
//Funkcje są nam znane z matmy >:D    f(x) WriteLine()

//typ_zwracalny nazwa(parametry);
//{
//    instrukcje
//}

void przywitaj()
{
    Console.WriteLine("Witam MCDream!");
}
przywitaj();
przywitaj();

//napisz funkcję, która oblicza sumę przekazanych przez parametr 3-ch liczb
//jako void
void suma1(int a, int b)
{
    Console.WriteLine(a + b);
}
suma1(4, 7);

//jako int
int suma2(int x, int y)
{
    return x + y;
}
suma2(4, 7);

//napisz funkcję dającą Daj rabat(cena,rabat) na towar

double DajRabat(double cena, int rabat)
{
    return cena * (1 - (rabat / 100d));
}
Console.WriteLine(DajRabat(100d, 25));