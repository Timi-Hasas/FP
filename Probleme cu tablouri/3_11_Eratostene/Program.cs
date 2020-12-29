using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_11_Eratostene
{
    class Program
    {
        //Se da un numar natural n. 
        //Se cere sa se afiseze toate numerele prime mai mici sau egale cu n (ciurul lui Eratostene).
        static int[] Ciur(int n)
        {
            int nrPrime = 1;
            bool[] primes = new bool[n + 1];

            primes[0] = primes[1] = true;
            for (int j = 4; j <= n; j += 2)
            {
                primes[j] = true;
                nrPrime++;
            }
            for (int i = 3; i * i <= n; i += 2)
                if (!primes[i])
                    for (int j = i * i; j <= n; j += 2 * i)
                        if (primes[j] != true)
                        {
                            primes[j] = true;
                            nrPrime++;
                        }
            nrPrime = n - nrPrime;
            int[] ciur = new int[nrPrime];
            int k = 0;
            for(int i = 0; i <= n; i++)
                if (!primes[i])
                {
                    ciur[k] = i;
                    k++;
                }
            return ciur;
        }
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
        static void ViewArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                Console.Write($"{a[i]} ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = Read();
            int[] a = Ciur(n);
            ViewArray(a);
        }
    }
}
