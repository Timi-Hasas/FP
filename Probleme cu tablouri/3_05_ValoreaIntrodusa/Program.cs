using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_05_ValoreaIntrodusa
{
    class Program
    {
        //Se da un vector cu n elemente, o valoare e si o pozitie din vector k. 
        //Se cere sa se insereze valoarea e in vector pe pozitia k. 
        //Primul element al vectorului se considera pe pozitia zero.
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

            Console.Write("Elementul inserat: ");
            int e = Read();       
            int k;
            do
            {
                Console.Write("Pozitia elemntului inserat: ");
                k = Read(); 
                if(k < 0 || k >= a.Length)
                    Console.WriteLine("Pozitia nu exista in vector");
            } while (k < 0 || k >= a.Length);

            a[k] = e;

            ViewArray(a);

        }
    }
}
