using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_28_Quicksort
{
    class Program
    {
        //Quicksort. Sortati un vector folosind metoda QuickSort.

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
        static void QuickSort(int[] a, int left, int right)
        {
            if (left < right)
            {
                int P = Partitie(a, left, right);
                QuickSort(a, left, P);
                QuickSort(a, P + 1, right);
            }
        }

        static int Partitie(int[] a, int left, int right)
        {
            int v = a[left];
            left--;
            right++;
            while (left < right)
            {
                do
                {
                    right--;
                } while (left < right && a[right] > v);

                do
                {
                    left++;
                } while (left < right && a[left] < v);

                if (left < right)
                {
                    int aux = a[left];
                    a[left] = a[right];
                    a[right] = aux;
                }
            }
            return right;
        }
        static void Main(string[] args)
        {
            Console.Write("Lungimea vectorului: ");
            int n = Read();
            int[] a = new int[n];
            ReadArray(a);
            ViewArray(a);

            QuickSort(a, 0, a.Length - 1);
            ViewArray(a);
        }
    }
}
