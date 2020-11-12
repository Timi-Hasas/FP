using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Palindrom
{
    class Program
    {
        //Determianti daca un numar n este palindrom. 
        static int Oglindit(int n)
        {
            int oglindit = 0;
            while (n != 0)
            {
                oglindit = oglindit * 10 + n % 10;
                n = n / 10;
            }
            return oglindit;
        }
        static bool IsPalindrom(int n)
        {
            if (n == Oglindit(n))
                return true;
            else
                return false;
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

            if(IsPalindrom(n))
                Console.WriteLine($"Numarul {n} este palindrom");
            else
                Console.WriteLine($"Numarul {n} nu este palindrom");

        }
    }
}
