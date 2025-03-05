using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DESIGNPATTERNS.Commnad.GoodExample
{
    public class TurnOffCommand : ICommand
    {
        private LightGood _light;

        public TurnOffCommand(LightGood light)
        {
            _light = light;
        }

        public void Execute()
        {
           _light.TurnOff();    
        }
    }
}
