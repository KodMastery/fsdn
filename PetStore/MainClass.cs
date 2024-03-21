namespace FSDN.PetStore
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            /*
             * GOALS:
             * 0. Let's make our PetStore :3
             * 1. interface IPet -> [ShowAffection()]
             * 2. class Animal : IPet -> { name, age, price } [IPet methods]
             * 3. class Cat : Animal -> [override ShowAffection()]
             * 4. Refactor classes with properties
             * 5. We want to make two cats
             * 6. These cats will have Owners
             * 7. struct PetOwner {name, surname, email, pets}
             * 8. record PetStoreDTO {name, pets, owners}
             */
            Console.WriteLine("Our Pet Store");
            Animal firstCat = new Cat("Mathilda", 2, 1000, "brichena");
            IPet secondCat = new Cat("SestraInaMathilda", 3, 500, "zapushtena");

            secondCat.ShowAffection();
            //array of pets
            IPet[] pets = [secondCat, firstCat];
            
            //struct
            PetOwner catOwner = new PetOwner();
            catOwner.Name = "Stojan";
            catOwner.Surname = "Vojvodata";
            catOwner.Email = "vojvodata@gmail.com";
            catOwner.Pets = pets;

            //array of pet owners
            PetOwner[] owners = [catOwner];
            
            //record
            PetStoreDto petStore = new PetStoreDto("Our First Petstore", pets, owners);
            PetStoreDto petStore2 = petStore with{Name = "Stojna"};
            string name = petStore.Name;
            Console.WriteLine(petStore == petStore2);
            // PetStoreDto petStore2 = petStore with { Name = "Our second Petstore" };
            //Console.WriteLine(petStore);
            //Console.WriteLine(petStore2);

        }
            
    }
}