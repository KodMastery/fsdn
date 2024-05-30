using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSaloonCLI
{
    internal class CarSaloon
    {
        internal string Name { get; set; }
        internal ISet<Car> Cars { get; set; }

        internal CarSaloon(string name, ISet<Car> cars)
        {
            Name = name;
            Cars = cars;
        }

        public override string ToString()
        {
            string result = Name + "\n";
            result += "Cars: \n";
            int counter = 1;

            foreach (Car car in Cars)
            {
                result += counter++ + ". " + car.ToString() + "\n";
            }

            return result;
        }
    }
}
