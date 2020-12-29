using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_31_ElementMajoritate
{
    class Program
    {
        //(Element majoritate). 
        //Intr-un vector cu n elemente, un element m este element majoritate daca mai mult de n/2 din 
        //valorile vectorului sunt egale cu m (prin urmare, daca un vector are element majoritate acesta 
        //este unui singur).  Sa se determine elementul majoritate al unui vector 
        //(daca nu exista atunci se va afisa <nu exista>). 
        //(incercati sa gasiti o solutie liniara). 
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
        static int maxValue = 0;
        static void ReadArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"a[{i}] = ");
                a[i] = Read();
                if (maxValue < a[i])
                    maxValue = a[i];
            }
        }
        static void ViewArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                Console.Write($"{a[i]} ");
            Console.WriteLine();
        }

        static void Majoritate(int[] a)
        {
            int[] freq = new int[maxValue + 1];
            int half = a.Length / 2;
            bool found = false;
            int majoritate = 0;
            for (int i = 0; i < a.Length; i++)
            {
                freq[a[i]]++;
                if (!found && freq[a[i]] > half)
                {
                    found = true;
                    majoritate = a[i];
                }
            }
            if(found)
                Console.WriteLine($"Elementul majoritate este {majoritate}");
            else
                Console.WriteLine("Nu exista.");
        }
        static void Main(string[] args)
        {
            Console.Write("Lungimea vectorului: ");
            int n = Read();
            int[] a = new int[n];
            ReadArray(a);
            ViewArray(a);

            Majoritate(a);
        }
    }
}
