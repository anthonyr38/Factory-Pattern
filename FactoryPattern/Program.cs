namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many wheels on your vehichle?");
            var wheelCount = int.Parse(Console.ReadLine());

            var vehicle = VehicleFactory.GetVehicle(wheelCount);
            vehicle.Drive();
            

            


            
                        
        }
    }
}
