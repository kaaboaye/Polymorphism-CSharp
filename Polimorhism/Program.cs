using Polimorhism.Shapes;
using System;
using System.Collections.Generic;

namespace Polimorhism
{
    class Program
    {
        static void Main(string[] args)
        {
            var Figury = new List<Shape>
            {
                new Square("Kwadrat ABCD", 4d),
                new Circle("Fajny okrąg", 3d),
            };

            foreach (Shape Figura in Figury)
            {
                Figura.PrintInfo();
            }

            Console.ReadLine();
        }
    }
}
