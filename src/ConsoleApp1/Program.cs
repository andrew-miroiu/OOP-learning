using System;

namespace consoleApp_1
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Media aritmetica: {0} ", average(10.5f, 219.7f));
        }

        static double average(float leftNum, float rightNum)
        {
            return (leftNum + rightNum) / 2.0f;
        }

        static void test2()
        {
            Console.WriteLine("Write a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Write b: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Suma: " + sumOfNumbers(a, b));
            Console.WriteLine("a = {0} & b = {1}", a, b);

            // pentru a transmite prin referinta parametrii si aici folosim "ref" deoarece functia foloseste parametrii transmisi prin referinta 
            Console.WriteLine("Diferenta: {0} ", difference(ref a, ref b));
            Console.WriteLine("a = {0} & b = {1}", a, b);
        }

        // parametrii sunt transmisis prin referinta
        // keyword-ul prin care specificam ca un parametru e transmis prin referinta este "ref"
        // "ref" se pune inaintea tipului de data a parametrului 
        static int difference(ref int leftNum, ref int rightNum)
        {
            leftNum += leftNum;
            rightNum -= 10;
            return leftNum - rightNum;
        }

        // Declararea functiei
        // 1 - tipul de data (daca nu returneaza = void , retulrneaza = int, string, float, etc...)
        // 2 - numele functiei (folosind camelCase)
        // 3 - parametrii/lista argumentelor functiei
        // 3i - un parametru e format din tipul de data + nume (int name) 
        // aici parametrii sunt transmisi prin valoare
        static int sumOfNumbers(int leftNum, int rightNum)
        {
            return leftNum + rightNum;
        }

        void test1()
        {
            Console.WriteLine("Write a: ");
            string a = Console.ReadLine();
            Console.WriteLine("Write b: ");
            string b = Console.ReadLine();

            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.WriteLine("a = {0} & b = {1} ", a, b);
        }
    }
}
