using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_10_CautareBinara
{
    //Cautare binara. Se da un vector cu n elemente sortat in ordine crescatoare.
    //Se cere sa se determine pozitia unui element dat k.
    //Daca elementul nu se gaseste in vector rezultatul va fi -1. 
    class Program
    {
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
            Console.Write($"a[0] = ");
            a[0] = Read();
            for (int i = 1; i < a.Length; i++)
            {
                do
                {
                    Console.Write($"a[{i}] = ");
                    a[i] = Read();
                    if (a[i] < a[i - 1])
                        Console.WriteLine("Vectorul trebuie sa fie crescator!");
                } while (a[i] < a[i - 1]);
            }
        }
        static void ViewArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                Console.Write($"{a[i]} ");
            Console.WriteLine();
        }

        static int BinarySearch(int[]a, int nr)
        {
            int left = 0;
            int right = a.Length - 1;
            while (left <= right)
            {
                int middle = left + (right - left) / 2;

                if (nr == a[middle])
                    return middle;

                if (nr > a[middle])
                    left = middle + 1;
                else
                    right = middle - 1;
            }
            return -1;
        }
        static void Main(string[] args)
        {
            Console.Write("Lungimea vectorului: ");
            int n = Read();
            int[] a = new int[n];
            ReadArray(a);
            ViewArray(a);

            Console.WriteLine("Numarul cautat: ");
            int k = Read();
            Console.Write("Numarul se afla pe pozitia: ");
            Console.WriteLine(BinarySearch(a, k));
        }
    }
}
