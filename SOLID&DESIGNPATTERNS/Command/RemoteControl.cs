using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DESIGNPATTERNS.Commnad
{
    // PROBLEM: Light is tighly coupled to RemoteControl, if we want to add new features we need to modify this class
    public class RemoteControl
    {
        private Light _light;

        public RemoteControl(Light light)
        {
            _light = light;
        }

        public void PressButton(bool turnOn)
        {
            if (turnOn)
            {
                _light.TurnOn();
            }
            else
            {
                _light.TurnOff();
            }
        }
    }
}
