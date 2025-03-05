using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DESIGNPATTERNS.ChainOfResponsibility.BadExample
{
    public class Authenticator
    {
        public bool Authenticate(HttpRequest req)
        {
            var usr = req.GetUsername();
            var pw = req.GetPassword();

            return usr == "antonio" && pw == "123";
        }
    }
}
