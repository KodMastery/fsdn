namespace FSDN.Algorithms
{
    internal class AlgorithmsFsdn
    {
        public static void Main(string[] args)
        {
            PrintDirectoryContentsRecursively("D:\\work");
        }

        private static int Factorial(int n)
        {
            if (n <= 0) return 1;
            return n * Factorial(n - 1);
        }

        private static int Fibonacci(int n)
        {
            if (n <= 0) return 0;
            if (n == 1) return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        private static IDictionary<long, long> memory = new Dictionary<long, long>();
        private static long MemoizedFibonacci(int n)
        {
            if (n <= 0) return 0;
            if (n == 1) return 1;
            if (memory.ContainsKey(n)) return memory[n];
            memory[n] = MemoizedFibonacci(n - 1) + MemoizedFibonacci(n - 2);
            return memory[n];
        }

        private static void PrintDirectoryContentsRecursively(string path)
        {
           
                //get all files on the current path
               string[] files =  Directory.GetFiles(path);
               
               //print all files
               foreach (var file in files)
               {
                   Console.WriteLine(file);
               }

               string[] folders = Directory.GetDirectories(path);
               foreach (var folder in folders)
               {
                    Console.WriteLine(folder);
                    PrintDirectoryContentsRecursively(folder);
               }
        }
            
        }
    
}
