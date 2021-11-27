using System;

namespace OOP___3
{
    // Polymorphism / polimorfismul - exista sub doua forme:
    // Runtime polymorphism (Dynamic polymorphism)
    // Compile-time polymorphism (Static polymorphism)


    // Compile-time polymorphism(Static polymorphism) 
    // method overloading - supraincarcarea metodelor
    // asta ii un language feature care ne permite sa avem 2 sau mai multe functii cu acelasi nume dar cu signature diferit


    class Overloading
    {
        public void print(string s)
        {
            Console.WriteLine("print(string s): {0}", s);
        }

        public void print(int x)
        {
            Console.WriteLine("print(int x): {0}", x);
        }

        public void print(string s, int x)
        {
            Console.WriteLine("print(string s, int x): {0}, {1}", s, x);
        }

        public void print(int x, string s)
        {
            Console.WriteLine("print(int x, string s): {0}, {1}", x, s);
        }
    }

    // Runtime polymorphism (Dynamic polymorphism)
    // method overriding - suprascrierea functiilor

    class Parent
    {
        public virtual void print(string s)
        {
            Console.WriteLine("parent: {0}", s);
        }
    }

    class Child: Parent
    { 
        public override void print(string s)
        {
            Console.WriteLine("child: {0}", s);
        }

        public void child()
        {

        }    
    }

    class Child2: Parent
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            Overloading overload = new Overloading();
            overload.print("oveload 1");
            overload.print(5);
            overload.print("overload 2", 6);
            overload.print(9, "overload 3");

            Parent parent = new Parent();
            // ce este in stanga egalului este obiect de tipul (data type) Parent 
            // ce este in dreapta egalului este referinta tipului (data type) Parent 
            parent.print("parent");

            Child child = new Child();
            child.print("child");
            child.child();

            Child2 child2 = new Child2();
            child2.print("child2");

            Parent parent2 = new Child();
            // ce este in stanga egalului este obiect de tipul (data type) Parent 
            // ce este in dreapta egalului este referinta tipului (data type) Child
            parent2.print("parent2");
        }
    }
}
