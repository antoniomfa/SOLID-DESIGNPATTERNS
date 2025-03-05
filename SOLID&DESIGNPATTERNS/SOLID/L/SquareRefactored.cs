using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DESIGNPATTERNS.SOLID.L
{
    public class SquareRefactored : Shape
    {
        public double SideLength { get; set; }

        public override double Area => SideLength * SideLength;
    }
}
