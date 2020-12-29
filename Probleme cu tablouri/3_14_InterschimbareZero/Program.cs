using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_14_InterschimbareZero
{
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
        static void Zero(int[] a)
        {
            int j = 1;
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i] == 0 && i != a.Length - 1)
                {
                    while (a[j] == 0 && j != a.Length - 1)
                        j++;

                    int aux = a[i];
                    a[i] = a[j];
                    a[j] = aux;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Lungimea vectorului: ");
            int n = Read();
            int[] a = new int[n];
            ReadArray(a);
            ViewArray(a);
            Zero(a);
            ViewArray(a);
        }
    }
}
