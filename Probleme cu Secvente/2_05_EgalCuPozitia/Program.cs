using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_05_EgalCuPozitia
{
    class Program
    {
        //Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa. 
        //Se considera ca primul element din secventa este pe pozitia 0.
        static int Read()
        {
            int n = 0;
            bool isValid;
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
                };
            } while (!isValid);
            return n;
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Lungimea secventei: ");
            n = Read();
            int poz = 0;
            int number;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Numarul {i + 1}: ");
                number = Read();
                if (number == poz)
                    count++;
                poz++;
            }
            Console.WriteLine($"{count} elemente din secventa sunt egale cu pozitiile lor");
        }
    }
}
