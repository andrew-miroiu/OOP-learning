using System;

namespace OOP_2
{
    // i - inheritance (mostenire) 
    // constructors / initialisers (constructori / initializare de obiecte)

    class Car
    {
        private int numberOfDoors; // = 4;


        // un constructor poate avea 0, 1 sau mai multi parametri 
        public Car(int doorsNumber)
        {
            numberOfDoors = doorsNumber;
        }

        public int getDoors()
        {
            return numberOfDoors;
        }

        public void updateDoors(int newNumber)
        {
            numberOfDoors = newNumber;
        }
    }

    class Audi
    {
        private int price;

        public Audi(int newPrice)
        {
            price = newPrice;
        }

        public Audi()
        {
            price = 0;
        }

        public int getPrice()
        {
            return price;
        }
    }

    class SimpleCar
    {
        public int numberOfDoors = 4;
        public int numberOfWindows = 6;
    }

    class Ford: SimpleCar
    {
        public string name = "Mustang";
    }

    class Person
    {
        public string name = "";
        public int age = 0;
    }

    class Employee: Person
    {
        public int salary = 0;
    }

    public class Animal
    {
        public void eat()
        {
            Console.WriteLine("Eating...");
        }
    }
    public class Dog: Animal
    {
        public void bark()
        {
            Console.WriteLine("Barking...");
        }
    }
    public class BabyDog: Dog
    {
        public void weep()
        {
            Console.WriteLine("Weeping...");
        }
    }


    // clasa parinte / super clasa  = parent class / super class
    class Headphones
    {
        public string name;

        public Headphones(string name)
        {
            this.name = name;
        }
    }


    // clasa derivata / copil = derived / child class
    class Razer: Headphones
    {
        public bool hasLeds;

        public Razer(bool hasLeds, string name): base(name)
        {
            this.hasLeds = hasLeds;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car(3);

            Console.WriteLine("Nr usi: {0}", car1.getDoors());

            Audi audiCar; // aici am declarat doar obiectul audiCar
            audiCar = new Audi(); // aici am initializat / instantiat / creat referinta pentru obiectul mai sus declarat

            Console.WriteLine("price: {0}", audiCar.getPrice());

            Ford ford = new Ford();
            Console.WriteLine("name: {0}", ford.name);
            Console.WriteLine("doors: {0}", ford.numberOfDoors);
            Console.WriteLine("windows: {0}", ford.numberOfWindows);

            Employee employee1 = new Employee();
            employee1.name = "Jeff";
            employee1.age = 35;
            employee1.salary = 1500;

            Employee employee2 = new Employee();
            employee2.name = "Mike";
            employee2.age = 25;
            employee2.salary = 5000;

            Console.WriteLine("E1: {0} , {1} , {2}", employee1.name, employee1.age, employee1.salary);
            Console.WriteLine("E2: {0} , {1} , {2}", employee2.name, employee2.age, employee2.salary);

            BabyDog babyDog = new BabyDog();
            babyDog.eat();
            babyDog.bark();
            babyDog.weep();

            Razer razer = new Razer(true, "Kraken X");
            Console.WriteLine("Razer headset: {0}, {1}", razer.hasLeds, razer.name);
        }
    }
}
