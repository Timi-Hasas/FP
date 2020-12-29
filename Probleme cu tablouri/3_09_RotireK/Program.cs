using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_09_RotireK
{
    class Program
    {
        //Rotire k. Se da un vector cu n elemente. Rotiti elementele vectorului cu k pozitii spre stanga. 
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
        static void Rotate(int[] a, int k)
        {
            int[] temp = new int[k];
            for (int i = 0; i < k; i++)
                temp[i] = a[i];

            for (int i = k; i < a.Length; i++)
                a[i - k] = a[i];

            int j = 0;
            for (int i = a.Length - k; i < a.Length; i++)
            {
                a[i] = temp[j];
                j++;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Lungimea vectorului: ");
            int n = Read();
            int[] a = new int[n];
            ReadArray(a);
            ViewArray(a);

            Console.Write("Numarul de rotiri: ");
            int k = Read();
            Rotate(a, k);
            ViewArray(a);
        }
    }
}
