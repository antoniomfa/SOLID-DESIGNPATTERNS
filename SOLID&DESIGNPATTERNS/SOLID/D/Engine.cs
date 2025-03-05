using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SOLID_DESIGNPATTERNS.SOLID.D
{
    public class Engine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Engine started");
        }
    }
}
