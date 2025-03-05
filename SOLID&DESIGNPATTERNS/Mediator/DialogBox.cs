using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DESIGNPATTERNS.Mediator
{
    // This class plays the role of Mediator
    // 
    public abstract class DialogBox
    {
        public abstract void Changed(UIControl uiControl);
    }
}
