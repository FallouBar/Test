using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demostration
{
    class Program
    {
        static void Main(string[] args)
        {
         
    
            // premier test 2022
            int a = 1;
            int b = 2;
            int resultat = Addition(a, b);
            if (resultat != 3)
            {
                Console.WriteLine("Le test a raté");
            }
            else
            {
                Console.WriteLine("Le test est ok");
            }
            // second test
            a = 0;
            b = 0;
            resultat = Addition(a, b);
            if (resultat != 0)
            {
                Console.WriteLine("Le test a raté");
            }
            else
            {
                Console.WriteLine("Le test est ok");
            }
            // troisième test
            a = -5;
            b = 5;
            resultat = Addition(a, b);
            if (resultat != 0)
            {
                Console.WriteLine("Le test a raté");
            }
            else
            {
                Console.WriteLine("Le test est ok");
            }
        }
        public static int Addition(int a, int b)
        {
            return a + b;
        }
    }

}
