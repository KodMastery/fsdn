namespace FSDN.ZooExercise
{
    internal class Zookeeper
    {
        internal ZooKeeperProfile Profile { get; private set; }
        internal int YearsOfExperience { get; set; }

        internal Zookeeper(ZooKeeperProfile profile, int yearsOfExperience)
        {
            Profile = profile;
            YearsOfExperience = yearsOfExperience;
        }

        internal void FeedAnimal(Animal animal, FoodItem foodItem)
        {
            if (!animal.Fed)
            {
                Console.WriteLine($"{Profile.Name} is feeding {animal.Name}.");
                animal.Eat();
            }
        }

        internal void CheckHealth(Animal animal)
        {
            Console.WriteLine($"{Profile.Name} is checking the health of {animal.Name}.");
        }
    }

}
