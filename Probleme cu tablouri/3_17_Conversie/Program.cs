using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_17_Conversie
{
    class Program
    {
        //Se da un numar n in baza 10 si un numar b. 1 < b < 17. 
        //Sa se converteasca si sa se afiseze numarul n in baza b.
        static int Read()
        {
            bool isValid;
            int n = 0;
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
                    Console.WriteLine("Invalid.");
                }
            } while (!isValid);
            return n;
        }
        static char Equivalent(int nr)
        {
            switch(nr)
            {
                case 10: return 'A';
                case 11: return 'B';
                case 12: return 'C';
                case 13: return 'D';
                case 14: return 'E';
                case 15: return 'F';
                default: return '0';
            }
        }

        static void Add(ref char[] converted, char n)
        {
            char[] temp = new char[converted.Length + 1];
            temp[0] = n;

            for (int i = 1; i < temp.Length; i++)
                temp[i] = converted[i - 1];

            converted = temp;
        }
        static char[] BaseConvert(int n, int b)
        {
            char[] converted = new char[0];
            int rest;
            while(n != 0)
            {
                rest = n % b;
                n = n / b;
                if (rest > 9)
                    Add(ref converted, Equivalent(rest));
                else
                    Add(ref converted, char.Parse(Convert.ToString(rest)));
            }

            return converted;
        }
        static void View(char[] a)
        {
            for(int i = 0; i < a.Length; i++)
                Console.Write(a[i]);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int b;
            Console.Write("Numarul: ");
            int n = Read();
            do
            {
                Console.Write("Baza: ");
                b = Read();
            } while (b <= 1 || b > 16);

            char[] converted = new char[0];
            converted = BaseConvert(n, b);

            View(converted);
        }
    }
}
