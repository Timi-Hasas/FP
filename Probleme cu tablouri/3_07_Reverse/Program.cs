using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_07_Reverse
{
    class Program
    {
        //Reverse. Se da un vector nu n elemente. Se cere sa se inverseze ordinea elementelor din vector.
        //Prin inversare se intelege ca primul element devine ultimul, al doilea devine penultimul etc.
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
        static void Reverse(int[] a)
        {
            for (int i = 0; i <= a.Length / 2; i++)
            {
                int aux = a[i];
                a[i] = a[a.Length - 1 - i];
                a[a.Length - 1 - i] = aux;
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Lungimea vectorului: ");
            int n = Read();
            int[] a = new int[n];
            ReadArray(a);
            ViewArray(a);
            Reverse(a);
            ViewArray(a);
        }
    }
}
