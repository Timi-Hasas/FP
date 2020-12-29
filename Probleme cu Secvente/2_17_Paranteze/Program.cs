using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_17_Paranteze
{
    class Program
    {
        //Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1 inseamna paranteza inchisa.
        //Determinati daca secventa reprezinta o secventa de paranteze corecta si,  daca este, determinati nivelul maxim de incuibare a parantezelor. 
        //De exemplu 0 1 0 0 1 0 1 1 este corecta si are nivelul maxim de incuibare 2 pe cand 0 0 1 1 1 0 este incorecta.       
        static void Main(string[] args)
        {
            Console.Write("Lungimea secventei: ");
            int n = int.Parse(Console.ReadLine());
            int bracket = 0;
            bool isValid = true;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number == 0)
                    bracket++;
                else
                    if (number == 1)
                    bracket--;

                if (bracket < 0)
                    isValid = false;
            }
            if (isValid)
                Console.WriteLine("Secventa de paranteze este corecta.");
            else
                Console.WriteLine("Secventa de paranteze nu este corecta.");
        }
    }
}
