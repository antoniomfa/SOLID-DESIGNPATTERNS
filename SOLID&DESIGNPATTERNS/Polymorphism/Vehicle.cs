namespace SOLID_DESIGNPATTERNS.Polymorphism
{
    public class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        // VIRTUAL -> Can be overwritten
        public virtual void Start()
        {
            Console.WriteLine("Vehicle is starting...\n");
        }

        public virtual void Stop() 
        { 
            Console.WriteLine("Vehicle is stopping...\n"); 
        }
    }
}
