using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_23_MultimiOrdonate
{
    class Program
    {
        //Aceleasi cerinte ca si la problema anterioara dar de data asta elementele din v1 respectiv v2  sunt in ordine strict crescatoare. 
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
            int i = 0, j = 0, k = 0;
            while(i < a.Length && j < b.Length)
            {
                if (a[i] < b[j])
                    i++;
                else
                if (a[i] > b[j])
                    j++;
     
                else
                if (a[i] == b[j])
                {
                    temp[k] = a[i];
                    i++;
                    j++;
                    k++;
                }
            }
            int[] result = new int[k];
            for (i = 0; i < result.Length; i++)
                result[i] = temp[i];

            return result;
        }

        static int[] Reuniune(int[] a, int[] b)
        {
            int[] temp = new int[a.Length + b.Length];
            int i = 0, j = 0, k = 0;
            while (i < a.Length && j < b.Length)
            {
                if (a[i] < b[j])
                {
                    temp[k] = a[i];
                    i++;
                    k++;
                }
                else
                if (a[i] > b[j])
                {
                    temp[k] = b[j];
                    k++;
                    j++;
                }
                else
                if (a[i] == b[j])
                {
                    temp[k] = a[i];
                    i++;
                    j++;
                    k++;
                }
            }
            while(i < a.Length)
            {
                temp[k] = a[i];
                i++;
                k++;
            }
            while (j < b.Length)
            {
                temp[k] = b[j];
                j++;
                k++;
            }

            int[] result = new int[k];
            for (i = 0; i < result.Length; i++)
                result[i] = temp[i];

            return result;
        }
        static int[] Diferenta(int[] a, int[] b)
        {
            int[] temp = new int[a.Length];
            int i = 0, j = 0, k = 0;
            while (i < a.Length && j < b.Length)
            {
                if (a[i] < b[j])
                {
                    temp[k] = a[i];
                    i++;
                    k++;
                }
                else
                if (a[i] > b[j])
                    j++;
                else
                if (a[i] == b[j])
                {
                    i++;
                    j++;
                }
            }
            while(i < a.Length)
            {
                temp[k] = a[i];
                k++;
                i++;
            }
            int[] result = new int[k];
            for (i = 0; i < result.Length; i++)
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
