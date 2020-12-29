using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Oglindit
{
    class Program
    {
        //Afisati in ordine inversa cifrele unui numar n.
        static int Oglindit(int n)
        {
            int oglindit = 0;
            while(n != 0)
            {
                oglindit = oglindit * 10 + n % 10;
                n = n / 10;
            }
            return oglindit;
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

            Console.WriteLine($"Oglinditul numarului {n} este {Oglindit(n)}.");
        }
    }
}
