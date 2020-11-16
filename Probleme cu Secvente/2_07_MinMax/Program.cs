using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_07_MinMax
{
    class Program
    {
        //Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa. 
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
        static void Main(string[] args)
        {
            int n;
            Console.Write("Lungimea secventei: ");
            n = Read();
            int i = 0;
            Console.Write($"Numarul {i + 1}: ");
            int min = Read();
            int max = min;
            int number;
            for (i = 1; i < n; i++)
            {
                Console.Write($"Numarul {i + 1}: ");
                number = Read();
                if (number > max)
                    max = number;
                if (number < min)
                    min = number;
            }
            Console.WriteLine($"Cea mai mica valoare din secventa este {min} si cea mai mare este {max}");
        }
    }
}
