namespace FSDN.ZooExercise
{
    internal class Zoo
    {
        internal Animal[] Animals { get; private set; } // collection of animals for the zoo
        internal Zookeeper Zookeeper { get; set; } // Only one zookeeper per zoo
        internal string Name { get; set; }
        private int animalCount = 0; // Keep track of the number of animals

        internal Zoo(string name, int capacity)
        {
            Name = name;
            Animals = new Animal[capacity]; // Initialize the array with a fixed capacity
        }

        internal void AddAnimal(Animal animal)
        {
            if (animalCount < Animals.Length)
            {
                Animals[animalCount++] = animal; // Add animal and increment count
                Console.WriteLine($"{animal.Name} has been added to the zoo.");
            }
            else
            {
                Console.WriteLine("The zoo has reached its capacity and cannot add more animals.");
            }
        }

        internal void RemoveAnimal(string name)
        {
            for (int i = 0; i < animalCount; i++)
            {
                if (Animals[i].Name == name)
                {
                    for (int j = i; j < animalCount - 1; j++)
                    {
                        Animals[j] = Animals[j + 1]; // Shift animals left to fill the gap
                    }
                    animalCount--; // Decrease count of animals
                    Animals[animalCount] = null; // Nullify the last element
                    Console.WriteLine($"{name} has been removed from the zoo.");
                    return;
                }
            }
            Console.WriteLine($"Animal with name {name} was not found in the zoo.");
        }

        internal void FeedAllAnimals()
        {
            if (Zookeeper != null)
            {
                for (int i = 0; i < animalCount; i++)
                {
                    FeedAnimal(Animals[i]);
                }
            }
            else
            {
                Console.WriteLine("The zoo does not have a zookeeper to feed the animals.");
            }
        }

        private void FeedAnimal(Animal animal)
        {
            Zookeeper.FeedAnimal(animal);
        }
    }


}
