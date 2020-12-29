using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_01_SumaVector
{
    class Program
    {
        //Calculati suma elementelor unui vector de n numere citite de la tastatura. Rezultatul se va afisa pe ecran.
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
        static void Main(string[] args)
        {
            Console.Write("Lungimea vectorului: ");
            int n = Read();
            int[] a = new int[n];
            ReadArray(a);
            ViewArray(a);

            int suma = 0;
            for (int i = 0; i < a.Length; i++)
                suma = suma + a[i];

            Console.WriteLine($"Suma elementelor vectorului este {suma}");
        }
    }
}
