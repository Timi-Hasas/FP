using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_19_NumarAparitii
{
    class Program
    {
        //Se da un vector s (vectorul in care se cauta) si un vector p (vectorul care se cauta).
        //Determinati de cate ori apare p in s.
        //De ex. Daca s = [1,2,1,2,1,3,1,2,1] si p = [1,2,1] atunci p apare in s de 3 ori.
        //(Problema este dificila doar daca o rezolvati cu un algoritm liniar). 
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
        static int Search(int[]p, int[]s)
        {
            int found = 0;
            int j = 0;
            for(int i = 0; i < s.Length; i++)
            {
                if (s[i] == p[j])
                    j++;
                else
                    j = 0;
                if (j == p.Length - 1)
                {
                    found++;
                    j = 0;
                }
            }
            return found;
        }
        static void Main(string[] args)
        {
            Console.Write("Lungimea vectorului s: ");
            int n = Read();
            int[] s = new int[n];
            ReadArray(s);
            ViewArray(s);

            Console.Write("Lungimea vectorului p: ");
            int m = Read();
            int[] p = new int[m];
            ReadArray(p);
            ViewArray(p);

            int nrAparitii = Search(p, s);
            Console.WriteLine($"Numarul de aparitii a sirului p in sirul este este: {nrAparitii}");
        }
    }
}
