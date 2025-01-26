using System;

public class Program
{
    static void Main(string[] args)
    {
        static void problema1(int n)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                    count++;
            }
            Console.WriteLine(count);
        }

        static void problema2(int n)
        {
            int negative = 0, zero = 0, pozitive = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < 0)
                    negative++;
                else if (num == 0)
                    zero++;
                else
                    pozitive++;
            }
            Console.WriteLine($"Negative: {negative}, cero: {zero}, pozitive: {positive}");
        }

        static void problema3(int n)
        {
            int sum = 0;
            long p = 1;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
                p *= i;
            }
            Console.WriteLine($"Sum: {sum}, Produs: {p}");
        }

        static void problema4(int n, int a)
        {
            int position = -1;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num == a)
                    position = i;
            }
            Console.WriteLine(position);
        }

        static void problema5(int n)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num == i)
                    count++;
            }
            Console.WriteLine(count);
        }

        static void problema6(int n)
        {
            int prev = int.MinValue;
            bool asc = true;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < prev)
                    asc = false;
                prev = num;
            }
            Console.WriteLine(asc);
        }

        static void problema7(int n)
        {
            int min = int.MaxValue, max = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < min)
                    min = num;
                if (num > max)
                    max = num;
            }
            Console.WriteLine($"Min: {min}, Max: {max}");
        }

        static void problema8(int n)
        {
            int a = 0, b = 1;
            for (int i = 2; i <= n; i++)
            {
                int temp = a + b;
                a = b;
                b = temp;
            }
            Console.WriteLine(b);
        }

        static void problema9(int n)
        {
            int prev = int.Parse(Console.ReadLine());
            bool inc = true, dec = true;
            for (int i = 1; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < prev)
                    inc = false;
                if (num > prev)
                    dec = false;
                prev = num;
            }
            if (inc == true || dec==true)
            Console.WriteLine("Secventa e monotona");
            else
                Console.WriteLine("Secventa nu e monotona");
        }

        static void problema10(int n)
        {
            int maxCount = 1, currentCount = 1;
            int prev = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num == prev) 
                    currentCount++;
                else currentCount = 1;
                if (currentCount > maxCount) 
                    maxCount = currentCount;
                prev = num;
            }
            Console.WriteLine(maxCount);
        }

        static void problema11(int n)
        {
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += 1.0 / num;
            }
            Console.WriteLine(sum);
        }

        static void problema12(int n)
        {
            int count = 0;
            bool inGroup = false;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num != 0)
                {
                    if (!inGroup) 
                        count++;
                    inGroup = true;
                }
                else inGroup = false;
            }
            Console.WriteLine(count);
        }

        static void problema13(int n)
        {
            int first = int.Parse(Console.ReadLine());
            int prev = first;
            int rot = -1;
            for (int i = 1; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < prev) 
                    rot = i;
                prev = num;
            }
            bool isRotated;
            if (rot == -1 || (prev <= first))
                 isRotated = true;
            else
                 isRotated = false;
            Console.WriteLine(isRotated);
        }

        static void problema14(int n)
        {
            int first = int.Parse(Console.ReadLine());
            int prev = first;
            int rot = -1;
            int inc = 0, dec = 0;
            for (int i = 1; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < prev)
                    inc++;
                if (num > prev)
                    dec++;
                if (num < prev && rot == -1) rot = i;
                prev = num;
            }
            if (inc <= 1 || dec  <= 1)
                Console.WriteLine("este rotita");
            else
                Console.WriteLine("nu este rotita");
        }

        static void problema15(int n)
        {
            int prev = int.Parse(Console.ReadLine());
            bool inc = true;
            bool dec = false;
            bool isBitonic = true;
            for (int i = 1; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (inc && num < prev) 
                    inc = false;
                if (!inc && num > prev) 
                    isBitonic = false;
                prev = num;
            }
            Console.WriteLine(isBitonic);
        }

        static void problema16(int n)
        {
            int first = int.Parse(Console.ReadLine());
            int prev = first;
            int rot= -1;
            bool inc = true;
            bool dec = false;
            bool isBitonic = true;
            for (int i = 1; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (inc && num < prev) 
                    inc = false;
                if (!inc && num > prev) 
                    rot = i;
                prev = num;
            }
            if (rot == -1 || (prev <= first)
            isBitonic = true;
        else
                isBitonic = false;
            Console.WriteLine(isBitonic);
        }

        static void problema17(int n)
        {
            int level = 0, maxLevel = 0;
            bool valid = true;
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x == 0) 
                    level++;
                else level--;
                if (level < 0) 
                    valid = false;
                if (level > maxLevel)
                    maxLevel = level;
            }
            if(valid && level == 0)
                Console.WriteLine($"este corecta,nivelul maxim e {maxLevel}");
        }

      
    }
}