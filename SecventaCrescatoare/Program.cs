using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecventaCrescatoare
{
    class Program
    {
        //Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare. 
        static int Read()
        {
            int n = 0;
            bool isValid;
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
                };
            } while (!isValid);
            return n;
        }
        static bool Crescatoare(int n)
        {
            int number;
            int prevNumber;
            int i = 0;
            bool isCrescatoare = true;
            Console.Write($"Numarul {i + 1}: ");
            prevNumber = Read();
            for (i = 1; i < n; i++)
            {
                Console.Write($"Numarul {i + 1}: ");
                number = Read();
                if (prevNumber > number)
                    isCrescatoare =false;
                prevNumber = number;
            }
            return isCrescatoare;
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Lungimea secventei: ");
            n = Read();
            if(Crescatoare(n))
                Console.WriteLine("Secventa este crescatoare.");
            else
                Console.WriteLine("Secventa nu este crescatoare.");
        }
    }
}
