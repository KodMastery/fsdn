namespace FSDN.Generics
{
    internal class Box<T>
    {
        internal T Content { get; set; }

        internal void PrintContent <S> (S information)
        {
            Console.WriteLine(information);
        }
    }

}
