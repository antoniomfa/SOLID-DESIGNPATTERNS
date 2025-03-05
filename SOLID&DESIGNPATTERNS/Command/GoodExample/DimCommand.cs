using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DESIGNPATTERNS.Commnad.GoodExample
{
    public class DimCommand : ICommand
    {
        private LightGood _light;

        public DimCommand(LightGood light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.Dim();
        }
    }
}
