using SOLID_DESIGNPATTERNS.ChainOfResponsibility.BadExample;

namespace SOLID_DESIGNPATTERNS.ChainOfResponsibility.GoodExample
{
    public class Logger : Handler
    {
        public override bool DoHandle(HttpRequest request)
        {
            Console.WriteLine("Logging... \n");
            return false;
        }
    }
}
