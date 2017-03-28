using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Immutable;

namespace MSTestsVerification
{
    [TestClass]
    public class CollectionAssertTests
    {

        [TestMethod]
        public void ImmutableArray_WhenEqual()
        {
            ImmutableArray<int> x = ImmutableArray.Create<int>(1, 2, 3);
            ImmutableArray<int> y = ImmutableArray.Create<int>(1, 2, 3);
            CollectionAssert.AreEqual(x, y);
        }

        [TestMethod]
        public void ImmutableArray_WhenDifferentOrder()
        {
            ImmutableArray<int> x = ImmutableArray.Create<int>(1, 2, 3);
            ImmutableArray<int> y = ImmutableArray.Create<int>(3, 2, 1);
            CollectionAssert.AreNotEqual(x, y);
        }

        [TestMethod]
        public void ImmutableArray_WhenDifferent()
        {
            ImmutableArray<int> x = ImmutableArray.Create<int>(1, 2, 3);
            ImmutableArray<int> y = ImmutableArray.Create<int>(4, 5, 6);
            CollectionAssert.AreNotEqual(x, y);
        }

        [TestMethod]
        public void SimpleCollection_WhenEqual()
        {
            SimpleCollection<int> x = new SimpleCollection<int>(1, 2, 3);
            SimpleCollection<int> y = new SimpleCollection<int>(1, 2, 3);
            CollectionAssert.AreEqual(x, y);
        }

        [TestMethod]
        public void SimpleCollection_WhenDifferentOrder()
        {
            SimpleCollection<int> x = new SimpleCollection<int>(1, 2, 3);
            SimpleCollection<int> y = new SimpleCollection<int>(3, 2, 1);
            CollectionAssert.AreNotEqual(x, y);
        }

        [TestMethod]
        public void SimpleCollection_WhenDifferent()
        {
            SimpleCollection<int> x = new SimpleCollection<int>(1, 2, 3);
            SimpleCollection<int> y = new SimpleCollection<int>(4, 5, 6);
            CollectionAssert.AreNotEqual(x, y);
        }
    }
}
