using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DESIGNPATTERNS.Mediator
{
    public class Button : UIControl
    {
        private bool _enabled;

        public Button(DialogBox owner) : base(owner)
        {

        }

        public bool IsEnabled() { return _enabled; }

        public void SetEnabled(bool isEnabled)
        {
            _enabled = isEnabled;
            _owner.Changed(this);
        }
    }
}
