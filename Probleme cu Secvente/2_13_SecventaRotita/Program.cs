using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_13_SecventaRotita
{
    class Program
    {
        //O <secventa crescatoare rotita> este o secventa de numere care este in ordine crescatoare
        //sau poate fi transformata intr-o secventa in ordine crescatoare prin rotiri succesive 
        //(rotire = primul element devine ultimul).
        //Determinati daca o secventa de n numere este o secventa crescatoare rotita. 
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
            bool crescatoare = true;
            bool rotita = true;
            int i = 0;
            Console.Write($"Numarul {i + 1}: ");
            prevNumber = Read();
            int min = prevNumber;
            for (i = 1; i < n; i++)
            {
                Console.Write($"Numarul {i + 1}: ");
                number = Read();

                if (!crescatoare && (prevNumber > number || min < number))
                    rotita = false;

                if (prevNumber > number)
                    crescatoare = false;

                if (crescatoare && min > number)
                    min = number;

                prevNumber = number;
            }
            if(crescatoare || rotita)
            Console.WriteLine("Secventa este o secventa crescatoare rotita.");
            else
                Console.WriteLine("Secventa nu este o secventa crescatoare rotita.");
        }
    }
}
