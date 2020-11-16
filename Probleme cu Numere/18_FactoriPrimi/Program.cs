using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace _18_FactoriPrimi
{
    class Program
    {
        //Afisati descompunerea in factori primi ai unui numar n.  De ex. pentru n = 1776 afisati 2^3 x 3^1 x 7^2. (exemplu gresit, descompunerea e pentru n = 1176)
        static bool IsPrim(int n)
        {
            if (n <= 1)
                return false;
            if (n == 2)
                return true;
            if (n % 2 == 0)
                return false;
            for (int i = 3; i * i <= n; i += 2)
                if (n % i == 0)
                    return false;
            return true;
        }
        static void Factori(int n)
        {
            if(IsPrim(n))
                Console.WriteLine("Numarul este prim.");
            else
            {
                bool first = true;
                for(int i = 2; i <= n; i++)
                {
                    int putere = 0;
                    if (IsPrim(i) && n % i == 0)
                    {
                        do
                        {
                            putere++;
                            n = n / i;
                        } while (n % i == 0);
                        if (first)
                        {
                            Console.Write($"{i}^{putere}");
                            first = false;
                        }
                        else
                            Console.Write($" x {i}^{putere}");
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Numar: ");
            int n = 0;
            bool isValid = true;
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
                    Console.WriteLine("Invalid");
                }
            } while (!isValid);

            Factori(n);
            Console.WriteLine();
        }
    }
}
