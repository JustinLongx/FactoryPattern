namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            

            //Complete the console app to utilize factory pattern by taking a user’s input of how many tires are on a vehicle and,
            //based on their input, creates that type of vehicle. Complete this using an interface.
            //You must have at least 2 subclasses. For instance, if I type 4 into the console, the program would create a car or truck,
            //or if someone types 2 it would create a motorcycle.

            //Create an Interface named IVehicle that has a stubbed out public void Drive method. (Done)
            //Create 2 new public classes that will conform to IVehicle. (Done)
            //Example) Car, Motorcycle, BigRig

            //Note: These classes must conform to IVehicle and implement the Drive() method - which will just Console.WriteLine(“Building a new Car!”) (Done)

            //Now we will make our static VehicleFactory class. It will contain a static method GetVehicle(), (Done)
            //that will return an IVehicle based on the amount of tires it’s given as a parameter Call this functionality in the Main method.

            Console.WriteLine($"Enter the number of tires to create a vehicle: 2, 4 or 18?");

            var wheelCount = int.Parse(Console.ReadLine());

            var vehicle = VehicleFactory.GetVehicle( wheelCount );
            vehicle.drive();

        }
    }
}
