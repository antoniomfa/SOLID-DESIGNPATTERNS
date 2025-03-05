using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DESIGNPATTERNS.Mediator
{
    public class TextBox : UIControl
    {
        private string _text = "";

        public TextBox(DialogBox owner) : base(owner)
        {

        }

        public string GetText() { return _text; }

        public void SetText(string selection)
        {
            _text = selection;
            _owner.Changed(this);
        }
    }
}
