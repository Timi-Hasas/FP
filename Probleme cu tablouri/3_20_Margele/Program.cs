using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_20_Margele
{
    class Program
    {
        //Se dau doua siraguri de margele formate din margele albe si negre, notate s1, respectiv s2.
        //Determinati numarul de suprapuneri (margea cu margea) a unui sirag peste celalalt astfel incat margelele suprapuse au aceeasi culoare.
        //Siragurile de margele se pot roti atunci cand le suprapunem. 
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
        /*static int Suprapuneri(int[] a, int[] b)
        {
        // Work in progress...
        }*/
        static void Main(string[] args)
        {
            Console.Write("Lungimea primului vector: ");
            int n = Read();
            int[] a = new int[n];
            ReadArray(a);
            ViewArray(a);

            Console.Write("Lungimea celui de al doilea vector: ");
            int m = Read();
            int[] b = new int[m];
            ReadArray(b);
            ViewArray(b);
        }
    }
}
