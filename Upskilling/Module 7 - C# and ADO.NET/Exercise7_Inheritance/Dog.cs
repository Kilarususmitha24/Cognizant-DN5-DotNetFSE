using System;

namespace InheritanceDemo
{
    class Dog : Animal
    {
        public string Breed;

        public void Bark()
        {
            Console.WriteLine(Name + " is Barking.");
        }

        public void Display()
        {
            Console.WriteLine("Dog Name  : " + Name);
            Console.WriteLine("Breed     : " + Breed);
        }
    }
}
