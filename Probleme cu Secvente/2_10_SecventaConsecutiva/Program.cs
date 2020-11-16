using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_10_SecventaConsecutiva
{
    class Program
    {
        //Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa. 
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
            int n, number, prevNumber;
            int maxCount = 1;
            int count = 1;
            Console.WriteLine("Lungimea secventei: ");
            n = Read();
            int i = 0;
            Console.Write($"Numarul {i + 1}: ");
            prevNumber = Read();
            for (i = 1; i < n; i++)
            {
                Console.Write($"Numarul {i + 1}: ");
                number = Read();
                if (number == prevNumber + 1)
                    count++;
                else
                {
                    if (count > maxCount)
                        maxCount = count;
                    count = 1;
                }
                prevNumber = number;
            }

            if (count > maxCount)
                maxCount = count;

            Console.WriteLine($"Secventa cea mai mare de numere consecutive este de {maxCount} numere.");
        }
    }
}
