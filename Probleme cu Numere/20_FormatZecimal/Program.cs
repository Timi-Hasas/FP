using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_FormatZecimal
{
    class Program
    {
        //Afisati fractia m/n in format zecimal, cu perioada intre paranteze (daca e cazul). Exemplu: 13/30 = 0.4(3). 
        public static float fractionToDecimal(int numr, int denr)
        {      
            float result = (float)numr / denr;
            return result;
        }

        public static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            bool isValid = true;
            do
            {
                try
                {
                    Console.Write("a= ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("b= ");
                    b = int.Parse(Console.ReadLine());
                    isValid = true;
                }
                catch (Exception)
                {
                    isValid = false;
                    Console.WriteLine("Invalid");
                }
            } while (!isValid);
            Console.WriteLine($"{a}/{b} este egal cu {fractionToDecimal(a,b)}");
        }
    }
}
