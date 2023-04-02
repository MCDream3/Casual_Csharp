using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
  }
}

using System.Security.Cryptography;

string[] s = System.IO.File.ReadAllLines("D:\\Inf\\ZadaniaZMatur\\Z2020\\Mat20\\przyklad.txt");

foreach (string item in s)
{
    Console.WriteLine(s);
    string[] TE = item.Split(" ");
    Console.WriteLine(TE[1]);
}

//L = ma to być tablica int-ów
//N = ma to być tablica string-ów

int[] L = new int[s.Length];
string[] N = new string[s.Length];
int k = 0;
string[] LINIA = new string[2];

foreach (string item in s)
{
    LINIA = item.Split(" ");
    L[k] = int.Parse(item.Split(" ")[0]);
    N[k] = LINIA[1];

    //L[k] = int.Parse(item.Split(" ")[0]);
    //N[k] = item.Split(" ")[1];

    k++;
}

bool CzyPierwsza(int n)
{
    for (int i = 2; i < n; i++)
        if(n % i == 0)
            return true; 
    return false;
}

for (int i = 0; i < L.Length; i++)
{
    if (L[i] > 4 && L[i] % 2 == 0)
    {
        for (int j = 3; j < L[i]; j++)
        {
            if (CzyPierwsza(j) && CzyPierwsza(L[i] - j))
            {
                Console.WriteLine($"{L[i]} {i} {L[i] - j}");
                break;
            }
        }
    }
}