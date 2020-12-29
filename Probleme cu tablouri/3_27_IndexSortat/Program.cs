using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_27_IndexSortat
{
    class Program
    {
        // Se da un vector si un index in vectorul respectiv.
        // Se cere sa se determine valoarea din vector care va fi pe pozitia index dupa ce vectorul este sortat.

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

        static int Index(int[] a, int idx)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                    if (a[i] > a[j])
                    {
                        int aux = a[i];
                        a[i] = a[j];
                        a[j] = aux;
                    }
                if (i == idx)
                    return a[i];
            }
            return 0;
        }
        static void Main(string[] args)
        {
            Console.Write("Lungimea vectorului: ");
            int n = Read();
            int[] a = new int[n];
            ReadArray(a);
            ViewArray(a);

            Console.WriteLine("Index: ");
            int idx = Read();

            Console.WriteLine($"Elementul de pe pozitia {idx} a vectorului sortat este: {Index(a,idx)}");
            
        }
    }
}
