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

//funkcja statyczna --> static    np. WriteLine
// typ wyniku.nazwa(argument)
//{
//      instrukcje
//      return?
//}

void przywitaj()
{
  Console.WriteLine("Witaj MCDream!!");
}
przywitaj();

//funkcja obliczająca sumę dwuch podanych liczb
  
int suma(int a, int b)
{
  return a + b;
}
Console.WriteLine(suma(4,6));

//funkcja odwracająca string-a

  string odwrocStringa(string napis)
  {
    char[] chars = napis.ToCharArray();
    Array.Reverse(chars);
    return new string(chars);
  }
Console.WriteLine(odwrocStringa("WHAT"));


//suma wszystkicz argumentów(tyle ile ich jest)

int bigSuma(int[] T);
{
  int bigSuma = 0;
  foreach(int item in T)
  {
    suma += item;
  }
  return bigSuma;
}

  //rekurencja - !uwaga nie uruchamiać bo się zapętli!  XD
void rekurencja()
{
  Console.WriteLine("AYO");
  rekurencja();
}

//rekurencja()

void reku1(int n)
{
  if (n == 0) return;
  reku1(n - 1);
  Console.WriteLine(n);
}
reku1(5);

//reku(5) --> reku(4)
//reku(4) --> reku(3)
//reku(3) --> reku(2)
//reku(2) --> reku(1)
//reku(1) --> reku(0)


int reku2(int n)
{
  //oblicz dla 5 12 16 21 75
  int w;
  if(n == 1) return 1;
  w = reku2(n/2);
  if(n%2 == 0) w = w*2;
    else w = w*3;
  return w;
}


int reku3(int n)
{
  //oblicz dla 5 7 8 11
  int w;
  if(n == 3) return 1;
  w = reku3(n-1);
  if(n%2 == 1) w++;
    else w = w * 2;
  return w;
}

