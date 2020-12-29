using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_03_PozitiiMinimMaxim
{
    class Program
    {
        //Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al vectorului.
        //Pentru extra-credit realizati programul efectuand 3n/2 comparatii (in cel mai rau caz). 
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

            int min, max;
            min = a[0];
            max = a[0];
            int pozMin = 0, pozMax = 0;
            for (int i = 1; i < n; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                    pozMin = i;
                }
                else
                    if (a[i] > max)
                {
                    max = a[i];
                    pozMax = i;
                }
            }
            Console.WriteLine($"Minimul se afla pe pozitia {pozMin}");
            Console.WriteLine($"Maximul se afla pe pozitia {pozMax}");
        }
    }
}
