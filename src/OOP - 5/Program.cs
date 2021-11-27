using System;

namespace OOP___5
{
    // abstraction / abstractizarea 
    // se realizeaza prin 2 feluri
    // 1 - clase abstracte (vezi clasa person) - nu se pot crea obiecte dupa clasele abstracte!!!!!
    // 2 - interfete (vezi interfata animal) - nu se pot crea obiecte dupa interfete!!!!!
    abstract class APerson
    {
        public string name;
        public int age;

        public abstract void printFullDescription();

        public void printDescription()
        {
            Console.WriteLine("numele: {0} , varsta: {1}", name, age);
        }
    }

    class Student: APerson
    {
        public double mark;

        public override void printFullDescription()
        {
            Console.WriteLine("numele: {0} , varsta: {1} , mark: {2}", name, age, mark);
        }
    }

    class Employee: APerson
    {
        public double salary;

        public override void printFullDescription()
        {
            Console.WriteLine("numele: {0} , varsta: {1} , salary: {2}", name, age, salary);
        }
    }

    interface IAnimal
    {
        public string Gender
        {
            get;
        }

        public void animalSound();
    }

    class Dog : IAnimal
    {
        private string gender;

        public string Gender 
        { 
            get
            {
                return gender;
            }
        }

        public Dog(string gender)
        {
            this.gender = gender;
        }

        public void animalSound()
        {
            Console.WriteLine("Bark");
        }
    }


    // STATIC

    class Car
    {
        public static string windowTint = "light grey";

        public string color;

        public Car(string color)
        {
            this.color = color;
        }

        public void changeTint(string tint)
        {
            Car.windowTint = tint;
        }

        public void printTint()
        {
            Console.WriteLine(Car.windowTint);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // nu se pot crea obiecte dupa interfete si clase abstracte
            // APerson person = new APerson();
            // IAnimal dog = new IAnimal();
            Student student = new Student();
            student.name = "Jeff";
            student.age = 24;
            student.mark = 6.9;
            student.printDescription();
            student.printFullDescription();

            Employee employee = new Employee();
            employee.name = "Codrin";
            employee.age = 37;
            employee.salary = 1500;
            employee.printDescription();
            employee.printFullDescription();

            Dog dog = new Dog("male");
            Console.WriteLine(dog.Gender);
            dog.animalSound();

            // STATIC!!

            Car audi = new Car("Black");
            Console.WriteLine(audi.color);
            audi.changeTint("red");

            Car mercedes = new Car("Grey");
            Console.WriteLine(mercedes.color);
            mercedes.changeTint("green");

            Car bmw = new Car("Blue");
            Console.WriteLine(bmw.color);
            bmw.changeTint("dark grey");

            audi.printTint();
            mercedes.printTint();
            bmw.printTint();
        }
    }
}
