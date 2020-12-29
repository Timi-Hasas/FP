using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_22_OperatiiMultimi
{
    class Program
    {
        //Se dau doi vectori v1 si v2. Se cere sa determine intersectia, reuniunea, si diferentele v1-v2 si v2 -v1
        //(implementarea operatiilor cu multimi). Elementele care se repeta vor fi scrise o singura data in rezultat.

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
        static int[] Intersectia(int[] a, int[] b)
        {
            int[] temp = new int[Math.Min(a.Length, b.Length)];
            int k = 0;
            for (int i = 0; i < a.Length; i++)
            {
                int j = 0;
                bool found = false;
                while (j < b.Length && !found)
                {
                    if (a[i] == b[j])
                    {
                        found = true;
                        temp[k] = a[i];
                        k++;
                    }
                    j++;
                }
            }
            int[] result = new int[k];
            for (int i = 0; i < result.Length; i++)
                result[i] = temp[i];
            return result;
        }

        static int[] Reuniune(int[] a, int[] b)
        {
            int[] temp = new int[a.Length + b.Length];

            for (int i = 0; i < a.Length; i++)
                temp[i] = a[i];

            int k = a.Length;
            for (int i = 0; i < b.Length; i++)
            {
                bool found = false;
                for (int j = 0; j < temp.Length; j++)
                    if (b[i] == temp[j])
                        found = true;
                if (!found)
                {
                    temp[k] = b[i];
                    k++;
                }
            }

            int[] result = new int[k];
            for (int i = 0; i < result.Length; i++)
                result[i] = temp[i];

            return result;
        }

        static int[] Diferenta(int[] a, int[] b)
        {
            int[] temp = new int[a.Length];
            int k = 0;
            for(int i = 0; i < a.Length; i++)
            {
                bool found = false;
                for (int j = 0; j < b.Length; j++)
                    if (a[i] == b[j])
                        found = true;
                if(!found)
                {
                    temp[k] = a[i];
                    k++;
                }
            }
            int[] result = new int[k];
            for (int i = 0; i < result.Length; i++)
                result[i] = temp[i];

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
