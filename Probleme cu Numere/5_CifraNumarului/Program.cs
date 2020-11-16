using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CifraNumarului
{
    class Program
    {
        //Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga. 
        static int Cifra(int n, int k)
        {
            for (int i = 1; i < k; i++)
                n = n / 10;

            int cifra = n % 10;

            return cifra;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Extrageti si afisati a k-a cifra de la sfarsitul unui numar.");
            Console.WriteLine("Cifrele se numara de la dreapta la stanga.");

            int n = 0, k = 0;
            bool isValid = true;

            do
            {
                try
                {
                    Console.Write("Numarul: ");
                    n = int.Parse(Console.ReadLine());
                    Console.Write("Numarul cifrei extrase: ");
                    do
                    {
                        k = int.Parse(Console.ReadLine());
                    } while (k > n.ToString().Length);
                    isValid = true;
                }
                catch (Exception)
                {
                    isValid = false;
                    Console.WriteLine("Invalid");
                }
            } while (!isValid);

            Console.WriteLine($"Cifra {k} a numarului este: {Cifra(n,k)}");
        }
    }
}
