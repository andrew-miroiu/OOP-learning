using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type in THE CHOSEN NUMBER: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("The sum of the first {0} numbers is: {1}", number, sumGauss(number));
        }

        static int sumGauss(int n)
        {
            int sum = 0;

            for(int i=0; i<=n; i++)
            {
                sum = sum + i;
            }

            return sum;
        }
    }
}
