using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_NumereCrescatoare
{
    class Program
    {
        //Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri)

        static void Swap(ref int a, ref int b)
        {
            int aux = a;
            a = b;
            b = aux;
        }
        static void Crescator(int a, int b, int c, int d, int e)
        {
            if (a > b) Swap(ref a, ref b);
            
            if (a > c) Swap(ref a, ref c);

            if (a > d) Swap(ref a, ref d);

            if (a > e) Swap(ref a, ref e);

            if (b > c) Swap(ref b, ref c);
            
            if (b > d) Swap(ref b, ref d);

            if (b > e) Swap(ref b, ref e);

            if (c > d) Swap(ref c, ref d);

            if (c > e) Swap(ref c, ref e);

            if (d > e) Swap(ref d, ref e);

            Console.WriteLine($"{a} {b} {c} {d} {e}");
        }
        static void Main(string[] args)
        {
            int a = 0, b = 0, c = 0, d = 0, e = 0;
            bool isValid = true;
            do
            {
                try
                {
                    Console.Write("a= ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("b= ");
                    b = int.Parse(Console.ReadLine());                 
                    Console.Write("c= ");
                    c = int.Parse(Console.ReadLine());
                    Console.Write("d= ");
                    d = int.Parse(Console.ReadLine());
                    Console.Write("e= ");
                    e = int.Parse(Console.ReadLine());
                    isValid = true;
                }
                catch (Exception)
                {
                    isValid = false;
                    Console.WriteLine("Invalid");
                }
            } while (!isValid);

            Crescator(a, b, c, d, e);
        }
    }
}
