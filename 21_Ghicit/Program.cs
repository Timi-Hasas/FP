using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Ghicit
{
    class Program
    {
        //Ghiciti un numar intre 1 si 1024 prin intrebari de forma "numarul este mai mare sau egal decat x?". 
        static (bool, bool) Compare(int compr, int number, int randomNumber)
        {
            switch(compr)
            {
                case 0: if (number == randomNumber)
                        return (true, true);
                    else
                        return (false, false);
                case 1: if (randomNumber < number)
                        return (true, false);
                    else
                        return (false, false);
                case 2: if (randomNumber > number)
                        return (true, false);
                    else
                        return (false, false);
                case 3: if (randomNumber <= number)
                        return (true, false);
                    else
                        return (false, false);
                case 4: if (randomNumber >= number)
                        return (true, false);
                    else
                        return (false, false);
                default:
                    return (false, false);
            }
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 1025);
            int n = 0;
            int compare = 0;
            bool isValid;
            //Console.WriteLine(randomNumber);
            do
            {
                do
                {
                    try
                    {
                        Console.WriteLine();
                        Console.WriteLine("Cititi un numar de la tastatura");
                        Console.WriteLine();
                        n = int.Parse(Console.ReadLine());
                        isValid = true;
                    }
                    catch (Exception)
                    {
                        isValid = false;
                        Console.WriteLine("Invalid");
                    }
                } while (!isValid);

                Console.WriteLine();
                Console.WriteLine("Numarul generat este: ");
                Console.WriteLine($"0. egal decat {n}: ");
                Console.WriteLine($"1. mai mic decat {n}");
                Console.WriteLine($"2. mai mare decat {n}");
                Console.WriteLine($"3. mai mic sau egal cu {n}");
                Console.WriteLine($"4. mai mare sau egal cu {n}");
                Console.WriteLine();

                do
                {
                    try
                    {
                        do
                        {
                            compare = int.Parse(Console.ReadLine());
                        } while (compare < 0 && compare > 4);
                        isValid = true;
                    }
                    catch (Exception)
                    {
                        isValid = false;
                        Console.WriteLine("Invalid");
                    }
                } while (!isValid);

                if (Compare(compare, n, randomNumber) == (true, false))
                    Console.WriteLine("Adevarat.");
                else
                    if (Compare(compare, n, randomNumber) == (false, false))
                    Console.WriteLine("Fals."); 
            } while (Compare(compare, n, randomNumber) != (true, true));

            Console.WriteLine($"Ai ghicit! Numarul era {randomNumber} !!!");
            Console.WriteLine();
        }
    }
}
