using System;

class Program {
  public static void Main (string[] args);
//Zad1
// a = int.Parse(Console.ReadLine());
// Console.Write("Podaj liczbe2: ");
// b = int.Parse(Console.ReadLine());
// Console.Write("Podaj liczbe3: ");
// c = int.Parse(Console.ReadLine());
// if (b - a == c - b) 
//     Console.WriteLine("Ciag jest arytmetyczny");
// if (b / a == c / b) 
//     Console.WriteLine("Ciag jest geometryczny");
// Console.WriteLine();
//Zad2

// int suma = 0;
// for (int i = 100; i < 1000; i++)
// {
//    if (i % 8 == 0 && i % 16 !=0)
//    {
//        suma += i;
//    }
// }
// Console.WriteLine(suma);

//Zad3

//int podzielnik = 0;
//for (int i = 99; i > 9; i--)
//{
//    if (i%7==0)
//    {
//        podzielnik = i;
//        break;
//    }
//}

//int suma = 0;
//for (int j=100;j<1000;j++)
//{
//    if(j%podzielnik==0)
//    {
//        suma += j;
//    }
//}
//Console.WriteLine(suma);

//Zad4

// int ilosc = 0;
// int cd = 0;
// int cj = 0;

// for(int i = 10; i < 100; i++)
// {
//     cd = i / 10;
//     cj = i % 10;
//     if (cd >= 2 * cj) ;
//     {
//         ilosc += 1;
//     }
// }
// Console.WriteLine(ilosc);

  //Zad5

//int suma = 0;
//int ilosc = 0;
//int cd = 0;
//int cj = 0;

//for (int i = 100; i < 1000; i++)
//{
//    cd = i / 100;
//    cj = i % 100;
//    if (cd >= 2 * cj)
//    {
//        ilosc += 1;
//        suma += 1;
//    }
//}
//Console.WriteLine(suma+" "+ilosc);

//Zad6

//int n = int.Parse(Console.ReadLine());
//for (int i = 10; i < (19+19*n); i++)
//{
//    if (i % 19 == 0)
//    {
//        Console.WriteLine(i);
//    }
//}

  //Zad7
  //int skladnik = 0;
//int suma = 0;
//int n = int.Parse(Console.ReadLine());
//for (int i = 999; i > 100; i++)
//{
//    if (i % 37 == 0)
//    {
//        skladnik = i;
//        break;
//    }
//}
//for (int j = 0; j < n; j++)
//{
//    suma += (skladnik - 37 * j);
//}
//Console.WriteLine(suma);

//Zad8

//int suma = 0;
//int n = int.Parse(Console.ReadLine());
//for (int i = 1; i <=n; i++)
//{
//    suma = suma + ((3 * i - 1) * ((int)Math.Pow(-1,i,1)));
//}
//Console.WriteLine(suma);

