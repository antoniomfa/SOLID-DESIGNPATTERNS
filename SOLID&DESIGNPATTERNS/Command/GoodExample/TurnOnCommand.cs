﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DESIGNPATTERNS.Commnad.GoodExample
{
    public class TurnOnCommand : ICommand
    {
        private LightGood _light;

        public TurnOnCommand(LightGood light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOn();
        }
    }
}
