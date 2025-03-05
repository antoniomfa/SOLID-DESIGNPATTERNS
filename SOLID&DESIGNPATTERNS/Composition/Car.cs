namespace SOLID_DESIGNPATTERNS.Composition
{
    public class Car
    {
        private Enginge enginge = new();
        private Wheels wheels = new();
        private Chassis chassis = new();

        public void StartCar()
        {
            enginge.Start();
            wheels.Rotate();
            chassis.Support();
            Console.WriteLine("Car started\n");
        }
    }
}
