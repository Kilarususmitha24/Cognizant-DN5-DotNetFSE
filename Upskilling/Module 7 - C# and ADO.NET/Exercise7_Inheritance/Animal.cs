using System;

namespace InheritanceDemo
{
    class Animal
    {
        public string Name;

        public void Eat()
        {
            Console.WriteLine(Name + " is Eating.");
        }

        public void Sleep()
        {
            Console.WriteLine(Name + " is Sleeping.");
        }
    }
}
