namespace FSDN.Algorithms
{
    internal class AlgorithmsExample
    {
        //Factorial
        private static int Factorial(int n)
        {
            if (n <= 1) return n;
            return n * Factorial(n - 1);
        }
        private static int Fibonacci(int n)
        {
            // Base cases: the 0th Fibonacci number is 0, and the 1st is 1
            if (n == 0) return 0;
            if (n == 1) return 1;

            // Recursive case: F(n) = F(n-1) + F(n-2)
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        // Method to calculate Fibonacci number using memoization
        private static Dictionary<int, int> memo = new Dictionary<int, int>();

        private static int FibonacciMemo(int n)
        {
            // Check if value is already calculated
            if (memo.ContainsKey(n))
                return memo[n];

            // Base cases
            if (n == 0) return 0;
            if (n == 1) return 1;

            // Calculate and store the result in the dictionary for future reference
            memo[n] = FibonacciMemo(n - 1) + FibonacciMemo(n - 2);
            return memo[n];
        }

        public static void Main(string[] args)
        {
            int x = Factorial(5);
            int y = Fibonacci(5);
            PrintAllFilesAndDirectories("D:\\work");
            Console.WriteLine(y);
        }

        public static void PrintAllFilesAndDirectories(string path)
        {
            // Attempt to get a list of all directories and files from the path
            try
            {
                // Each file in the directory
                string[] files = Directory.GetFiles(path);
                foreach (var file in files)
                {
                    Console.WriteLine("File: " + file);  // Print the file name
                }

                // Each directory retrieved from the given path
                string[] directories = Directory.GetDirectories(path);
                foreach (var directory in directories)
                {
                    Console.WriteLine("Directory: " + directory);  // Print the directory name
                    PrintAllFilesAndDirectories(directory);  // Recursively call this method to print deeper directory contents
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Error accessing " + path + ": " + e.Message);  // Print any errors encountered
            }
        }
    }
}
