using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DESIGNPATTERNS.Strategy.GoodExample
{
    public class CompressorWEBM : ICompressor
    {
        public void Compress()
        {
            Console.WriteLine("Compressing using WEBM ...\n");
        }
    }
}
