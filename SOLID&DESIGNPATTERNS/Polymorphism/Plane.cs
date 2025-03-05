namespace SOLID_DESIGNPATTERNS.Polymorphism
{
    public class Plane : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public override void Start()
        {
            Console.WriteLine("Plane is starting...\n");
        }

        public override void Stop()
        {
            Console.WriteLine("Plane is stopping...\n");
        }
    }
}
