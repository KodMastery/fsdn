namespace CarSaloonCLI
{
    internal class Car
    {
        internal string Brand { get; set; }
        internal int ReleaseDate { get; set; }
        internal CarOwner Owner { get; set; }

        internal Car(string brand, int releaseDate, CarOwner owner)
        {
            Brand = brand;
            ReleaseDate = releaseDate;
            Owner = owner;
            Owner.Cars.Add(this);
        }


        public override string ToString()
        {
            string result = string.Empty;
            result += "[";
            result += "Brand: " + Brand;
            result += ", ";
            result += "Release Date:" + ReleaseDate;
            result += ", ";
            result += "Owner: " + Owner;
            return result += "]";
        }
    }
}
