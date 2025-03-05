using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DESIGNPATTERNS.ChainOfResponsibility.BadExample
{
    public class Validator
    {
        public void Validate(HttpRequest request)
        {
            var user = request.GetUsername();
            var pw = request.GetPassword();

            request.ValidateUsername = user.Trim();
            request.ValidatePassword = pw.Trim();
        }
    }
}
