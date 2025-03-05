using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DESIGNPATTERNS.State.GoodSolution
{
    public class PublishState : IState
    {
        private Document _document;

        public PublishState(Document document)
        {
            _document = document;
        }

        public void Publish()
        {
            // Do nothing if already in published state
        }
    }
}
