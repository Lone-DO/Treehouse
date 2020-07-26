using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace GenericsDemo
{
    class EnumberableCompositor<T> : IEnumerable<T>
    {
        private List<IEnumerable<T>> _collections;

        public void Add(IEnumerable<T> collection)
        {
            _collections.Add(collection);
        }

        public EnumberableCompositor()
        {
            _collections = new List<IEnumerable<T>>();
        }
        public EnumberableCompositor(IEnumerable<IEnumerable<T>> collections)
        {
            _collections = collections.ToList();
        }
        public IEnumerator<T> GetEnumerator()
        {
            foreach(var collection in _collections)
            {
                foreach(var item in collection)
                {
                    yield return item;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
}
