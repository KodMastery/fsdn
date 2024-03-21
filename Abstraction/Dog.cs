
namespace FSDN.Abstraction
{
    internal class Dog : IAnimal
    {
        public string Eat(int calories)
        {
            return "Dog is eating: " + calories;
        }

        public void Speak()
        {
            Console.WriteLine("I am barking");
        }
    }
}
