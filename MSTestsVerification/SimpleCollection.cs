using System;
using System.Collections;
using System.Collections.Generic;

namespace MSTestsVerification
{
    public class SimpleCollection<T> : ICollection, IEquatable<T>
    {
        private readonly List<T> _elements;

        public SimpleCollection( params T[] elements )
        {
            _elements = new List<T>( elements );
        }

        bool IEquatable<T>.Equals(T other)
        {
            throw new NotSupportedException("IEquatable<T>.Equals should not be invoked by CollectionAssert");
        }

        public override bool Equals(object obj)
        {
            throw new NotSupportedException("Object.Equals should not be invoked by CollectionAssert");
        }

        public override int GetHashCode()
        {
            return _elements.GetHashCode();
        }

        int ICollection.Count
        {
            get
            {
                return _elements.Count;
            }
        }

        bool ICollection.IsSynchronized
        {
            get
            {
                return false;
            }
        }

        object ICollection.SyncRoot
        {
            get
            {
                return _elements;
            }
        }

        void ICollection.CopyTo(Array array, int index)
        {
            ICollection elements = _elements;
            elements.CopyTo(array, index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _elements.GetEnumerator();
        }

    }
}