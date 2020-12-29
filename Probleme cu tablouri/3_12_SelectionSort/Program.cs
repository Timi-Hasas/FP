using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_12_SelectionSort
{
    //Sortare selectie. Implementati algoritmul de sortare <Selection Sort>. 
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

        static void SelectionSort(int[] a)
        {
            int min_idx;
            for(int i = 0; i < a.Length - 1; i++)
            {
                min_idx = i;
                for (int j = i; j < a.Length; j++)
                    if (a[min_idx] > a[j])
                        min_idx = j;

                int aux = a[min_idx];
                a[min_idx] = a[i];
                a[i] = aux;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Lungimea vectorului: ");
            int n = Read();
            int[] a = new int[n];
            ReadArray(a);
            ViewArray(a);
            SelectionSort(a);
            ViewArray(a);
        }
    }
}
