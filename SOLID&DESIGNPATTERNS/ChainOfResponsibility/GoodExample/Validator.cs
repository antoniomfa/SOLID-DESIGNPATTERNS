using SOLID_DESIGNPATTERNS.ChainOfResponsibility.BadExample;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DESIGNPATTERNS.ChainOfResponsibility.GoodExample
{
    public class Validator : Handler
    {
        public override bool DoHandle(HttpRequest request)
        {
            Console.WriteLine("Validating... \n");
            var user = request.GetUsername();
            var pw = request.GetPassword();

            request.ValidateUsername = user.Trim();
            request.ValidatePassword = pw.Trim();

            return request.ValidateUsername == "" || request.ValidatePassword == "";
        }
    }
}
