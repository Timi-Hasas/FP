using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_NumarDouaCifre
{
    class Program
    {
        //Determinati daca un numar e format doar cu 2 cifre care se pot repeta.
        //De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt. 
        static bool IsTwoDigits(int n)
        {
            int firstDigit = n % 10;
            int secondDigit = -1;
            n /= 10;
            while (n != 0)
            {
                if (n % 10 != firstDigit && secondDigit == -1)
                    secondDigit = n % 10;
                
                if (n % 10 != firstDigit && n % 10 != secondDigit && secondDigit != -1) 
                    return false;

                n /= 10;
            }
            if (secondDigit == -1)
                return false;
            else
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

            if(IsTwoDigits(n))
                Console.WriteLine($"Numarul {n} este format din 2 cifre.");
            else
                Console.WriteLine($"Numarum {n} nu este format din 2 cifre.");
        }
    }
}
