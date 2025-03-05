using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DESIGNPATTERNS.SOLID.I
{
    // SPLITTED INTO 2 NEW INTERFACES (2D AND 3D)
    public interface IShape
    {
        double Area();
        double Volume();
    }
}
