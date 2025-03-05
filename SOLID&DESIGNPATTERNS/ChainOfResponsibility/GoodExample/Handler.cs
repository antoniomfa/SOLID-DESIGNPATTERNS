using SOLID_DESIGNPATTERNS.ChainOfResponsibility.BadExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DESIGNPATTERNS.ChainOfResponsibility.GoodExample
{
    public abstract class Handler
    {
        private Handler _nextHandler;

        public Handler SetNext(Handler handler)
        {
            _nextHandler = handler;

            // "hanlder1.setNext(handler2)
            // .setNext(handler3) etc

            return handler;
        }

        public void Handle(HttpRequest request)
        {
            if (DoHandle(request))
            {
                return;
            }
            
            if (_nextHandler != null)
            {
                _nextHandler.Handle(request);
            }
        }

        public abstract bool DoHandle(HttpRequest request);
    }
}
