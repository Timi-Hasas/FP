using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_NumarPrim
{
    class Program
    {
        //Test de primalitate: determinati daca un numar n este prim.
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

            if(IsPrim(n))
                Console.WriteLine($"Numarul {n} este prim.");
            else
                Console.WriteLine($"Numarul {n} nu este prim.");
        }
    }
}
