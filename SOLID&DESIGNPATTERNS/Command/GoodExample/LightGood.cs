using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DESIGNPATTERNS.Commnad.GoodExample
{
    public class LightGood
    {
        public void TurnOn()
        {
            Console.WriteLine("Light is on ...\n");
        }

        public void TurnOff()
        {
            Console.WriteLine("Light is off ...\n");
        }

        public void Dim()
        {
            Console.WriteLine("Dimming light ...\n");
        }
    }
}
