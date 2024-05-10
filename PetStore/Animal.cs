namespace FSDN.PetStore
{
    internal class Animal : IPet
    {
        internal string Name { get; set; }
        internal int Age { get; set; }
        internal double Price { get; set; }

        internal Animal(string name, int age, double price)
        {
            Name = name; // Call void SetName(nameToBeAssigned) => name = nameToBeAssigned
            Age = age; // Call void SetAge(ageToBeAssigned) => age = ageToBeAssigned
            Price = price; // Call void SetPrice(priceToBeAssigned) => price = priceToBeAssigned
        }

        internal Animal() {}

        public virtual void ShowAffection()
        {
           Console.WriteLine($"Hug the pet <3 {Name}"); //Hug the pet <3 { GetName() => return name; }
        }

        internal virtual void Run(int km)
        {
            Console.WriteLine($"I am running {km} kilometers");
        }

    }
}
