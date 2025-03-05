using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DESIGNPATTERNS.Strategy.GoodExample
{
    public class CompressorMP4 : ICompressor  
    {
        public void Compress()
        {
            Console.WriteLine("\nCompressing using MP4 ...\n");
        }
    }
}
