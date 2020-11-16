using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_15_Bitonica
{
    class Program
    {
        //O secventa bitonica este o secventa de numere care incepe monoton crescator si continua monoton descrecator.
        //De ex. 1,2,2,3,5,4,4,3 este o secventa bitonica. Se da o secventa de n numere. 
        //Sa se determine daca este bitonica. 
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
            int number, prevNumber;
            bool cresc = true;
            bool bitonica = true;
            int i = 0;
            Console.Write($"Numarul {i + 1}: ");
            prevNumber = Read();
            for (i = 1; i < n; i++)
            {
                Console.Write($"Numarul {i + 1}: ");
                number = Read();

                if (prevNumber > number && cresc)
                    cresc = false;

                if (!cresc && (prevNumber < number || i==1))
                    bitonica = false;

                prevNumber = number;
            }
            if(bitonica && !cresc)
                Console.WriteLine("Secventa este bitonica");
            else
                Console.WriteLine("Secventa nu este bitonica.");

        }
    }
    
}
