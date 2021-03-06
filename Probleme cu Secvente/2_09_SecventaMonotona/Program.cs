﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_09_SecventaMonotona
{
    //Sa se determine daca o secventa de n numere este monotona. 
    //Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare.
    class Program
    {
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
            int n, number, prevNumber;
            bool crescatoare = true;
            bool descrescatoare = true;
            n = Read();
            int i = 0;
            Console.Write($"Numarul {i + 1}: ");
            prevNumber = Read();
            for (i = 1; i < n; i++)
            {
                Console.Write($"Numarul {i + 1}: ");
                number = Read();
                if (prevNumber > number)
                    crescatoare = false;
                if (prevNumber < number)
                    descrescatoare = false;
                prevNumber = number;
            }
            if(crescatoare || descrescatoare)
                Console.WriteLine("Sirul este monoton.");
            else
                Console.WriteLine("Sirul nu este monoton.");
        }
    }
}
