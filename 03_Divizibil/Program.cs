using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divizibil
{
    class Program
    {
        //Determinati daca n se divide cu k, unde n si k sunt date de intrare. 
        static void Main(string[] args)
        {
            Console.WriteLine("Determinati daca n se divide cu k, unde n si k sunt date de intrare.");
            bool isValid = true;
            int n = 0, k = 0;
            do
            {
                try
                {
                    Console.Write("n= ");
                    n = int.Parse(Console.ReadLine());
                    do
                    {
                        Console.Write("k= ");
                        k = int.Parse(Console.ReadLine());
                    } while (k == 0);
                    isValid = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid");
                    isValid = false;
                }
            } while (!isValid);

            if(n % k == 0)
                Console.WriteLine($"{n} se divide cu {k}");
            else
                Console.WriteLine($"{n} nu se divide cu {k}");
                
        }
    }
}
