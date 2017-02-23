using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorhism.Shapes
{
    class Circle : Shape
    {
        private double ray; 

        public Circle(string name, double ray)
        {
            type = ShapeType.Circle;
            this.name = name;
            this.ray = ray;
        }

        public override double Surface
        {
            get
            {
                return Math.PI * Math.Pow(ray, 2d);
            }
        }

        public double Length
        {
            get
            {
                return 2 * Math.PI * ray;
            }
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Długość okręgu: {Length}");
        }
    }
}
