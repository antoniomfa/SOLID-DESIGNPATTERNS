using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DESIGNPATTERNS.SOLID.I
{
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        // PROBLEM!!!
        // should not exist on circle
        public double Volume()
        {
            // commented to run app
            //throw new InvalidOperationException("Volume not applicable for 2D shapes\n");

            // comment this to test
            return 0;
        }
    }
}
