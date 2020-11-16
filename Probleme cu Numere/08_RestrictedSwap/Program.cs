using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_RestrictedSwap
{
    class Program
    {
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

            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");

        }
    }
}
