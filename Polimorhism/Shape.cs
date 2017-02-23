using System;

namespace Polimorhism.Shapes
{
    public abstract class Shape
    {
        protected string name;
        protected ShapeType type;
        public virtual double Surface { get; }

        public virtual void PrintInfo()
        {
            Console.WriteLine("");
            Console.WriteLine($"Figura: {type.ToString()}");
            Console.WriteLine($"Nazwa: {name}");
            Console.WriteLine($"Pole: {Surface}");
        }
    }
}
