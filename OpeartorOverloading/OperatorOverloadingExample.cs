namespace FSDN.OpeartorOverloading
{
    public class Animal
    {
        public string Name { get; set; }
    }

    public class PetStore
    {
        public List<Animal> Animals { get; set; } = new List<Animal>();
        public static PetStore operator *(PetStore store1, PetStore store2)
        {
            var combinedStore = new PetStore();
            combinedStore.Animals.AddRange(store1.Animals);
            combinedStore.Animals.AddRange(store2.Animals);
            return combinedStore;
        }

    }

    public class MainClass()
    {
        public static void Main(string[] args)
        {
            PetStore store1 = new PetStore();
            store1.Animals.Add(new Animal { Name = "Dog" });
            PetStore store2 = new PetStore();
            store2.Animals.Add(new Animal { Name = "Cat" });
            PetStore combinedStore = store1 * store2;
            Console.WriteLine(combinedStore);
        }
    }

}
