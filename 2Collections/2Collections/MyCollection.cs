using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Collections
{
    public class MyCollection<T>: CollectionBase
    {
        public void Add(T item)
        {
            base.InnerList.Add(item);
        }

        public void Remove(T item)
        {
            base.List.Remove(item);
        }

        public new void Clear()
        {
            base.List.Clear();
        }

        public new int Count()
        {
            return base.List.Count;
        }

        public void Insert(int index, T item)
        {
            base.List.Insert(index, item);
        }

        public bool Contains(T value)
        {
            return (base.List.Contains(value));
        }
    }
}
