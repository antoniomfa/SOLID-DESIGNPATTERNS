using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DESIGNPATTERNS.Strategy.GoodExample
{
    public class OverlayNone : IOverlay
    {
        public void Apply()
        {
            Console.WriteLine("Not using any overlay ...\n");
        }
    }
}
