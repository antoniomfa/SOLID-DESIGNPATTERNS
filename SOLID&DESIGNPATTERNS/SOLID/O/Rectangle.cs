using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DESIGNPATTERNS.SOLID.O
{
    public class Rectangle : ShapeRefactored
    {
        public double Lenght { get; set; }
        public double Width { get; set; }

        public override double CalculateArea()
        {
            return Lenght * Width;
        }
    }
}
