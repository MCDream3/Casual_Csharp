using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karta pracy Cs 1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zad 1
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(a*a + Math.Pow(b,2));

            //Zad 2
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine((c+d) * (c+d));

            //Zad 3
            int e = int.Parse(Console.ReadLine());
            int f = int.Parse(Console.ReadLine());

            Console.WriteLine((e - f) * (e - f) * (e - f));

            //Zad 4
            int g = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int i = int.Parse(Console.ReadLine());

            Console.WriteLine(g * h * i);

            //Zad 5
            int j = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine(2 * (j + k) / 5);

            //Zad 6
            int l = int.Parse(Console.ReadLine());
            double m = 1.23;

            Console.WriteLine(l * m);

            //Zad 7
            int n = int.Parse(Console.ReadLine());
            int o = int.Parse(Console.ReadLine());

            Console.WriteLine(n % o);
        }
    }
}
