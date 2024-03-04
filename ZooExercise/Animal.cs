using static FSDN.ZooExercise.FoodItem;

namespace FSDN.ZooExercise
{
    internal class Animal
    {
        internal string Name { get; set; }
        internal string Species { get; set; }
        internal int Age { get; set; }
        internal bool Fed { get; set; }

        internal Animal(string name, string species, int age)
        {
            Name = name;
            Species = species;
            Age = age;
            Fed = false;
        }

        internal void MakeSound()
        {
            Console.WriteLine($"{Name}, the {Species}, makes a sound.");
        }

        internal void Eat(FoodItem food)
        {
            FoodType type = food.Type;
            string foodName = food.Name;
            Console.WriteLine($"{Name} is eating ${foodName} of type '{type}'.");
            Fed = true;
        }
    }

}
