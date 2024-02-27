namespace FSDN.FlowControl

{
    internal class FlowControlMain
    {
        //if-else


        internal void CheckNumbersBiggerThanZ(int x, int y, int z)
        {
            if (x + y > z)
            {
                Console.WriteLine($"They are bigger than {z}");
            }
            else if (x + y == z)
            {
                Console.WriteLine("They are equal");
            }
            else
            {
                Console.WriteLine("They are smaller");
            }
        }

        //SWITCH statement -> Print the day
        internal void PrintDay(string day) {
            switch (day)
            {
                case "Monday":
                    Console.WriteLine("Its MONDAY!!!");
                    break;
                case "Tuesday":
                    Console.WriteLine("Its tuesday");
                    break;
                default: 
                 Console.WriteLine($"It's {day}");
                    break;
            }
        }

        // For loop
        // Loop 8 times and Print out the ITERATOR value
        internal void PrintNumbers()
        {
            /*
             * i = 0
             * 1. 0 < 8
             * iterate while i < 8
             */
            for (int i = 0; i < 8; i+=10)
            {
                if (i == 4)
                {
                    break;
                } else
                {
                    Console.WriteLine(i);
                }
            }
        }

        string allInOne = "";
        internal void PrintSeasons()
        { 
            foreach (Season season in Enum.GetValues(typeof(Season)))
            {
              allInOne = allInOne + season + " ";
            }
            Console.WriteLine(allInOne);
            
        }

    }

}
