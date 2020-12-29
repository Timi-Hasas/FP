using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_08_Rotire
{
    class Program
    {
        //Rotire. Se da un vector cu n elemente. Rotiti elementele vectorului cu o pozitie spre stanga.
        //Prin rotire spre stanga primul element devine ultimul, al doilea devine primul etc. 
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

        static void Rotate(int[] a)
        {
            int k = a[0];
            for (int i = 1; i < a.Length; i++)
                a[i - 1] = a[i];
            a[a.Length - 1] = k;
        }
        static void Main(string[] args)
        {
            Console.Write("Lungimea vectorului: ");
            int n = Read();
            int[] a = new int[n];
            ReadArray(a);
            ViewArray(a);
            Rotate(a);
            ViewArray(a);
        }
    }
}
