using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DESIGNPATTERNS.Strategy.GoodExample
{
    public class CompressorMOV : ICompressor
    {
        public void Compress()
        {
            Console.WriteLine("\nCompressing using MOV ...\n");
        }
    }
}
