using System.Runtime.CompilerServices;

namespace FSDN.Lambda
{
    internal class LambdaExample
    {
        //1 basic
        private Func<int, int, int> add = (a, b) => a + b;

        //2 in collection

        public static void Main(string[] args)
        {
            LambdaExample example = new LambdaExample();
            Console.WriteLine(example.add(8, 2));

            Action<string> showMessage = (msg) => Console.WriteLine(msg);
            showMessage("Hello");

            Predicate<int> isBiggerThan50 = (n) => n > 50;
            bool result = isBiggerThan50(48);
            Console.WriteLine(result);

            List<string> names = new List<string>() {"Igor", "Mile", "Simona", "Liljana", "Boban", "Voislav", "Ivona"}; 
            //names.ForEach(name => Console.WriteLine(name));
            
            names.FindAll(name => name.Length <= 4).ForEach(n => Console.WriteLine(n));

            //Function with body
            Func<int, int, string, string> multiply = (a, b, message) =>
            {
                int result = a * b;
                return message += $" {result}";
            };

            Func<int, int, int> printBigger = (x, y) =>
            {
                if (x > y)
                {
                    return x;
                }
                else if (x < y)
                {
                    return y;
                }
                else
                {
                    return x;
                }
            };

            //Console.WriteLine(multiply(4, 5, "The multiplication is"));
            int bigger = printBigger(7, 7);
            Console.WriteLine(bigger);
            
        }
    }

    internal interface ICourse
    {
        internal string Name { get; set; }
        internal int Duration { get; set; }
    }
}