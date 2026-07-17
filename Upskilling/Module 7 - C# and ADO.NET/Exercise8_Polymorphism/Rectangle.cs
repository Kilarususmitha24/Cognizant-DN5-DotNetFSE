using System;

namespace PolymorphismDemo
{
    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing Rectangle");
        }
    }
}
