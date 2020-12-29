using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_06_StergereElement
{
    class Program
    {
        //Se da un vector cu n elemente si o pozitie din vector k.
        //Se cere sa se stearga din vector elementul de pe pozitia k.
        //Prin stergerea unui element, toate elementele din dreapta lui se muta cu o pozitie spre stanga. 
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
        static void Delete(ref int[]a, int poz)
        {
            int[] temp = new int[a.Length - 1];
            for (int i = 0; i < poz; i++)
                temp[i] = a[i];
            for (int i = poz; i < temp.Length; i++)
            {
                a[i] = a[i + 1];
                temp[i] = a[i];
            }
            a = new int[temp.Length];
            for (int i = 0; i < a.Length; i++)
                a[i] = temp[i];         
        }
        static void Main(string[] args)
        {
            Console.Write("Lungimea vectorului: ");
            int n = Read();
            int[] a = new int[n];
            ReadArray(a);
            ViewArray(a);
            int k;
            do
            {
                Console.Write("Pozitia elemntului sters: ");
                k = Read();
                if (k < 0 || k >= a.Length)
                    Console.WriteLine("Pozitia nu exista in vector");
            } while (k < 0 || k >= a.Length);

            Delete(ref a, k);

            ViewArray(a);


        }
    }
}
