using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DESIGNPATTERNS.State
{
    public class Document
    {
        public DocumentStates State { get; set; }
        public UserRoles CurrentUserRole { get; set; }

        // Update state of document to next state
        // PROBLEM: IF USER ROLE / DOCUMENT STATES CHANGE THIS WILL NEED TO CHANGE A LOT AND "BLOATED"
        public void Publish()
        {
            if (State == DocumentStates.Draft)
            {
                State = DocumentStates.Moderation;
            }
            else if (State == DocumentStates.Moderation)
            {
                if (CurrentUserRole == UserRoles.Admin)
                {
                    State = DocumentStates.Published;
                }
            }
            else if (State == DocumentStates.Published)
            {
                // do nothing (or delete this if)
            }
        }
    }
}
