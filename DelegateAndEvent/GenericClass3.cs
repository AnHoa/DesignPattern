using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent
{
    class GenericClass3<Tkey, Tvalue> : IDic<Tkey, Tvalue>
    {
        public Tvalue this[Tkey key] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public ICollection<Tkey> Keys => throw new NotImplementedException();

        public ICollection<Tvalue> Values => throw new NotImplementedException();

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(Tkey key, Tvalue value)
        {
            throw new NotImplementedException();
        }

        public void Add(KeyValuePair<Tkey, Tvalue> item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(KeyValuePair<Tkey, Tvalue> item)
        {
            throw new NotImplementedException();
        }

        public bool ContainsKey(Tkey key)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(KeyValuePair<Tkey, Tvalue>[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<KeyValuePair<Tkey, Tvalue>> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(Tkey key)
        {
            throw new NotImplementedException();
        }

        public bool Remove(KeyValuePair<Tkey, Tvalue> item)
        {
            throw new NotImplementedException();
        }

        public bool TryGetValue(Tkey key, out Tvalue value)
        {
            throw new NotImplementedException();
        }

        IEnumerator<Tvalue> IEnumerable<Tvalue>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
