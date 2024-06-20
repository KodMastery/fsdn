using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSDN.LINQ
{
    internal class LinqMain
    {

        public static void Main(string[] args)
        {
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
            ////not sophisticated var oddNumbers = from n in numbers where n % 2 != 0 select n;
            //var oddNumbersMultipliedByTwo = numbers.Where(n => n % 2 != 0).Select(n => n * 2).Select(n => $"Number: {n}");
            //
            //foreach (var oddNumber in oddNumbersMultipliedByTwo)
            //{
            //    Console.WriteLine(oddNumber);
            //}
            //
            List<Fruit> fruits = new List<Fruit>()
            {
                new Fruit { Name = "banana", IsTropic = true },
                new Fruit { Name = "mango", IsTropic = true },
                new Fruit { Name = "orange", IsTropic = false },
                new Fruit { Name = "peach", IsTropic = false },
                new Fruit { Name = "pear", IsTropic = false },
                new Fruit { Name = "apple", IsTropic = false },
                new Fruit { Name = "strawberry", IsTropic = false }
            };

            var juices = fruits.Select(fruit => new Juice(fruit.Name.Length, $"{fruit.Name} Juice", fruit));

            var juiceWithFruitInfo = juices.Join(fruits,
                juice => juice.Name,
                fruit => fruit.Name,
                (juice, fruit) => new
                {
                    JuiceName = juice.Name,
                    JuicePrice = juice.Price,
                    FruitName = fruit.Name,
                    IsTropic = fruit.IsTropic
                });

            foreach (var item in juiceWithFruitInfo)
            {
                Console.WriteLine($"Juice: {item.JuiceName}, Price: {item.JuicePrice}, Fruit: {item.FruitName}, Is Tropic: {item.IsTropic}");
            }

        }



        private class Fruit
        {
            internal bool IsTropic { get; set; }
            internal string Name { get; set; }
        }

        private class Juice
        {
            internal int Price { get; set;}
            internal string Name { get; set; }
            internal Fruit Fruit { get; set; }

            internal Juice(int price, string name, Fruit fruit)
            {
                Price = price;
                Name = name;
                Fruit = fruit;
            }

            public override string ToString()
            {
                return $"Juice Name: {Name}, Price: {Price}";
            }
        }

    }
}
