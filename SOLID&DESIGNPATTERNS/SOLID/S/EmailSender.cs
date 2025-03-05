using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DESIGNPATTERNS.SOLID.S
{
    public class EmailSender
    {
        public void SendEmail(string email, string msg) 
        {
            Console.WriteLine("Seding email with msg: " + msg + "\n");
        }
    }
}
