using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat a = new Cat();
            a.Say();
            Dog b = new Dog();
            b.Say();
            Console.ReadKey();
        }
        abstract class Animal
        {
            abstract public string Name { get; set; }
            abstract public string Scream { get; set; }

            virtual public string Say()
            {
                Console.WriteLine(Scream);
                return Name;
            }
            public string ShowInfo()
            {
                Console.Write(Name);
                Say();
                return Name;
            }
        }
        class Cat : Animal
        {
            public override string Name { get; set; }
            public override string Scream { get; set; }
            public Cat()
            {
                Name = "Кошка";
                Scream = "Мяу";
            }
        }
        class Dog : Animal
        {
            public override string Name { get; set; }
            public override string Scream { get; set; }
            public Dog()
            {
                Name = "Собака";
                Scream = "Гав";
            }
        }

    }
}