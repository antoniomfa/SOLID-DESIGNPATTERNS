using SOLID_DESIGNPATTERNS.ChainOfResponsibility.BadExample;

namespace SOLID_DESIGNPATTERNS.ChainOfResponsibility.GoodExample
{
    public class Authenticator : Handler
    {
        public override bool DoHandle(HttpRequest request)
        {
            Console.WriteLine("Authenticating... \n");
            var usr = request.GetUsername();
            var pw = request.GetPassword();

            return !(usr == "antonio" && pw == "123");
        }
    }
}
