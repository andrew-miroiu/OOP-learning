using System;

namespace OOP___4
{
    class Person
    {
        private string name;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public Person(string name)
        {
            this.name = name;
        }

        public string returnName()
        {
            return name;
        }

        public void updateName(string name)
        {
            this.name = name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Mihai");
            person.updateName("Jeff");
            Console.WriteLine(person.returnName());

            person.Name = "Jack";
            Console.WriteLine(person.Name);
        }
    }
}
