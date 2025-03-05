using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DESIGNPATTERNS.Commnad.GoodExample
{
    public class RemoteControlGood
    {
        private ICommand _command;

        public RemoteControlGood(ICommand command)
        {
            _command = command;
        }

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void PressButton()
        {
            _command.Execute();
        }
    }
}
