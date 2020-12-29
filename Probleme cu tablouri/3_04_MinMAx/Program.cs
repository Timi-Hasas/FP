using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_04_MinMAx
{
    class Program
    {
        //Deteminati printr-o singura parcurgere, 
        //cea mai mica si cea mai mare valoare dintr-un vector si de cate ori apar acestea. 
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

            int min = a[0];
            int max = a[0];
            int countMin = 1;
            int countMax = 1;

            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] == min)
                    countMin++;
                if (a[i] == max)
                    countMax++;
                if (a[i] < min)
                {
                    min = a[i];
                    countMin = 1;
                }               
                if (a[i] > max)
                {
                    max = a[i];
                    countMax = 1;
                }          
            }

            Console.WriteLine($"Minimul vectorului este {min} si apare de {countMin} ori.");
            Console.WriteLine($"Maximul vectorului este {max} si apare de {countMax} ori.");
        }
    }
}
