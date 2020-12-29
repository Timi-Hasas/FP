using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_24_MultimiBinare
{
    class Program
    {
        //Aceleasi cerinte ca si la problema anterioara dar de data asta elementele sunt stocate ca vectori cu valori binare
        //(v[i] este 1 daca i face parte din multime si este 0 in caz contrar).
        static int Read()
        {
            bool isValid;
            int n = 0;
            do
            {
                try
                {
                    n = int.Parse(Console.ReadLine());
                    isValid = true;
                }
                catch (Exception)
                {
                    isValid = false;
                    Console.WriteLine("Invalid.");
                }
            } while (!isValid);
            return n;
        }
        static void ReadArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"a[{i}] = ");
                a[i] = Read();
            }
        }
        static void ViewArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                Console.Write($"{a[i]} ");
            Console.WriteLine();
        }

        static int[] Intersectia(int[]a, int[] b)
        {
            int[] result = new int[Math.Min(a.Length, b.Length)];
            for (int i = 0; i < result.Length; i++)
                if (a[i] == 1 && b[i] == 1)
                    result[i] = 1;
            return result;
        }

        static int[] Reuniune(int[] a, int[] b)
        {
            int[] temp = new int[a.Length + b.Length];
            int maxValue = 0;

            for (int i = 0; i < a.Length; i++)
                if (a[i] == 1)
                {
                    temp[i] = 1;
                    if (maxValue < i)
                        maxValue = i;
                }

            for (int i = 0; i < b.Length; i++)
                if (b[i] == 1)
                {
                    temp[i] = 1;
                    if (maxValue < i)
                        maxValue = i;
                }

            int[] result = new int[maxValue];
            for (int i = 0; i < result.Length; i++)
                result[i] = temp[i];
            return result;
        }

        static int[] Diferenta(int[] a, int[] b)
        {
            int[] result = new int[a.Length];
            int min = Math.Min(a.Length, b.Length);
            for (int i = 0; i < min; i++)
                if (a[i] == 1 && b[i] == 0)
                    result[i] = 1;

            for (int i = min; i < result.Length; i++)
                result[i] = a[i];

            return result;
        }
        static void Main(string[] args)
        {
            Console.Write("Lungimea primului vector: ");
            int n = Read();
            int[] a = new int[n];
            ReadArray(a);
            ViewArray(a);

            Console.Write("Lungimea celui de al doilea vector: ");
            int m = Read();
            int[] b = new int[m];
            ReadArray(b);
            ViewArray(b);

            Console.WriteLine();
            Console.WriteLine("Intersectia: ");
            ViewArray(Intersectia(a, b));

            Console.WriteLine();
            Console.WriteLine("Reuniunea: ");
            ViewArray(Reuniune(a, b));

            Console.WriteLine();
            Console.WriteLine("Diferenta dintre A si B: ");
            ViewArray(Diferenta(a, b));

            Console.WriteLine();
            Console.WriteLine("Diferenta dintre B si A: ");
            ViewArray(Diferenta(b, a));
        }
    }
}
