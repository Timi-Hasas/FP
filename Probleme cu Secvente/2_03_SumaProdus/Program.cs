using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_03_SumaProdus
{
    class Program
    {
        //Calculati suma si produsul numerelor de la 1 la n. 
        static void Main(string[] args)
        {
            int suma = 0, produs = 1;
            int n = 0;
            bool isValid;
            do
            {
                try
                {
                    Console.Write("n= ");
                    n = int.Parse(Console.ReadLine());
                    isValid = true;
                }
                catch (Exception)
                {
                    isValid = false;
                    Console.WriteLine("Invalid");
                };
            } while (!isValid || n <= 0);
            for (int i = 1; i <= n; i++)
            {
                produs = produs * i;
                suma = suma + i;
            }
            Console.WriteLine($"Suma numerelor de la 1 la {n} este: {suma}");
            Console.WriteLine($"Produsul numerelor de la 1 la {n} este: {produs}");
        }
    }
}
