using System.Collections;
using System.Runtime.CompilerServices;

namespace FSDN.Collections
{
    internal class CollectionsMain
    {
        public static void Main(string[] args)
        {
            int[][] xo = [[1,2,3], [4,5,6], [7,8,9]];

            foreach (var row in xo)
            {
                foreach (var col in row)
                {
                   // Console.WriteLine(col);
                }
            }

            static IEnumerable<int> GetNumbers()
            {
                return [1, 2, 3, 4, 5];
            }

            IEnumerable<int> numbers = GetNumbers();
            IEnumerator<int> enumerator = numbers.GetEnumerator();
            
            while (enumerator.MoveNext())
            {
                int currentNumber = enumerator.Current;
                //Console.WriteLine(currentNumber);
            }

            ICollection<string> fruits = ["Banana", "Orange", "Apple"];
            //Console.WriteLine(fruits.Contains("Lemon"));
            //print collection
            

            IList<double> list = new List<double>();
            list.Add(3.32132);
            list.Add(-3.32132);
            //print collection

            list.Clear();

            ISet<int> set = new HashSet<int>
            {
                1,
                2,
                90,
                100,
                2
            };

            //PrintCollection(set);

            IDictionary<int, string> dictionary = new Dictionary<int, string>();

            dictionary.Add(90, "John Doe, 23 years...");
            dictionary.Add(80, "Jane Doe 45 years...");
            
            string jane;
            dictionary.TryGetValue(80, out jane);
            dictionary.ContainsKey(90);

            Stack<int> stack = new Stack<int>();
            stack.Push(2);
            stack.Push(5);
            stack.Push(10);
           //Console.WriteLine(stack.Peek());

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(2);
            queue.Enqueue(5);
            queue.Enqueue(10);
            queue.Dequeue();
            queue.Dequeue();
            Console.WriteLine(queue.Peek());


            static void PrintCollection(IEnumerable enumerable)
            {
                foreach (var obj in enumerable)
                {
                    Console.WriteLine(obj);
                }
            }
        }


    }
}
