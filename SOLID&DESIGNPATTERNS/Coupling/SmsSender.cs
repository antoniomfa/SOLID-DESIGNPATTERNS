namespace SOLID_DESIGNPATTERNS.Coupling
{
    public class SmsSender : INotificationService
    {
        public void SendNotification(string msg)
        {
            Console.WriteLine("Sending SMS... " + msg);
        }
    }
}
