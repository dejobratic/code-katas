using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Kata.SearchingAlgorithms.Models
{
    public class PriorityQueue<T> : IEnumerable<T> where T : IComparable<T>
    {
        private readonly List<T> _items;

        public PriorityQueue()
        {
            _items = new List<T>();
        }

        public void Enqueue(T item)
        {
            foreach (var existingItem in _items)
            {
                int comparison = existingItem.CompareTo(item);
                if (comparison == -1) continue;

                int index = _items.IndexOf(existingItem);
                index += comparison == 1 ? 0 : 1;

                _items.Insert(index, item);
                return;
            }

            _items.Add(item);
        }

        public T Dequeue()
        {
            if (_items.Count == 0)
                throw new InvalidOperationException($"Queue is empty.");

            T item = _items[0];
            _items.RemoveAt(0);

            return item;
        }

        public bool IsEmpty()
        {
            return !_items.Any();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

}
