using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DESIGNPATTERNS.Mediator
{
    public class PostsDialogBox : DialogBox
    {
        // Fields for all UI components
        private ListBox _postsListBox;
        private TextBox _titleTextBox;
        private Button _btn;

        public PostsDialogBox()
        {
            _postsListBox = new ListBox(this);
            _titleTextBox = new TextBox(this);
            _btn = new Button(this);
            _btn.SetEnabled(false);
        }

        public override void Changed(UIControl uiControl)
        {
            if (uiControl == _postsListBox)
            {
                HandlePostChanged();
            }
            else if (uiControl == _titleTextBox)
            {
                HandleTitleChanged();
            }
        }

        private void HandlePostChanged()
        {
            _titleTextBox.SetText(_postsListBox.GetSelection());

            _btn.SetEnabled(true);
        }

        public void HandleTitleChanged()
        {
            bool isTitleEmpty = _titleTextBox.GetText() == "";

            _btn.SetEnabled(!isTitleEmpty);
        }

        public void SimulateUserInteractionOk()
        {
            _postsListBox.SetSelection("Post 2");
            Console.WriteLine("Title text box:" + _titleTextBox.GetText());
            Console.WriteLine("Button enabled: " + _btn.IsEnabled());
        }

        public void SimulateUserInteractionNOk()
        {
            _postsListBox.SetSelection("Post 2");
            _titleTextBox.SetText("");
            Console.WriteLine("Title text box:" + _titleTextBox.GetText());
            Console.WriteLine("Button enabled: " + _btn.IsEnabled());
        }
    }
}
