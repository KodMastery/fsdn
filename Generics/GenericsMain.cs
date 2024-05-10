namespace FSDN.Generics
{
    internal class GenericsMain
    {
        public static void Main(string[] args)
        {
            Box<int> boxOfNumbers = new Box<int>();
            boxOfNumbers.Content = 10;
            boxOfNumbers.PrintContent(2);
            boxOfNumbers.PrintContent("Ispechati");
            boxOfNumbers.PrintContent(boxOfNumbers);

        }
    }
}
