using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_16_BitonicaMonotona
{
    class Program
    {
        //O <secventa bitonica rotita> este o secventa bitonica sau una ca poate fi transformata intr-o secventa bitonica prin rotiri succesive
        //(rotire = primul element devine ultimul).
        //Se da o secventa de n numere.
        //Se cere sa se determine daca este o secventa bitonica rotita. 
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
            bool desc = true;
            bool bitonicaCresc = true;
            bool bitonicaDesc = true;
            bool bitonica = true;
            int i = 0;
            Console.Write($"Numarul {i + 1}: ");
            prevNumber = Read();
            int max = prevNumber;
            for (i = 1; i < n; i++)
            {
                Console.Write($"Numarul {i + 1}: ");
                number = Read();

                if (!cresc && (prevNumber < number || i == 1))
                    bitonicaCresc = false;

                if (!desc && (prevNumber > number))
                    bitonicaDesc = false;

                if (!bitonicaDesc && ((prevNumber < number) || (max > number)))
                    bitonica = false;

                if (prevNumber > number && cresc)
                    cresc = false;

                if (prevNumber < number && !cresc)
                    desc = false;

                if (desc && max < number)
                    max = number;

                prevNumber = number;
            }
            if ((bitonicaCresc || bitonicaDesc || bitonica))
                Console.WriteLine("Secventa este bitonica rotita");
            else
                Console.WriteLine("Secventa nu este bitonica rotita.");
        }
    }
}
