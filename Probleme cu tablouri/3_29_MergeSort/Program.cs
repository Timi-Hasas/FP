using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_29_MergeSort
{
    class Program
    {
        //MergeSort. Sortati un vector folosind metoda MergeSort.
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
        static void MergeSort(int[] a, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                MergeSort(a, left, mid);
                MergeSort(a, mid + 1, right);
                Interclasare(a, left, mid, right);
            }
        }
        static void Interclasare(int[] a, int left, int mid, int right)
        {
            int[] b = new int[right - left + 1];
            int i = left, j = mid + 1, k = 0;
            while (i <= mid && j <= right)
            {
                if (a[i] <= a[j])
                {
                    b[k] = a[i];
                    k++;
                    i++;
                }
                else
                {
                    b[k] = a[j];
                    k++;
                    j++;
                }
            }
            while (i <= mid)
            {
                b[k] = a[i];
                k++;
                i++;
            }
            while (j <= right)
            {
                b[k] = a[j];
                k++;
                j++;
            }
            for (i = 0; i < k; i++)
                a[left + i] = b[i];
        }
        static void Main(string[] args)
        {
            Console.Write("Lungimea vectorului: ");
            int n = Read();
            int[] a = new int[n];
            ReadArray(a);
            ViewArray(a);

            MergeSort(a, 0, a.Length - 1);
            ViewArray(a);
        }
    }
}
