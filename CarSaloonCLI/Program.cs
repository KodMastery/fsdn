namespace CarSaloonCLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //owners
            CarOwner firstOwner = new CarOwner("Zoran", new List<Car>());
            CarOwner secondOwner = new CarOwner("Mile", new List<Car>());

            //cars
            Car firstCar = new Car("Audi", 2000, firstOwner); //A
            Car secondCar = new Car("Toyota", 1999, firstOwner); //B
            Car thirdCar = new Car("Tesla", 2024, secondOwner); //C
            Car fourthCar = new Car("Mazda", 2014, secondOwner); //D

            ISet<Car> firstSaloonCars = new HashSet<Car>();
            firstSaloonCars.Add(firstCar);
            firstSaloonCars.Add(secondCar);

            ISet<Car> secondSaloonCars = new HashSet<Car>();
            secondSaloonCars.Add(thirdCar);
            secondSaloonCars.Add(fourthCar);

            //Saloons
            CarSaloon firstSaloon = new CarSaloon("First Saloon", firstSaloonCars);
            CarSaloon secondSaloon = new CarSaloon("Second Saloon", secondSaloonCars);

            //CLIService
            CLIService service = new CLIService();
            service.CarSaloons = new List<CarSaloon>() {firstSaloon, secondSaloon};
            service.OpenCLIReader();
        }
    }
}