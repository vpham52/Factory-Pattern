namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many tires would you like on your vehicle?");
            string userInput = (Console.ReadLine());

            IVehicle vehicle = VehicleFactory.GetVehicle(userInput);

            vehicle.Drive();

        } 
    }
}
