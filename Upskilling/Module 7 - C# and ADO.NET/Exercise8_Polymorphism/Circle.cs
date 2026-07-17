using System;

namespace PolymorphismDemo
{
    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing Circle");
        }
    }
}
