using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DESIGNPATTERNS.State.GoodSolution
{
    public class ModerationState : IState
    {
        private Document _document;

        public ModerationState(Document document)
        {
            _document = document;
        }

        public void Publish()
        {
            if (_document.CurrentUserRoles == UserRoles.Admin)
            {
                _document.State = new PublishState(_document);
            }
        }
    }
}
