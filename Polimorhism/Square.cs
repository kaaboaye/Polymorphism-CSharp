using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorhism.Shapes
{
    class Square : Shape
    {
        private double side;

        public Square(string name, double side)
        {
            type = ShapeType.Square;
            this.name = name;
            this.side = side;
        }

        public override double Surface
        {
            get
            {
                return side * side;
            }
        }

        public double Diagonal
        {
            get
            {
                return Math.Pow(2d, 1d / 2d) * side;
            }
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Bok: {side}");
            Console.WriteLine($"Przekątna: {Diagonal}");
        }
    }
}
