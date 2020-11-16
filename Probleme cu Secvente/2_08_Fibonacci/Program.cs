using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_08_Fibonacci
{
    //Determianti al n-lea numar din sirul lui Fibonacci.
    //Sirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2).
    //Exemplu: 0, 1, 1, 2, 3, 5, 8 ...
    class Program
    {
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
        static int Fibonacci(int n)
        {
            if(n == 1)
                return 0;
            if (n == 2)
                return 1;
            return Fibonacci((n - 1)) + Fibonacci(n - 2);
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Numarul din sirul lui fibonacci: ");
            n = Read();
            Console.WriteLine($"Numarul {n} din sirul lui Fibonacci este: {Fibonacci(n)}");

        }
    }
}
