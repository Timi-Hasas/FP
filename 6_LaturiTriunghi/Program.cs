using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_LaturiTriunghi
{
    class Program
    {
        //Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi. 
        static bool isTriangle(int a, int b, int c)
        {
            if (a < 0 || b < 0 || c < 0 || a + b < c || a + c < b || b + c < a)
                return false;
            else
                return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi. ");
            int a = 0, b = 0, c = 0;
            bool isValid;

            do
            {
                try
                {
                    Console.Write("Prima latura: ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("A doua latura: ");
                    b = int.Parse(Console.ReadLine());
                    Console.Write("A treia latura: ");
                    c = int.Parse(Console.ReadLine());
                    isValid = true;
                }
                catch (Exception)
                {
                    isValid = false;
                    Console.WriteLine("Invalid");
                }        
            } while (!isValid);

            if(isTriangle(a, b, c))
                Console.WriteLine("Laturile pot forma triunghi.");
            else
                Console.WriteLine("Laturile nu pot forma triunghi.");
        }
    }
}
