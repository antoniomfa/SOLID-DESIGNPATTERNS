namespace SOLID_DESIGNPATTERNS.SOLID.S
{
    // ALERT: violating Single Responsible Principle
    // manages user data and logic for registering an user
    // has more than one reason to change!!!
    // how to solve: create new class (e.g. UserService) with Register method 
    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }

        public void Register()
        {
            // Register user logic ...

            // Send email ...
            EmailSender emailSender = new EmailSender();
            emailSender.SendEmail(Email, "MSG");
        }
    }
}
