using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // matrici / tablouri bidimensiodali
            // multi-dimensional arrays
            int[,] matrix = new int[2, 2];
            matrix[0, 0] = 1;
            matrix[0, 1] = 1;
            matrix[1, 0] = 1;
            matrix[1, 1] = 1;

            int[,] matrix2 = new int[,]
            {
                {1, 2},
                {2, 3},
                {4, 5}
            };

            int numberOfElements = matrix.Length;
        }

        static void vectori()
        {

            // vectori aka arrays (unidimensional / single-dimensional)
            int[] numbers2 = new int[5];
            numbers2[0] = 1;
            numbers2[1] = 2;
            numbers2[2] = 3;
            numbers2[3] = 4;
            numbers2[4] = 5;

            int[] numbers3 = new int[] { 1, 2, 3, 4, 5 };
            int[] numbers1 = { 1, 2, 3, 4, 5 };

            int numberOfElements = numbers2.Length;
        }

        static void test1()
        {
            print("O aparut Cyberpunk 2077, dar ce s-a intamplat cu ");
            for (int i = 0; i < 5; i++)
            {
                switch (i)
                {
                    case 0:
                        print("Cyberpunk, ");
                        //break;
                        goto case 1;
                    case 1:
                        print("M-am cacat BAAA!");
                        break;
                    default:
                        Console.Write("Cyberpunk {0}, ", i);
                        break;
                }
            }
            println("DA");
        }

        static void print(string v)
        {
            Console.Write(v);
        }

        static void println(string v)
        {
            Console.WriteLine(v);
        }
    }
}
