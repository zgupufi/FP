using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {

    }

    static void problema1(int[] vector)
    {
        int suma = vector.Sum();
        Console.WriteLine("Suma elementelor este: " + suma);
    }

    static void problema2(int[] vector, int k)
    {
        int index = Array.IndexOf(vector, k);
        Console.WriteLine($"Prima pozitie a lui {k} este {index}";
    }

    static void problema3(int[] vector)
    {
        int minIndex = Array.IndexOf(vector, vector.Min());
        int maxIndex = Array.IndexOf(vector, vector.Max());
        Console.WriteLine($"Pozitia celui mai mic element: {minIndex}, pozitia celui mai mare element: {maxIndex}");
    }

    static void problema4(int[] vector)
    {
        int min = vector.Min();
        int max = vector.Max();
        int countMin = vector.Count(x => x == min);
        int countMax = vector.Count(x => x == max);
        Console.WriteLine($"Min {min} pare de {countMin} ori. Max {max} apare de {countMax} ori.");
    }

    static void problema5(int[] vector, int e, int k)
    {
        List<int> list = vector.ToList();
        list.Insert(k, e);
        vector = list.ToArray();

    }

    static void problema6(int[] vector, int k)
    {
        List<int> list = vector.ToList();
        list.RemoveAt(k);
        vector = list.ToArray();

    }

    static void problema7(int[] vector)
    {
        Array.Reverse(vector);
    }

    static void problema8(int[] vector)
    {
        int first = vector[0];
        for (int i = 0; i < vector.Length - 1; i++)
        {
            vector[i] = vector[i + 1];
        }
        vector[vector.Length - 1] = first;
    }

    static void problema9(int[] vector, int k)
    {
        for (int c = 0; c < k; c++)
        {
            int first = vector[0];
            for (int i = 0; i < vector.Length - 1; i++)
            {
                vector[i] = vector[i + 1];
            }
            vector[vector.Length - 1] = first;
        }

    }

    static void problema10(int[] vector, int k)
    {
        int index = Array.BinarySearch(vector, k);
        if (index < 0)
            Console.WriteLine("nu se gaseste");
        else
            Console.WriteLine(index);
    }

    static void problema11(int n)
    {
        bool[] isPrime = new bool[n + 1];
        for (int i = 2; i <= n; i++) isPrime[i] = true;

        for (int p = 2; p * p <= n; p++)
        {
            if (isPrime[p])
            {
                for (int i = p * p; i <= n; i += p)
                    isPrime[i] = false;
            }
        }
        for (int i = 2; i <= n; i++)
            if (isPrime[i] == true)
                Console.Write(i + " ");
    }

    static void problema12(int[] vector)
    {
        for (int i = 0; i < vector.Length - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < vector.Length; j++)
            {
                if (vector[j] < vector[minIndex])
                    minIndex = j;
            }
            int temp = vector[i];
            vector[i] = vector[minIndex];
            vector[minIndex] = temp;
        }
    }

    static void problema13(int[] vector)
    {
        for (int i = 1; i < vector.Length; i++)
        {
            int key = vector[i];
            int j = i - 1;
            while (j >= 0 && vector[j] > key)
            {
                vector[j + 1] = vector[j];
                j--;
            }
            vector[j + 1] = key;
        }
    }

    static void problema14(int[] vector)
    {
        int index = 0;
        for (int i = 0; i < vector.Length; i++)
        {
            if (vector[i] != 0)
            {
                vector[index] = vector[i];
                index++;
            }
        }
        for (int i = index; i < vector.Length; i++)
        {
            vector[i] = 0;
        }
    }

    static void problema15(int[] vector)
    {
        List<int> uniqueList = vector.Distinct().ToList();
        vector = uniqueList.ToArray();
    }

    static void problema16(int[] vector)
    {
        int cmmd = vector[0];
        for (int i = 1; i < vector.Length; i++)
        {
            cmmd = Euclid(cmmd, vector[i]);
            if (cmmd == 1)
                break;
        }
        static int Euclid(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

    }

    static void problema17(int n, int b)
    {
        string result = "";
        while (n > 0)
        {
            int rest = n % b;
            result = GetChar(rest) + result;
            n = n / b;
        }
        static char GetChar(int value)
        {
            if (value >= 10)
                return (char)('A' + (value - 10));
            else
                return (char)('0' + value);
        }
        Console.WriteLine($"Numărul {n} în baza {b} este: {result}");
    }

    static void problema18(int[] coeficienti, double x)
    {
        double result = 0;
        for (int i = 0; i < coeficienti.Length; i++)
        {
            result += coeficienti[i] * Math.Pow(x, i);
        }
        Console.WriteLine($"Valoarea polinomului in punctul {x} e {result}");
    }

    static void problema19(int[] s, int[] p)
    {
        int count = 0;
        for (int i = 0; i <= s.Length - p.Length; i++)
        {
            bool match = true;
            for (int j = 0; j < p.Length; j++)
            {
                if (s[i + j] != p[j])
                {
                    match = false;
                    break;
                }
            }
            if (match)
                count++;
        }
        Console.WriteLine(count);
    }

    static void problema20(int[] s1, int[] s2)
    {
        int maxMatches = 0;
        for (int shift = 0; shift < s1.Length; shift++)
        {
            int matches = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] == s2[(i + shift) % s1.Length])
                    matches++;
            }
            if (matches > maxMatches)
                maxMatches = matches;
        }
        Console.WriteLine(maxMatches);
    }

    static void problema21(int[] v1, int[] v2)
    {
        int minLength = Math.Min(v1.Length, v2.Length);
        for (int i = 0; i < minLength; i++)
        {
            if (v1[i] < v2[i])
            {
                Console.WriteLine("v1 este inaintea lui v2 lexicografic");
                break;
            }
            else if (v1[i] > v2[i])
            {
                Console.WriteLine("v2 este inaintea lui v1 lexicografic");
                break;
            }
        }
        if (v1.Length < v2.Length)
            Console.WriteLine("v1 este inaintea lui v2 lexicografic");
        else if (v1.Length > v2.Length)
            Console.WriteLine("v2 este inaintea lui v1 lexicografic");
        else
            Console.WriteLine("v1 și v2 sunt egale lexicografic");
    }

    static void problema22(int[] v1, int[] v2)
    {
        List<int> intersectie = new List<int>();
        foreach (int x in v1)
        {
            if (Array.Exists(v2, y => y == x) && !intersectie.Contains(x))
                intersectie.Add(x);
        }
        List<int> reuniune = new List<int>();
        foreach (int x in v1)
        {
            if (!reuniune.Contains(x))
                reuniune.Add(x);
        }
        foreach (int x in v2)
        {
            if (!reuniune.Contains(x))
                reuniune.Add(x);
        }

        List<int> diferentaV1V2 = new List<int>();
        foreach (int x in v1)
        {
            if (!Array.Exists(v2, y => y == x) && !diferentaV1V2.Contains(x))
                diferentaV1V2.Add(x);
        }
        List<int> diferentaV2V1 = new List<int>();
        foreach (int x in v2)
        {
            if (!Array.Exists(v1, y => y == x) && !diferentaV2V1.Contains(x))
                diferentaV2V1.Add(x);
        }

        Console.WriteLine("Intersectia: " + string.Join(", ", intersectie));
        Console.WriteLine("Reuniunea: " + string.Join(", ", reuniune));
        Console.WriteLine("Diferenta v1 - v2: " + string.Join(", ", diferentaV1V2));
        Console.WriteLine("Diferenta v2 - v1: " + string.Join(", ", diferentaV2V1));
    }

    static void problema23(int[] v1, int[] v2)
    {
        List<int> intersectie = new List<int>();
        int i = 0, j = 0;
        while (i < v1.Length && j < v2.Length)
        {
            if (v1[i] == v2[j])
            {
                intersectie.Add(v1[i]);
                i++;
                j++;
            }
            else if (v1[i] < v2[j])
                i++;
            else
                j++;
        }
        List<int> reuniune = new List<int>();
        i = 0;
        j = 0;
        while (i < v1.Length && j < v2.Length)
        {
            if (v1[i] < v2[j])
            {
                reuniune.Add(v1[i]);
                i++;
            }
            else if (v1[i] > v2[j])
            {
                reuniune.Add(v2[j]);
                j++;
            }
            else
            {
                reuniune.Add(v1[i]);
                i++;
                j++;
            }
        }
        while (i < v1.Length)
        {
            reuniune.Add(v1[i]);
            i++;
        }
        while (j < v2.Length)
        {
            reuniune.Add(v2[j]);
            j++;
        }
        List<int> diferentaV1V2 = new List<int>();
        i = 0;
        j = 0;
        while (i < v1.Length && j < v2.Length)
        {
            if (v1[i] < v2[j])
            {
                diferentaV1V2.Add(v1[i]);
                i++;
            }
            else if (v1[i] > v2[j])
                j++;
            else
            {
                i++;
                j++;
            }
        }
        while (i < v1.Length)
        {
            diferentaV1V2.Add(v1[i]);
            i++;
        }

        List<int> diferentaV2V1 = new List<int>();
        i = 0;
        j = 0;
        while (i < v1.Length && j < v2.Length)
        {
            if (v2[j] < v1[i])
            {
                diferentaV2V1.Add(v2[j]);
                j++;
            }
            else if (v2[j] > v1[i])
                i++;
            else
            {
                i++;
                j++;
            }
        }
        while (j < v2.Length)
        {
            diferentaV2V1.Add(v2[j]);
            j++;
        }

        Console.WriteLine("Intersectia: " + string.Join(", ", intersectie));
        Console.WriteLine("Reuniunea: " + string.Join(", ", reuniune));
        Console.WriteLine("Diferenta v1 - v2: " + string.Join(", ", diferentaV1V2));
        Console.WriteLine("Diferenta v2 - v1: " + string.Join(", ", diferentaV2V1));
    }

    static void problema24(int[] v1, int[] v2)
    {
        int n = v1.Length;
        int[] intersectie = new int[n];
        int[] reuniune = new int[n];
        int[] diferentaV1V2 = new int[n];
        int[] diferentaV2V1 = new int[n];

        for (int i = 0; i < n; i++)
        {
            if (v1[i] == 1 && v2[i] == 1)
                intersectie[i] = 1;
            if (v1[i] == 1 || v2[i] == 1)
                reuniune[i] = 1;
            if (v1[i] == 1 && v2[i] == 0)
                diferentaV1V2[i] = 1;
            if (v2[i] == 1 && v1[i] == 0)
                diferentaV2V1[i] = 1;
        }

        Console.WriteLine("Intersectia: " + string.Join(", ", intersectie));
        Console.WriteLine("Reuniunea: " + string.Join(", ", reuniune));
        Console.WriteLine("Diferenta v1 - v2: " + string.Join(", ", diferentaV1V2));
        Console.WriteLine("Diferenta v2 - v1: " + string.Join(", ", diferentaV2V1));
    }

    static void problema25(int[] v1, int[] v2)
    {
        int[] result = new int[v1.Length + v2.Length];
        int i = 0, j = 0, k = 0;
        while (i < v1.Length && j < v2.Length)
        {
            if (v1[i] < v2[j])
                result[k++] = v1[i++];
            else
                result[k++] = v2[j++];
        }
        while (i < v1.Length)
            result[k++] = v1[i++];
        while (j < v2.Length)
            result[k++] = v2[j++];
    }

    static void problema26(int[] numar1, int[] numar2)
    {
        int[] suma = Aduna(numar1, numar2);

        int[] diferenta = Scade(numar1, numar2);

        int[] produs = Inmulteste(numar1, numar2);


        static int[] Aduna(int[] numar1, int[] numar2)
        {
            int maxLength = Math.Max(numar1.Length, numar2.Length);
            int[] rezultat = new int[maxLength + 1];
            int carry = 0;
            int i = numar1.Length - 1;
            int j = numar2.Length - 1;
            int k = rezultat.Length - 1;

            while (i >= 0 || j >= 0 || carry > 0)
            {
                int cifra1 = 0;
                if (i >= 0)
                    cifra1 = numar1[i];
                else
                    cifra1 = 0;

                int cifra2 = 0;
                if (j >= 0)
                    cifra2 = numar2[j];
                else
                    cifra2 = 0;

                int sumaCifrelor = cifra1 + cifra2 + carry;
                carry = sumaCifrelor / 10;
                rezultat[k] = sumaCifrelor % 10;
                i--;
                j--;
                k--;
            }

            if (rezultat[0] == 0)
                return rezultat.Skip(1).ToArray();
            else
                return rezultat;
        }

        static int[] Scade(int[] numar1, int[] numar2)
        {
            int maxLength = Math.Max(numar1.Length, numar2.Length);
            int[] rezultat = new int[maxLength];
            int borrow = 0;
            int i = numar1.Length - 1;
            int j = numar2.Length - 1;
            int k = rezultat.Length - 1;

            while (i >= 0 || j >= 0)
            {
                int cifra1 = 0;
                if (i >= 0)
                    cifra1 = numar1[i];
                else
                    cifra1 = 0;

                int cifra2 = 0;
                if (j >= 0)
                    cifra2 = numar2[j];
                else
                    cifra2 = 0;

                int diferentaCifrelor = cifra1 - cifra2 - borrow;

                if (diferentaCifrelor < 0)
                {
                    diferentaCifrelor += 10;
                    borrow = 1;
                }
                else
                    borrow = 0;

                rezultat[k] = diferentaCifrelor;
                i--;
                j--;
                k--;
            }

            while (rezultat.Length > 1 && rezultat[0] == 0)
                rezultat = rezultat.Skip(1).ToArray();

            return rezultat;
        }

        static int[] Inmulteste(int[] numar1, int[] numar2)
        {
            int[] rezultat = new int[numar1.Length + numar2.Length];

            for (int i = numar1.Length - 1; i >= 0; i--)
            {
                int carry = 0;
                for (int j = numar2.Length - 1; j >= 0; j--)
                {
                    int produs = numar1[i] * numar2[j] + rezultat[i + j + 1] + carry;
                    carry = produs / 10;
                    rezultat[i + j + 1] = produs % 10;
                }
                rezultat[i] += carry;
            }

            while (rezultat.Length > 1 && rezultat[0] == 0)
                rezultat = rezultat.Skip(1).ToArray();

            return rezultat;
        }
    }
    static void problema27(int[] vector, int index)
    {
        int[] sortedVector = vector.OrderBy(x => x).ToArray();
        Console.WriteLine(sortedVector[index]);
    }

    static void problema28(int[] vector, int stanga, int dreapta)
    {
        if (stanga < dreapta)
        {
            int pivotIndex = Partitioneaza(vector, stanga, dreapta);
            problema28(vector, stanga, pivotIndex - 1);
            problema28(vector, pivotIndex + 1, dreapta);
        }


        static int Partitioneaza(int[] vector, int stanga, int dreapta)
        {
            int pivot = vector[dreapta];
            int i = stanga - 1;

            for (int j = stanga; j < dreapta; j++)
            {
                if (vector[j] < pivot)
                {
                    i++;
                    (vector[i], vector[j]) = (vector[j], vector[i]);
                }
            }

            (vector[i + 1], vector[dreapta]) = (vector[dreapta], vector[i + 1]);
            return i + 1;
        }

    }

    static void problema29(int[] vector, int stanga, int dreapta)
    {
        if (stanga < dreapta)
        {
            int mijloc = (stanga + dreapta) / 2;
            problema29(vector, stanga, mijloc);
            problema29(vector, mijloc + 1, dreapta);
            Combina(vector, stanga, mijloc, dreapta);
        }
    

    static void Combina(int[] vector, int stanga, int mijloc, int dreapta)
    {
        int n1 = mijloc - stanga + 1;
        int n2 = dreapta - mijloc;

        int[] stangaTemp = new int[n1];
        int[] dreaptaTemp = new int[n2];

        for (int i = 0; i < n1; i++)
            stangaTemp[i] = vector[stanga + i];
        for (int j = 0; j < n2; j++)
            dreaptaTemp[j] = vector[mijloc + 1 + j];

        int k = stanga;
        int i1 = 0, j1 = 0;

        while (i1 < n1 && j1 < n2)
        {
            if (stangaTemp[i1] <= dreaptaTemp[j1])
            {
                vector[k] = stangaTemp[i1];
                i1++;
            }
            else
            {
                vector[k] = dreaptaTemp[j1];
                j1++;
            }
            k++;
        }

        while (i1 < n1)
        {
            vector[k] = stangaTemp[i1];
            i1++;
            k++;
        }

        while (j1 < n2)
        {
            vector[k] = dreaptaTemp[j1];
            j1++;
            k++;
        }
    }
    }



    static void problema31(int[] vector)
    {
        int candidate = -1, count = 0;
        foreach (int num in vector)
        {
            if (count == 0)
            {
                candidate = num;
                count = 1;
            }
            else if (candidate == num)
                count++;
            else
                count--;
        }
        count = vector.Count(x => x == candidate);
        if (count > vector.Length / 2)
            Console.WriteLine($"Elementul majoritate este {candidate}");
        else
            Console.WriteLine("Nu exista element majoritate.");
    }
}