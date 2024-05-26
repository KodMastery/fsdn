using FSDN.Algorithms.LinkedList;

namespace FSDN.Algorithms.Stack
{
    internal class CustomStack<T>
    {

        private DoublyLinkedList<T> list = new DoublyLinkedList<T>();

        //methods
        internal void Push(T element)
        {
            //Add Last Node to Linked List
            list.AddLast(element);
        }

        internal T Pop()
        {
            T element = list.RemoveLast();
            return element;
        }

        internal T Peek()
        {
            return list.GetLast();
        }

        internal void PrintStack()
        {
            list.PrintList();
        }
    }
}
