using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaInverselor
{
    class Program
    {
        //Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere. 
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
        static void Main(string[] args)
        {
            int n;
            int suma = 0;
            int number;
            Console.WriteLine("Lungimea secventei: ");
            n = Read();
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Numarul {i + 1}: ");
                number = Read();
                suma = suma + Oglindit(number);
            }
            Console.WriteLine($"Suma inverselor secventei este: {suma}");
        }
    }
}
