using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Assignment6
{
    public class MultiMap<TKey, TValue> : IDictionary
    {
        List<TKey> keys;
        List<List<TValue>> values;
        int count;

        public int Count { get { return count;} }
        
        public MultiMap()
        {
            if (typeof(TKey) == typeof(TValue))
            {
                throw new Exception("Please enter different Key-Value types");
            }
            this.keys = new List<TKey>();
            this.values = new List<List<TValue>>();
            this.count = 0;
        }

        public void Add(object key, object value)
        {
            if (!this.keys.Contains((TKey)key))
            {
                count++;
                this.keys.Add((TKey)key);
                values.Add(new List<TValue>());
            }

            int index = 0;
            foreach (var item in keys)
            {
                if (item.ToString() == key.ToString())
                {
                    this.values[index++].Add((TValue)value);
                    break;
                }
                index++;
            }
        }
        public void Print()
        {
            int index = 0;
            foreach (var itemKey in this.keys)
            {
                Console.WriteLine("Key[" + itemKey.ToString() + "]");
                foreach (var itemValue in values[index])
                {
                    Console.WriteLine(itemValue);
                }
                Console.WriteLine();
                index++;
            }
        }
        public void Clear()
        {
            foreach (var item in this.values)
            {
                item.Clear();
            }
            values.Clear();
            keys.Clear();
            this.count = 0;
        }
        public object this[object key]
        {
            get
            {
                int index = 0;
                foreach (var item in this.keys)
                {
                    if (item.ToString() == key.ToString()) return values[index];
                    index++;
                }
                return null;
            }
            set
            {
                int index = 0;
                foreach (var item in this.keys)
                {
                    if (item.ToString() == key.ToString())
                    {
                        values[index].Clear();
                        values[index] = (List<TValue>) value;
                    }
                    index++;
                }
            }
        }
        public bool Contains(object key)
        {
            foreach (var item in keys)
            {
                if (item.ToString() == key.ToString()) return true;
            }
            return false;
        }
        public void Remove(object key)
        {
            for (int i = 0; i < this.keys.Count; ++i)
            {
                if (this.keys[i].ToString() == key.ToString())
                {
                    this.count--;
                    values[i].Clear();
                    this.keys[i] = default(TKey);//NULL of TKey
                    if (i != this.keys.Count - 1)
                    {
                        for (int j = i; j < this.keys.Count - 1; j++)
                        {
                            this.keys[j] = this.keys[j + 1];
                            this.values[j] = this.values[j + 1];
                        }
                        values.Remove(values[this.keys.Count - 1]);
                        this.keys.Remove(this.keys[this.keys.Count - 1]);
                    }
                }
            }
        }
        public ICollection Keys
        {
            get
            {
                return this.keys;
            }
        }
        public ICollection Values
        {
            get
            {
                return this.values;
            }
        }
        public bool IsReadOnly { get { return false; } }
        public bool IsFixedSize { get { return false; } }
        public object SyncRoot
        {
            get;
        }
        public bool IsSynchronized { get { return false; } }

        public void CopyTo(Array array, int index)
        {
            int i=0;
            foreach (var item in values[index])
            {
                array.SetValue(item,i++);
            }
        }

        public IDictionaryEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IDictionary)this).GetEnumerator();// (brndzel em)
        }
    }
}