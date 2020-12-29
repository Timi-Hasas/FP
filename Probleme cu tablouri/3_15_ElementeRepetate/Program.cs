using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_15_ElementeRepetate
{
    class Program
    {
        //Modificati un vector prin eliminarea elementelor care se repeta, fara a folosi un alt vector.
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
        static void Delete(ref int[]a, int nr)
        {
            int[] temp = a;
            for (int i = nr; i < temp.Length - 1; i++)
                temp[i] = temp[i + 1];

            a = new int[temp.Length - 1];
            for (int i = 0; i < a.Length; i++)
                a[i] = temp[i];
        }
    
        static void Repeats(ref int[] a)
        {
            // bool repeat;
            for (int i = 0; i < a.Length - 1; i++)
                for (int j = i + 1; j < a.Length; j++)
                {
                    // repeat = false;
                    if (a[i] == a[j])
                    {
                        //repeat = true;
                        Delete(ref a, j);
                    }
                    //if (repeat)
                        //Delete(ref a, i);
                }
        }
        static void Main(string[] args)
        {
            Console.Write("Lungimea vectorului: ");
            int n = Read();
            int[] a = new int[n];
            ReadArray(a);
            ViewArray(a);
            Repeats(ref a);
            ViewArray(a);
        }
    }
}
