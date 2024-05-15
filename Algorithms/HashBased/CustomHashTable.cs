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

        private const int InitialSize = 10;
        private HashNode[] buckets;

        public CustomHashTable()
        {
            buckets = new HashNode[InitialSize];
        }

        internal void Add(TKey key, TValue value)
        {

        }

        private int GetBucketIndex(TKey key)
        {
            return Math.Abs(key.GetHashCode() % buckets.Length);
        }


    }
}
