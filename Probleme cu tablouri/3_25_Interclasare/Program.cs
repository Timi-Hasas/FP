using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_25_Interclasare
{
    class Program
    {
        //(Interclasare) Se dau doi vector sortati crescator v1 si v2.
        //Construiti un al treilea vector ordonat crescator format din toate elementele din  v1 si v2.
        //Sunt permise elemente duplicate.
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

        static int[] Interclasare(int[] a, int[] b)
        {
            int[] result = new int[a.Length + b.Length];
            int i = 0, j = 0, k = 0;
            while(i < a.Length && j < b.Length)
            {
                if(a[i] <= b[j])
                {
                    result[k] = a[i];
                    i++;
                    k++;
                }
                else
                if(a[i] > b[j])
                {
                    result[k] = b[j];
                    j++;
                    k++;
                }
            }
            while (i < a.Length)
            {
                result[k] = a[i];
                i++;
                k++;
            }
            while (j < b.Length)
            {
                result[k] = b[j];
                j++;
                k++;
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.Write("Lungimea primului vector: ");
            int n = Read();
            int[] a = new int[n];
            ReadArray(a);
            ViewArray(a);

            Console.Write("Lungimea celui de al doilea vector: ");
            int m = Read();
            int[] b = new int[m];
            ReadArray(b);
            ViewArray(b);

            Console.WriteLine("Interclasarea: ");
            ViewArray(Interclasare(a, b));
        }
    }
}
