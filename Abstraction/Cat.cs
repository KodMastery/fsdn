namespace FSDN.Abstraction
{
    internal class Cat : IAnimal
    {
        public int x = 4;

        public void Speak()
        {
            Console.WriteLine("Meow");
        }

        public string Eat(int calories)
        {
            return "Cat is eating: " + calories;
        }

    }

    internal class Cat2 : Cat 
    {
    
    }
}
