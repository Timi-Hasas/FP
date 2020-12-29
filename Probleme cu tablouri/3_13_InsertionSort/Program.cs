using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_13_InsertionSort
{
    class Program
    {
        //Sortare prin insertie. Implementati algoritmul de sortare <Insertion Sort>.
        static void InsertionSort(int[] a)
        {
            for(int i = 1; i < a.Length; i++)
            {
                int current = a[i];
                int j = i - 1;
                while(current < j && j >= 0)
                {
                    a[j + 1] = a[j];
                    j -= 1;
                }
                a[j + 1] = current;
            }
        }
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
        static void Main(string[] args)
        {
            Console.Write("Lungimea vectorului: ");
            int n = Read();
            int[] a = new int[n];
            ReadArray(a);
            ViewArray(a);
            InsertionSort(a);
            ViewArray(a);
        }
    }
}
