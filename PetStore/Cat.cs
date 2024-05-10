namespace FSDN.PetStore
{
    internal class Cat : Animal
    {
        internal int Age { get; set; }

        internal string Type { get; set; }
        internal Cat(string name, int age, double price, string type) : base(name, age, price)
        {
            Type = type;
        }

        internal Cat() {}

        public override void ShowAffection()
        {
            Console.WriteLine($"Hug the cat <3 {Name}");
            Cat c = new Cat();
            int catAge = c.Age;
            c.Age = 2;
        }

        internal override void Run(int km)
        {
            Console.WriteLine($"I am running these {km} kilometers way faster because i am A CAT  ");
        }

    }
}
