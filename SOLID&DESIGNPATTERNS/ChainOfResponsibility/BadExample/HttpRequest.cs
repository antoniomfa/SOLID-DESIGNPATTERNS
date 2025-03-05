using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DESIGNPATTERNS.ChainOfResponsibility.BadExample
{
    public class HttpRequest
    {
        public string _username;
        public string _password;
        public string ValidateUsername { get; set; }
        public string ValidatePassword { get; set; }

        public HttpRequest(string username, string password)
        {
            _username = username;
            _password = password;
        }

        public string GetUsername()
        {
            return _username;
        }

        public string GetPassword()
        {
            return _password;
        }
    }
}
