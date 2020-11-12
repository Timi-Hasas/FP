using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Euclid
{
    class Program
    {
        // Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. Folositi algoritmul lui Euclid. 
        static int Cmmdc(int a, int b)
        {
            while(a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }
            return a;
        }

        static int Cmmmc(int m, int n)
        {
            int a = m;
            int b = n;
            while (a != b)
            {
                if (a < b)
                    a += m;
                else
                    b += n;
            }
            return a;
        }
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            bool isValid = true;

            do
            {
                try
                {
                    Console.Write("a= ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("b= ");
                    b = int.Parse(Console.ReadLine());
                    isValid = true;
                }
                catch (Exception)
                {
                    isValid = false;
                    Console.WriteLine("Invalid");
                }
            } while (!isValid);
            Console.WriteLine($"Cel mai mic divizor comun a numerelor {a} si {b} este: {Cmmdc(a, b)}");
            Console.WriteLine($"Cel mai mare multiplu comun a numerelor {a} si {b} este: {Cmmmc(a, b)}");
        }
    }
}
