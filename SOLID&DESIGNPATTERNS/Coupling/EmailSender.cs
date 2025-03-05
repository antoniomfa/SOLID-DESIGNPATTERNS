namespace SOLID_DESIGNPATTERNS.Coupling
{
    public class EmailSender : INotificationService
    {
        public void SendNotification(string msg)
        {
            Console.WriteLine("Sending Email... " + msg);
        }
    }
}
