using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_AniBisecti
{
    //Determianti cati ani bisecti sunt intre anii y1 si y2.
    class Program
    {
        static bool IsBisect(int an)
        {
            if ((an % 4 == 0) && (an % 100 != 0))
                return true;

            if (an % 400 == 0)
                return true;

            return false;
        }
        static int AniBisecti(int an1, int an2)
        {
            int numarAni = 0;

            for (int i = an1; i <= an2; i++)
                if (IsBisect(i))
                    numarAni++;

            return numarAni;
        }
        static void Main(string[] args)
        {
            int an1 = 0;
            int an2 = 0;
            bool isValid = true;
            do
            {
                try
                {
                    Console.Write("Primul an: ");
                    an1 = int.Parse(Console.ReadLine());
                    Console.Write("Al doilea an: ");
                    an2 = int.Parse(Console.ReadLine());
                    isValid = true;
                }
                catch (Exception)
                {
                    isValid = false;
                    Console.WriteLine("Invalid");
                }
            } while (!isValid);

            if(an1 > an2)
            {
                int aux = an1;
                an1 = an2;
                an2 = aux;
            }

            Console.WriteLine($"Intre anii {an1} si {an2} sunt {AniBisecti(an1, an2)} ani bisecti");
        }
    }
}
