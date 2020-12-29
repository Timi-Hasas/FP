using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_16_DivizorComun
{
    class Program
    {
        //Se da un vector de n numere naturale.
        //Determinati cel mai mare divizor comun al elementelor vectorului.
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
        static int Cmmdc(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }
            return a;
        }

        static int CmmdcArray(int[] a)
        {
            int divizorComun = Cmmdc(a[0], a[1]);
            for (int i = 2; i < a.Length; i++)
                divizorComun = Cmmdc(a[i], divizorComun);

            return divizorComun;
        }
        static void Main(string[] args)
        {
            Console.Write("Lungimea vectorului: ");
            int n = Read();
            int[] a = new int[n];
            ReadArray(a);
            ViewArray(a);
            Console.Write("Cel mai mic divizor comun al vectorului este: ");
            Console.WriteLine(CmmdcArray(a));
        }
    }
}
