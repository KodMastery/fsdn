namespace FSDN.OverloadingOverriding
{
    public class OverloadedMethods
    {
        public void Show()
        {
        }

        public void Show(string message)
        {
        }

        public void Show(int number)
        {
        }

        public void Show(string message, int number)
        {
        }

        public void Show(int number, string message)
        {
        }

        public void Show(string message, int number, bool newLine)
        {
        }
    }
}
