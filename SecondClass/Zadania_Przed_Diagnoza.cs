// 1.User podaje NWD i NWW dwóch liczb. Napisz program, który znajdzie te liczby.
// a * b = nww(a, b) * nwd(a, b)

// using System.Numerics;
// Console.WriteLine(BigInteger.GreatestCommonDivisor(12, 34));

int NWD(int a, int b)
{
    while (a != b)
    {
        if (a > b)
            a -= b;
        if (b > a)
            b -= a;
    }
    return a;
}

int NWW (int a, int b)
{
    return a * b / NWD(a, b);
}

int nwd = int.Parse(Console.ReadLine());
int nww = int.Parse(Console.ReadLine());

// Brute Force

for (int i = 1; i < 100; i++)
{
   for (int j = 1; j < 100; j++)
   {
       if (NWD(i, j) == nwd && NWW(i, j) == nww) 
           Console.WriteLine(i + " " + j);
   }
}

// product nwd * nww

int iloczyn = nwd * nww;
for (int i = 1; i <= iloczyn; i++)
{
   if (iloczyn % i == 0 && NWD(i, iloczyn / i) == nwd && NWW(i, iloczyn / i) == nww && i < iloczyn / i)
       Console.WriteLine(i + " " + iloczyn / i);
}



// 2. Sprawdź czy suma dwóch ułamków podanych przez usera jest ułamkiem niewłaściwym.

string p = Console.ReadLine();
string d = Console.ReadLine();
int a, b, c, e;

string[] P = p.Split("/");
string[] D = d.Split("/");

a = int.Parse(P[0]);
b = int.Parse(P[1]);
c = int.Parse(D[0]);
d = int.Parse(D[1]);

int denominator = NWW(b, e);
int num1 = denominator * a / b;
int num2 = denominator * c / e;

if (licz1 + licz2 > denominator)
   Console.WriteLine("Tak");
else
   Console.WriteLine("Nie");


//3. Sprawdź czy wieksza jest suma dwóch wpisanych przez usera ułamków czy suma ich odwrotności.

//4. Sprawdź czy w danym napisie więcej jest spółgłosek czy samogłosek.

char[] Vowels = {'a','e', 'i', 'o', 'u', 'y'};
string n = Console.ReadLine();
int ilosc = 0;

for (int i = 0; i < n.Length; i++)
{
    if (Vowels.Contains(n[i]))
        ilosc++;
    else 
        --ilosc;
}
if (ilosc > 0)
    Console.WriteLine("There are more vowels");
else 
    Console.WriteLine("There are more consonants");

//5. Podaj której literki jest najwięcej w podanym napisie i jaka to jest literka.

//6. Znajdź trzy takie liczby, których suma, a także suma każdej pary tych liczb jest kwadratem innej liczby.

//7. Dwie wieżyce, jedna wysokości 30 stóp, druga 40 stóp, oddalone są od siebie o 50 stóp. 
//Pomiędzy nimi znajduje się wodotrysk, do którego zlatują dwa ptaki z wierzchołków obu wieżyc 
//i lecąc z jednakową prędkością przybywają w tym samym czasie. 
//Napisz program, który obliczy jest dłuższa odległość pozioma wodotrysku jednej z wieżyc?

//8. Brajanek z Dżesiką grają w siedem. Gra polega na tym, że jeden z graczy podaje granice przedziału <a, b> 
//a drugi z nich musi szybko odpowiedzieć, ile w tym przedziale jest liczb,
//które są podzielne przez siedem, albo suma ich cyfr jest podzielna przez siedem (lub jedno i drugie). 
//Napisz program, który pomaga w takich obliczeniach.

//9. Halinka wspina się na schody w centrum handlowym. Za każdym razem, gdy dziewczynka wspina się na nowe schody,
//zaczyna liczyć na głos po kolei od 1 do ilości stopni. Na przykład,
//jeśli wspina się na dwa zestawy schodów – jeden z 3 stopniami, a drugi z 4 stopniami – 
//będzie liczyć tak: 1, 2, 3, 1, 2, 3, 4.Masz dane wszystkie liczby, które Halinka wypowiedziała 
//podczas całej swojej wycieczki po centrum i Twoim zadaniem jest obliczenie, ile zestawów schodów „zaliczyła”.

//10. Brajanek wybrał się na spacer do parku. Przysiadł na chwilę na parkowej ławce i obserwował
//przechadzających się ludzi.
//W parku znajduje się n ławek ponumerowanych od 1 do n. Kiedy Brajanek zaczął swoje
//obserwacje, na i-tej ławce siedziało ai osób. Do parku przybyło właśnie m osób i każda chciałaby
//znaleźć sobie miejsce na ławce.
//Niech k oznacza największą liczbę osób siedzących na jednej ławce (po przyjściu tych dodatkowych m osób). 
//Jaka jest minimalna, a jaka maksymalna wartość k?

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());

int maks = 0, k;
int min = (a + b + c + m);

if (a > b && a > c) 
  maks = a;
if (b > c && b > a) 
  maks = b;
if (c > a && c > b) 
  maks = c;
k = maks1 + m;
Console.WriteLine("maksymalna wartość k = " + k);

if (min % 3 != 0) 
  min = (min / 3) + 1;
if (min < maks1) 
  Console.WriteLine("MIN wartość k = " + maks);
else 
  Console.WriteLine("minimalna wartość k = " + min);
