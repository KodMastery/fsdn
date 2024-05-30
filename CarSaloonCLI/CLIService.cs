
namespace CarSaloonCLI
{
    internal class CLIService
    {
        internal List<CarSaloon> CarSaloons { get; set; }
        /*
         * 1. Choose saloon?
         *
         */
        internal void OpenCLIReader()
        {
            Console.WriteLine("Welcome to our application");
            Console.WriteLine();
            ChooseSaloon();
            ChooseSaloonOperation();
        }

        private void ChooseSaloonOperation()
        {
            Console.WriteLine("1. Back");
            Console.WriteLine("2. Insert");
            Console.WriteLine("3. Delete");
        }

        private void ChooseSaloon()
        {
            Console.WriteLine("Here are all the saloons: ");
            string saloonsInformation = GetCarSaloonsInformation();
            Console.WriteLine(saloonsInformation);
            Console.WriteLine("Choose a number appropriate for the saloon to see details");

            string? input = Console.ReadLine();

            int index = int.Parse(input);

            CarSaloon saloon = CarSaloons[index - 1];

            Console.WriteLine(saloon.ToString());
        }


        private string GetCarSaloonsInformation()
        {
            string result = string.Empty;
            int counter = 1;
          
            foreach (CarSaloon saloon in CarSaloons)
            {
                result += counter + ". " + saloon.Name + "\n";
                counter++; 
            }

            return result;
        }
    }
}