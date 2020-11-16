using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_IntervalDivizibil
{
    class Program
    {
        //Determinati cate numere integi divizibile cu n se afla in intervalul [a, b].
        static void NumereDivizibile(int a, int b, int n)
        {
            for (int i = a; i <= b; i++)
                if(i % n == 0)
                    Console.Write($"{i} ");
        }
        static void Main(string[] args)
        {
            
            int n = 0;
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
                    Console.Write("n= ");
                    n = int.Parse(Console.ReadLine());
                    isValid = true;
                }
                catch (Exception)
                {
                    isValid = false;
                    Console.WriteLine("Invalid");
                }
            } while (!isValid);

            if (a > b)
            {
                int aux = a;
                a = b;
                b = aux;
            }

            NumereDivizibile(a, b, n);
        }
    }
}
