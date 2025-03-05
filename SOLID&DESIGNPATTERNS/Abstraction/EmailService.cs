namespace SOLID_DESIGNPATTERNS.Abstraction
{
    public class EmailService
    {
        public void SendEmail()
        {
            Connect();
            Authenticate();
            Disconnect();
            Console.WriteLine("Sending Email...\n");
        }

        private void Connect()
        {
            Console.WriteLine("Connecting to Email Server...\n");
        }

        private void Authenticate()
        {
            Console.WriteLine("Authenticating...\n");
        }

        private void Disconnect()
        {
            Console.WriteLine("Disconnecting from Email Server...\n");
        }
    }
}
