namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            int wheelCount;
            bool input = false;
            do
            {
                Console.WriteLine("Enter the amount of wheels for your preferred vehicle!");

                input = int.TryParse(Console.ReadLine(), out wheelCount);

            }while (input == false);

            var vehicle = VehicleFactory.GetVehicle(wheelCount);
            vehicle.Drive();
        }
    }
}
