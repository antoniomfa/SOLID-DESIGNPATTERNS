namespace SOLID_DESIGNPATTERNS.Coupling
{
    public class Order
    {
        private readonly INotificationService _notificationService;

        public Order(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        // ALERT - dependent of EmailSender class (new instance)
        public void PlaceOrder()
        {
            // Order logic ...

            EmailSender sender = new EmailSender();
            //sender.SendEmail("Order placed successfully...\n"); 
        }

        // This is better
        public void SendNotification()
        {
            // Order logic ...

            _notificationService.SendNotification("Order placed successfully...\n");
        }
    }
}
