using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Interschimbare
{
    class Program
    {
        //(Swap) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor. 
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

            int aux = a;
            a = b;
            b = aux;

            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
        }
    }
}
