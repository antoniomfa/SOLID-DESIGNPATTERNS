using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DESIGNPATTERNS.SOLID.O
{
    // ALERT: violating Open/Closed Principle
    // everytime we add more shape types, we need to change this class over and over
    // how to solve: create abstract class and move this CalculateArea logic
    // and properties to independent classes
    public class Shape
    {
        public ShapeType Type { get; set; }
        public double Radius { get; set; }
        public double Lenght { get; set; }
        public double Width { get; set; }

        public double CalculateArea()
        {
            switch (Type)
            {
                case ShapeType.Circle:
                    return Math.PI * Math.Pow(Radius, 2);
                case ShapeType.Rectangle:
                    return Lenght * Width;
                default:
                    throw new InvalidOperationException("Unsupported shape type... ");
            }
        }
    }
}
