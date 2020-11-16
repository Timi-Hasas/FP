using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_01_NumerePare
{
    class Program
    {
        //Se da o secventa de n numere. Sa se determine cate din ele sunt pare. 
        static bool IsEven(int n)
        {
            if (n % 2 == 0)
                return true;
            else
                return false;
        }
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
            int count = 0;
            int n = 0;
            int number = 0;
            Console.Write("Lungimea secventei: ");
            n = Read();
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Numarul {i + 1}: ");
                number = Read();
                if (IsEven(number))
                    count++;
            }
            Console.WriteLine($"{count} numere sunt pare.");
        }
    }
}
