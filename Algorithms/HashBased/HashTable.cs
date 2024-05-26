namespace FSDN.Algorithms.HashBased
{
    internal class HashTable<K, V>
    {
        private class Node
        {
            internal K Key { get; set; }
            internal V Value { get; set; }
            internal Node Next { get; set; }

            internal Node(K key, V value)
            {
                Key = key;
                Value = value;
            }
        }

        private int capacity; 
        private Node[] buckets;

        internal HashTable()
        {
            capacity = 100;
            buckets = new Node[capacity];
        }

        internal void Add(K key, V value)
        {
            int keyHashCode = key.GetHashCode();
            int lastDigit = Math.Abs(keyHashCode % capacity);
            Node bucketNode = buckets[lastDigit];
            Node nodeToAdd = new Node(key, value);
            if (bucketNode == null)
            {
                buckets[lastDigit] = nodeToAdd;
            }
            else
            {
                bool exists = false;
                while (bucketNode.Next != null)
                {
                    if (bucketNode.Key.Equals(key))
                    {
                        exists = true;
                        bucketNode.Value = value;
                        break;
                    }
                    bucketNode = bucketNode.Next;
                }

                if (!exists)
                {
                    bucketNode.Next = nodeToAdd;
                }
            }
        }

        internal void Remove(K key)
        {
            int keyHashCode = key.GetHashCode();
            int bucketIndex = Math.Abs(keyHashCode % capacity);
            Node bucketNode = buckets[bucketIndex];
            Node prevNode = null;
            while (bucketNode != null)
            {
                if (bucketNode.Key.Equals(key))
                {
                    if (prevNode == null)
                    {
                        buckets[bucketIndex] = bucketNode.Next;
                    }
                    else
                    {
                        prevNode.Next = bucketNode.Next;
                    }

                    break;
                }
                prevNode = bucketNode;
                bucketNode = bucketNode.Next;
            }
        }

        internal V Get(K key)
        {
            int keyHashCode = key.GetHashCode();
            int bucketIndex = Math.Abs(keyHashCode % capacity);
            Node bucketNode = buckets[bucketIndex];
            while (bucketNode != null)
            {
                if (bucketNode.Key.Equals(key))
                {
                    return bucketNode.Value;
                }
                bucketNode = bucketNode.Next;
            }

            throw new NullReferenceException();
        }

    }
}
