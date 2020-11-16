using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_14_RotitaMonoton
{
    class Program
    {
        //O <secventa monotona rotita> este o secventa de numere monotona sau poate fi transformata intr-o secventa montona prin rotiri succesive.
        //Determinati daca o secventa de n numere este o secventa monotona rotita. 
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
            bool descrescatoare = true;
            bool rotitaCresc = true;
            bool rotitaDesc = true;
            int i = 0;
            Console.Write($"Numarul {i + 1}: ");
            prevNumber = Read();
            int min = prevNumber;
            int max = prevNumber;
            for (i = 1; i < n; i++)
            {
                Console.Write($"Numarul {i + 1}: ");
                number = Read();

                if (!crescatoare && (prevNumber > number || min < number))
                    rotitaCresc = false;

                if (!descrescatoare && (prevNumber < number || max > number))
                    rotitaDesc = false;
                
                if (prevNumber > number)
                        crescatoare = false;

                if (prevNumber < number)
                        descrescatoare = false; 
                
                if (crescatoare && min > number)
                    min = number;

                if (descrescatoare && max < number)
                    max = number;

                prevNumber = number;
            }
                if (crescatoare || descrescatoare || rotitaCresc || rotitaDesc)
                    Console.WriteLine("Secventa este o secventa monotona rotita.");
                else
                    Console.WriteLine("Secventa nu este o secventa monotona rotita.");
            }
        }
    }

// 5 5 4 3 5 1
// 3 2 6 5 4