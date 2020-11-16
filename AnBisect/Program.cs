using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnBisect
{
    class Program
    {
        //Detreminati daca un an y este an bisect. 
        static bool IsBisect(int an)
        {
            if ((an % 4 == 0) && (an % 100 != 0))
                return true;

            if (an % 400 == 0)
                return true;

            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Anul: ");
            int an = 0;
            bool isValid = true;
            do
            {
                try
                {
                    an = int.Parse(Console.ReadLine());
                    isValid = true;
                }
                catch (Exception)
                {
                    isValid = false;
                    Console.WriteLine("Invalid");
                }
            } while (!isValid);

            if (IsBisect(an))
                Console.WriteLine($"Anul {an} este bisect.");
            else
                Console.WriteLine($"Anul {an} nu este bisect.");
        }
    }
}
