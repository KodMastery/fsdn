namespace CarSaloonCLI
{
    internal class CarOwner
    {
        internal string Name { get; set; }
        internal List<Car> Cars { get; set; }

        internal CarOwner(string name, List<Car> cars)
        {
            Name = name;
            Cars = cars;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
