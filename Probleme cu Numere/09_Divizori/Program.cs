using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Divizori
{
    //Afisati toti divizorii numarului n. 
    class Program
    {
        static void Divizori(int n)
        {
            Console.WriteLine($"Divizorii numarului {n} sunt: ");
            Console.Write($"{1} ");
            for(int i = 2; i <= n/2; i++)
                if(n % i == 0)
                    Console.Write($"{i} ");
            Console.WriteLine($"{n}");
        }
        static void Main(string[] args)
        {
            Console.Write("Numar: ");
            int n = 0;
            bool isValid = true;
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
                }
            } while (!isValid);
            Divizori(n);
        }
    }
}
