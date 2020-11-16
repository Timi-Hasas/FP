using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_NumereCrescatoare
{
    class Program
    {
        //Se dau 3 numere. Sa se afiseze in ordine crescatoare. 
        static void Crescator(int a, int b, int c)
        {
            if (a >= b && b >= c)
                Console.WriteLine($"{a} {b} {c}");
            else
                if(a >= c && c >= b)
                Console.WriteLine($"{a} {c} {b}");
            else
                if(b >= a && a >= c)
                Console.WriteLine($"{b} {a} {c}");
            else
                if(b >= c && c >= a)
                Console.WriteLine($"{b} {c} {a}");
            else
                if(c >= a && a >= b)
                Console.WriteLine($"{c} {a} {b}");
            else
                if(c >= b && b >= a)
                Console.WriteLine($"{c} {b} {a}");
        }
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            bool isValid = true;
            do
            {
                try
                {
                    Console.Write("a= ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("b= ");
                    b = int.Parse(Console.ReadLine());
                    Console.Write("c= ");
                    c = int.Parse(Console.ReadLine());
                    isValid = true;
                }
                catch (Exception)
                {
                    isValid = false;
                    Console.WriteLine("Invalid");
                }
            } while (!isValid);
            Crescator(a, b, c);
        }
    }
}
