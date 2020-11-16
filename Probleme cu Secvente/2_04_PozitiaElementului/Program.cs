using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_04_PozitiaElementului
{
    class Program
    {
        //Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numara a. 
        //Se considera ca primul element din secventa este pe pozitia zero. 
        //Daca numarul nu se afla in secventa raspunsul va fi -1. 
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
            int n = 0;
            int number = 0;
            int a = 0;
            int poz = -1;
            int savedPoz = -1;
            Console.WriteLine("Numarul cautat: ");
            a = Read();
            Console.Write("Lungimea secventei: ");
            n = Read();
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Numarul {i + 1}: ");
                number = Read();
                poz++;
                if (number == a)
                    savedPoz = poz;
            }
            Console.WriteLine($"Pozitia numarului este: {savedPoz}");
        }
    }
}
