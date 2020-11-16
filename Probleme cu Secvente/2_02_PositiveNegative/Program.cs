using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_02_PositiveNegative
{
    class Program
    {
        //Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive. 
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
            int zero = 0, positive = 0, negative = 0;
            int n = 0;
            int number = 0;
            Console.Write("Lungimea secventei: ");
            n = Read();

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Numarul {i + 1}: ");
                number = Read();
                if (number < 0) 
                    negative++;
                else
                    if (number == 0) 
                    zero++;
                else
                    if (number > 0) 
                    positive++;
            }
            Console.WriteLine($"Secventa contine {positive} numere pozitive, {negative} numere negative si {zero} zero");
        }
    }
}
