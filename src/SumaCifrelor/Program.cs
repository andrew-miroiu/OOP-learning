using System;

namespace SumaCifrelor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write a number: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("The sum of the digits of {0} is equal to: {1} ", n, sumOfDigits(n));
        }

        static int sumOfDigits(int n)
        {
            int sum = 0;

            while(n!=0)
            {
                sum += (n % 10);
                n /= 10;
            }

            return sum;
        }
    }
}
