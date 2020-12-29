using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_18_Polinom
{
    class Program
    {
        //Se da un polinom de grad n ai carui coeficienti sunt stocati intr-un vector. 
        //Cel mai putin semnificativ coeficient este pe pozitia zero in vector. 
        //Se cere valoarea polinomului intr-un punct x.
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
        static void ReadArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"Coeficient {i+1}: ");
                a[i] = Read();
            }
        }

        static void View(int[] a)
        {
            if (a[a.Length - 1] != 0)
                Console.Write($"{a[a.Length - 1]}*x^{a.Length}");
            for (int i = 1; i < a.Length; i++)
                if(a[a.Length - i - 1] != 0)
                Console.Write($" + {a[a.Length - i - 1]}*x^{a.Length - i}");

            Console.WriteLine();
        }
        static int Polinom(int[] a, int x)
        {
            int result = 0;
            for(int i = 0; i < a.Length; i++)
                result += a[i] * (int)Math.Pow(x,i+1);

            return result;
        }
        static void Main(string[] args)
        {
            Console.Write("Gradul polinomului: ");
            int n = Read();
            int[] a = new int[n];
            
            ReadArray(a);
            View(a);

            Console.Write("x = ");
            int x = Read();
            Console.WriteLine($"Result = {Polinom(a, x)}");
        }
    }
}
