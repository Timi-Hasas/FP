using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_02_PozitiaK
{
    class Program
    {
        //Se da un vector cu n elemente si o valoare k.
        //Se cere sa se determine prima pozitie din vector pe care apare k.
        //Daca k nu apare in vector rezultatul va fi -1. 
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
            Console.Write("Numarul cautat: ");
            int k = Read();
            bool found = false;
            for (int i = 0; i < a.Length; i++)
                if(a[i] == k && !found)
                {
                    Console.WriteLine($"Numarul {k} se afla pe pozitia {i}");
                    found = true;
                }
            if(!found)
            {
                Console.WriteLine(-1);
                Console.WriteLine($"Numarul {k} nu se afla in vector");
            }
        }
    }
}
