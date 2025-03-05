namespace SOLID_DESIGNPATTERNS.Polymorphism
{
    public class Motorcycle : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Motorcycle is starting...\n");
        }

        public override void Stop() 
        {
            Console.WriteLine("Motorcycle is stopping...\n");
        }
    }
}
