using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
