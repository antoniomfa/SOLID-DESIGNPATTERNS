using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DESIGNPATTERNS.State.GoodSolution
{
    public class Document
    {
        public IState State { get; set; }
        public UserRoles CurrentUserRoles { get; set; }

        public Document(UserRoles currentUserRoles)
        {
            CurrentUserRoles = currentUserRoles;
            State = new DraftState(this);
        }

        public void Publish()
        {
            State.Publish();
        }
    }
}
