namespace FSDN.Algorithms.HashMap
{
    internal class CustomHashTable<TKey, TValue>
    {
        private class HashNode
        {
            internal TKey Key { get; set; }
            internal TValue Value { get; set; }
            internal HashNode Next { get; set; }
            internal HashNode(TKey key, TValue value)
            {
                Key = key;
                Value = value;
            }
        }


    }
}
