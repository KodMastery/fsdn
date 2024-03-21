namespace FSDN.OverloadingOverriding
{
    internal class InvalidOverloading
    {
        public int GetValue(int x)
        {
            return x;
        }

        // INVALID EXAMPLES (Method Signatures Only):

        // Attempt to overload based on return type - INVALID
        //public double GetValue(int x);

        // Attempt to overload based on access modifier - INVALID
        //private int GetValue(int x);

        // Attempt to overload based on parameter name - INVALID
        //public int GetValue(int y);
    }

}
