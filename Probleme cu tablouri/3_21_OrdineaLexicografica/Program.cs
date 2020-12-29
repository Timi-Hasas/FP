using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_21_OrdineaLexicografica
{
    class Program
    {
        //Se dau doi vectori. Se cere sa se determine ordinea lor lexicografica 
        //(care ar trebui sa apara primul in dictionar).
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
                Console.Write($"a[{i}] = ");
                a[i] = Read();
            }
        }
        static void ViewArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                Console.Write($"{a[i]} ");
            Console.WriteLine();
        }
        static int[] Lexicografic(int[] a, int[] b)
        {
            if (a.Length < b.Length)
                return a;

            if (b.Length < a.Length)
                return b;

            for (int i = 0; i < a.Length; i++)
                if (a[i] > b[i])
                    return b;
                else
                    if (b[i] < a[i])
                    return a;

            return a;
        }
        static void Main(string[] args)
        {
            Console.Write("Lungimea primului vector: ");
            int n = Read();
            int[] a = new int[n];
            ReadArray(a);
            Console.Write("Lungimea celui de al doilea vector: ");
            int m = Read();
            int[] b = new int[m];
            ReadArray(b);
            ViewArray(b);
            Console.WriteLine($"Primul vector din dictionar este: ");
            ViewArray(Lexicografic(a, b));
        }
    }
}
