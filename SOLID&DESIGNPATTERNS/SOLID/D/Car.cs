using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DESIGNPATTERNS.SOLID.D
{
    public class Car
    {
        private Engine Engine;
        private IEngine _engine;

        public Car()
        {
            this.Engine = new Engine();
        }

        public Car(IEngine engine)
        {
            _engine = engine;
        }

        // NOT OK BECAUSE DEPENDS ON ENGINE CLASS THAT CAN CHANGE AND BREAK THIS
        public void StartCarNOTOK()
        {
            Engine.Start();
            Console.WriteLine("Car started NOT OK\n");
        }

        public void StartCarOK()
        {
            _engine.Start();
            Console.WriteLine("Car started OK\n");
        }
    }
}
