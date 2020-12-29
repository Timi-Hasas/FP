using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EcuatiaDeGrad1
{
    class Program
    {
        //Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare. 
        static void Main(string[] args)
        {
            bool isValid = true;
            float a = 0, b = 0;

            do
            {
                try
                {
                    Console.Write("a= ");
                    a = float.Parse(Console.ReadLine());
                    Console.Write("b= ");
                    b = float.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    isValid = false;
                    Console.WriteLine("Invalid.");
                }
            } while (!isValid);


            float x;
            Console.WriteLine($"{a}x+{b}=0");
            

            if (a != 0)
            {
                x = -(b / a);
                Console.WriteLine($"Solutia este: {x}");
            }
            else
            {
                if(b == 0)
                Console.WriteLine("Solutie nedeterminata.");
                else
                    Console.WriteLine("Ecuatia nu are solutie.");
              
            }
        }
    }
}
