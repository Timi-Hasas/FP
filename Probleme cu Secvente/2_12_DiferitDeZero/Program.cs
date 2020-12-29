using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_12_DiferitDeZero
{
    class Program
    {
        //Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere.
        //Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte.
        //De ex. pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3. 
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
            Console.Write("Lungimea secventei: ");
            n = Read();
            int number = 0;
            int count = 0;
            Console.Write("Numarul 1: ");
            int prevNumber = Read();
            for (int i = 1; i < n; i++)
            {
                Console.Write($"Numarul {i + 1}: ");
                number = Read();
                if(number == 0 && prevNumber != 0)
                count++;
                prevNumber = number;
            }
            if(number != 0)
                count++;

            Console.WriteLine($"Grupurile secventei: {count}");
            
        }
    }
}
