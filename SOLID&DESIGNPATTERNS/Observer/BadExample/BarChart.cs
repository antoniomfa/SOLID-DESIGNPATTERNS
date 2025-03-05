using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DESIGNPATTERNS.Observer.BadExample
{
    public class BarChart
    {
        public void Render(List<int> values)
        {
            Console.WriteLine("Rendering bar chart with new values... \n");
        }
    }
}
