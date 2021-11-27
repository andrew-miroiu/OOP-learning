using System;

namespace cmmmc_patrat_perfect
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Scrie un numar: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Cel mai mic multiplu comun care sa fie si patrat perfect al numarului {0} este {1}",n, cmmmc(n));
        }

        static int cmmmc(int n)
        {
            int theChosenOne = 0;
            for(int i = n + n; i <= Math.Pow(n, 5); i = i + n)
            {
                for(int j = 1; j <= i / 2; j++)
                {
                    if(j * j == i)
                    {
                        theChosenOne = i;
                        break;
                    }
                }

                if(theChosenOne != 0)
                {
                    break;
                }
            }

            return theChosenOne;
        }
    }
}
