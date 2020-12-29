using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcuatiaDeGrad2
{
    class Program
    {
        //Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare.
        //Tratati toate cazurile posibile. 
        static void Main(string[] args)
        {
            bool isValid = true;
            float a = 0, b = 0, c = 0;

            Console.WriteLine("Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare.");
            Console.WriteLine("Tratati toate cazurile posibile");
            do
            {
                try
                {
                    Console.Write("a= ");
                    a = float.Parse(Console.ReadLine());
                    Console.Write("b= ");
                    b = float.Parse(Console.ReadLine());
                    Console.Write("c= ");
                    c = float.Parse(Console.ReadLine());

                    isValid = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid.");
                    isValid = false;
                }
            }
            while (!isValid);

            Console.WriteLine($"{a}x^2 + {b}x + {c} = 0");

            float x1, x2;
            float delta;

            if (a != 0)
            {
                delta = b * b - 4 * a * c;
                
                if(delta < 0)
                {
                    Console.WriteLine("Ecuatia nu are solutii reale.");
                }
                else
                {
                    if(delta == 0)
                    {
                        x1 = -(b / (2 * a));
                        x2 = x1;
                        Console.WriteLine($"Ecuatia are 2 solutii egale: {x1}");
                    }
                    else
                    {
                        x1 = -(b + (float)Math.Sqrt(delta)) / 4 * a;
                        x2 = -(b - (float)Math.Sqrt(delta)) / 4 * a;
                        Console.WriteLine($"Solutiile ecuatiei sunt {x1} si {x2}");
                    }
                }
            }
            else
            {
                if(b != 0)
                {
                    x1 = -(c / b);
                    Console.WriteLine("Ecuatia este de gradul 1.");
                    Console.WriteLine($"Solutia ecuatiei este: {x1}");
                }
                else
                {
                    if(c == 0)
                        Console.WriteLine("Solutie nedeterminata.");
                    else
                        Console.WriteLine("Ecuatia nu are solutie.");
                }
            }

        }
    }
}
