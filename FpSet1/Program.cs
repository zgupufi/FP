using System;

public class Program
{
    static void Main(string[] args)
    {
        // Exemplu de apelare a functiilor
        problema1(2, -4); // Rezolva ecuatia 2x - 4 = 0
        problema2(1, -3, 2); // Rezolva ecuatia x^2 - 3x + 2 = 0
        problema3(10, 2); // Verifica daca 10 se divide cu 2
        problema4(2020); // Verifica daca 2020 este an bisect
        problema5(12345, 2); // Extrage a doua cifra de la sfarsitul numarului 12345
        problema6(3, 4, 5); // Verifica daca 3, 4, 5 pot fi laturile unui triunghi
        problema7(ref 5, ref 10); // Inverseaza valorile 5 si 10
        problema8(ref 5, ref 10); // Inverseaza valorile 5 si 10 fara variabile suplimentare
        problema9(28); // Afiseaza divizorii lui 28
        problema10(29); // Verifica daca 29 este prim
        problema11(12345); // Afiseaza cifrele lui 12345 in ordine inversa
        problema12(1, 100, 3); // Numara cate numere divizibile cu 3 sunt in intervalul [1, 100]
        problema13(2000, 2020); // Numara cati ani bisecti sunt intre 2000 si 2020
        problema14(121); // Verifica daca 121 este palindrom
        problema15(3, 1, 2); // Afiseaza 1, 2, 3 in ordine crescatoare
        problema16(5, 3, 1, 4, 2); // Afiseaza 1, 2, 3, 4, 5 in ordine crescatoare
        problema17(56, 98); // Calculeaza CMMDC si CMMMC pentru 56 si 98
        problema18(1176); // Descompune in factori primi pe 1176
        problema19(23222); // Verifica daca 23222 este format doar din 2 cifre care se repeta
        problema20(13, 30); // Afiseaza 13/30 ca fractie zecimala
    }

    static void problema1(double a, double b)
    {
        if (a == 0)
        {
            if (b == 0)
                Console.WriteLine("Ecuatia are o infinitate de solutii.");
            else
                Console.WriteLine("Ecuatia nu are solutie.");
        }
        else
        {
            double x = -b / a;
            Console.WriteLine($"Solutia ecuatiei este x = {x}");
        }
    }

    static void problema2(double a, double b, double c)
    {
        double delta = b * b - 4 * a * c;
        if (delta > 0)
        {
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine($"Ecuatia are doua solutii reale: x1 = {x1}, x2 = {x2}");
        }
        else if (delta == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine($"Ecuatia are o solutie reala dubla: x = {x}");
        }
        else
        {
            Console.WriteLine("Ecuatia nu are solutii reale.");
        }
    }

    static void problema3(int n, int k)
    {
        if (n % k == 0)
            Console.WriteLine($"{n} se divide cu {k}.");
        else
            Console.WriteLine($"{n} nu se divide cu {k}.");
    }

    static void problema4(int year)
    {
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            Console.WriteLine($"{year} este an bisect.");
        else
            Console.WriteLine($"{year} nu este an bisect.");
    }

    static void problema5(int number, int k)
    {
        for (int i = 1; i < k; i++)
        {
            number /= 10;
        }
        int digit = number % 10;
        Console.WriteLine($"A {k}-a cifra de la sfarsit este {digit}.");
    }

    static void problema6(double a, double b, double c)
    {
        if (a + b > c && a + c > b && b + c > a)
            Console.WriteLine($"{a}, {b}, {c} pot fi laturile unui triunghi.");
        else
            Console.WriteLine($"{a}, {b}, {c} nu pot fi laturile unui triunghi.");
    }

    static void problema7(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
        Console.WriteLine($"Dupa swap: a = {a}, b = {b}");
    }

    static void problema8(ref int a, ref int b)
    {
        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine($"Dupa swap: a = {a}, b = {b}");
    }

    static void problema9(int n)
    {
        Console.Write($"Divizorii lui {n} sunt: ");
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
                Console.Write($"{i} ");
        }
        Console.WriteLine();
    }

    static void problema10(int n)
    {
        if (n < 2)
        {
            Console.WriteLine($"{n} nu este prim.");
            return;
        }
        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
            {
                Console.WriteLine($"{n} nu este prim.");
                return;
            }
        }
        Console.WriteLine($"{n} este prim.");
    }

    static void problema11(int n)
    {
        Console.Write("Cifrele in ordine inversa: ");
        while (n > 0)
        {
            int digit = n % 10;
            Console.Write($"{digit} ");
            n /= 10;
        }
        Console.WriteLine();
    }

    static void problema12(int a, int b, int n)
    {
        int count = 0;
        for (int i = a; i <= b; i++)
        {
            if (i % n == 0)
                count++;
        }
        Console.WriteLine($"In intervalul [{a}, {b}] sunt {count} numere divizibile cu {n}.");
    }

    static void problema13(int y1, int y2)
    {
        int count = 0;
        for (int year = y1; year <= y2; year++)
        {
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                count++;
        }
        Console.WriteLine($"Intre anii {y1} si {y2} sunt {count} ani bisecti.");
    }

    static void problema14(int n)
    {
        int original = n;
        int reversed = 0;
        while (n > 0)
        {
            reversed = reversed * 10 + n % 10;
            n /= 10;
        }
        if (original == reversed)
            Console.WriteLine($"{original} este palindrom.");
        else
            Console.WriteLine($"{original} nu este palindrom.");
    }

    static void problema15(int a, int b, int c)
    {
        if (a > b) (a, b) = (b, a);
        if (a > c) (a, c) = (c, a);
        if (b > c) (b, c) = (c, b);
        Console.WriteLine($"Numerele in ordine crescatoare: {a}, {b}, {c}");
    }

    static void problema16(int a, int b, int c, int d, int e)
    {
        if (a > b) (a, b) = (b, a);
        if (a > c) (a, c) = (c, a);
        if (a > d) (a, d) = (d, a);
        if (a > e) (a, e) = (e, a);
        if (b > c) (b, c) = (c, b);
        if (b > d) (b, d) = (d, b);
        if (b > e) (b, e) = (e, b);
        if (c > d) (c, d) = (d, c);
        if (c > e) (c, e) = (e, c);
        if (d > e) (d, e) = (e, d);
        Console.WriteLine($"Numerele in ordine crescatoare: {a}, {b}, {c}, {d}, {e}");
    }

    static void problema17(int a, int b)
    {
        int x = a, y = b;
        while (y != 0)
        {
            int r = x % y;
            x = y;
            y = r;
        }
        int cmmdc = x;
        int cmmmc = (a * b) / cmmdc;
        Console.WriteLine($"CMMDC al lui {a} si {b} este {cmmdc}.");
        Console.WriteLine($"CMMMC al lui {a} si {b} este {cmmmc}.");
    }

    static void problema18(int n)
    {
        Console.Write($"Descompunerea in factori primi a lui {n} este: ");
        for (int i = 2; i <= n; i++)
        {
            int count = 0;
            while (n % i == 0)
            {
                count++;
                n /= i;
            }
            if (count > 0)
                Console.Write($"{i}^{count} ");
        }
        Console.WriteLine();
    }

    static void problema19(int n)
    {
        int[] digits = new int[10];
        while (n > 0)
        {
            digits[n % 10]++;
            n /= 10;
        }
        int uniqueDigits = 0;
        for (int i = 0; i < 10; i++)
        {
            if (digits[i] > 0)
                uniqueDigits++;
        }
        if (uniqueDigits == 2)
            Console.WriteLine("Numarul este format doar din 2 cifre care se repeta.");
        else
            Console.WriteLine("Numarul nu este format doar din 2 cifre care se repeta.");
    }

    static void problema20(int m, int n)
    {
        int intPart = m / n;
        m %= n;
        Dictionary<int, int> remainders = new Dictionary<int, int>();
        string fractionalPart = "";
        int position = 0;
        bool hasPeriod = false;
        int startPeriod = 0;

        while (m != 0)
        {
            if (remainders.ContainsKey(m))
            {
                hasPeriod = true;
                startPeriod = remainders[m];
                break;
            }
            remainders[m] = position;
            m *= 10;
            fractionalPart += (m / n).ToString();
            m %= n;
            position++;
        }

        if (hasPeriod)
        {
            fractionalPart = fractionalPart.Substring(0, startPeriod) + "(" + fractionalPart.Substring(startPeriod) + ")";
        }

        Console.WriteLine($"{m}/{n} = {intPart}.{fractionalPart}");
    }

    static void problema21()
    {
        int stanga = 1;
        int dreapta = 1024;
        int incercari = 0;

        Console.WriteLine("Ganditi-va la un numar intre 1 si 1024.");

        while (stanga <= dreapta)
        {
            int mijloc = (stanga + dreapta) / 2;
            incercari++;

            Console.Write($"Este numarul mai mare sau egal decat {mijloc}?: ");
            string raspuns = Console.ReadLine().ToLower();

            if (raspuns == "da")
            {
                stanga = mijloc + 1;
            }
            else if (raspuns == "nu")
            {
                dreapta = mijloc - 1;
            }
      
        }
        Console.WriteLine($"Numarul la care v-ati gandit este {dreapta}.");
        Console.WriteLine($"Am ghicit in {incercari} incercari.");
    }
}