using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DESIGNPATTERNS.Strategy.GoodExample
{
    public class CompressorBlur : IOverlay
    {
        public void Apply()
        {
            Console.WriteLine("\nUsing overlay Blur ...\n");
        }
    }
}
