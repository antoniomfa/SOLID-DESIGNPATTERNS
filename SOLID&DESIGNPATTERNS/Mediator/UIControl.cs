using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DESIGNPATTERNS.Mediator
{
    public abstract class UIControl
    {
        protected DialogBox _owner;

        protected UIControl(DialogBox owner)
        {
            _owner = owner;
        }
    }
}
