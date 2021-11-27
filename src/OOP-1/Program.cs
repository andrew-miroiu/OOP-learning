using System;

/* OOP - Object Oriented Progamming 
 * Principiile fundamentale ale OOP-ului: APIE
 * A - Abstraction/Abstractizare
 * P - Polymorphism/Polimorfism (vine din greaca, poli + morf adica mai multe forme)
 * I - Inheritance/Mostenire (sub-clasare)
 * E - Encapsulation/Incapsulare (public, private, internal; astea se numesc access modifiers)
 */

namespace OOP_1
{
    class Math
    {
        public Math()
        {
            // asta este o functie speciala numita constructor prin care putem creea noi obiecte 
            // constructorul asta il avem by default fara sa il scriem noi datorita c#-ului
        }

        public int sum(int a, int b)
        {
            return a + b;
        }

        public int diff(int a, int b)
        {
            return a - b;
        }
    }

    class Car
    {
        private int numberOfDoors = 4;

        public int getDoors()
        {
            return numberOfDoors;
        }

        public void updateDoors(int newNumber)
        {
            numberOfDoors = newNumber;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // creare obiect dupa o clasa facuta de mine
            // numele_clasei numbele_obiectului = new numele_clasei () ;
            // de exemplu: Math myMathObj = new Math();

            Math myMathObject = new Math(); // aici creeam/initializam/instantiam un obiect nou dupa clasa noastra
            int sum = myMathObject.sum(10, 10);
            Console.WriteLine("Suma: {0}", sum);

            int diff = myMathObject.diff(20, 10);
            Console.WriteLine("Diferenta este : {0}", diff);

            Car myCar = new Car();
            Console.WriteLine("Number of doors: {0}", myCar.getDoors());

            //myCar.numberOfDoors = 2; variabila asta ii privata acum deci ne folosim de functia publica update doors in schimb
            myCar.updateDoors(10);
            Console.WriteLine("Number of doors v.2: {0}", myCar.getDoors());

            myCar.updateDoors(3);
            Console.WriteLine("Noul numar de usi: {0}", myCar.getDoors());

            Car newCar = new Car();
            newCar.updateDoors(5);
            Console.WriteLine("My car doors: {0} si newCar doors: {1}", myCar.getDoors(), newCar.getDoors());
        }
    }
}
