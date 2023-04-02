using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
  }
}

//StreamReader

string[] liczby = 
    System.IO.File.ReadAllLines(
        @"d:\Inf\Zadanie4_IDK\liczby_przyklad.txt");     //<-- Wczytanie pliku do C#

foreach (string line in liczby)      //<--wypisanie zawartości pliku
    Console.WriteLine(line);

//StreamWriter

StreamWriter wynik = new(@"d:\Inf\Zadanie4_IDK\wyniki4_1.txt");

wynik.WriteLine("Zadanie 4.1\n");


wynik.Flush();       //<--wyczyszcza zawartośc pliku
wynik.Close();       //<--nie obowiązkowo tego używać

wynik.WriteLine("Zadanie 4.1\n");
bool czyP(int x)
{
    for (int i = 2; i < Math.Sqrt(x) + 1; i++)
        if (x % i == 0)
    return false;
    return true;
}
