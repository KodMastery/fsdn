
namespace FSDN.OpeartorOverloading
{
    
    public class MainClass : Object
    {
        internal class Animal
        {
            internal string Name { get; set; }
        }

        internal class PetStore
        {
            internal List<Animal> Animals { get; set; }

            internal PetStore()
            {
                Animals = new List<Animal>();
            }

            public static PetStore operator +(PetStore firstStore, PetStore secondStore)
            {
                PetStore combined = new PetStore();
                combined.Animals.AddRange(firstStore.Animals);
                combined.Animals.AddRange(secondStore.Animals);
                return combined;
            }

        }



        public static void Main(string[] args)
        {
            Animal cow = new Animal();
            cow.Name = "Milka";

            Animal monkey = new Animal();
            monkey.Name = "Monke";

            Animal cat = new Animal();
            cat.Name = "Mathilda";


            PetStore a = new PetStore();
            a.Animals.Add(monkey);
            a.Animals.Add(cow);

            PetStore b = new PetStore();
            b.Animals.Add(cat);

            PetStore c = a + b;

            foreach (Animal animal in c.Animals)
            {
                Console.WriteLine(animal.Name);
            }

        }
    }

}
