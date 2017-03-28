using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Immutable;

namespace MSTestsVerification
{
    [TestClass]
    public class ObjectAssertTests
    {

        [TestMethod]
        public void ImmutableArray_WhenSame()
        {
            ImmutableArray<int> x = ImmutableArray.Create<int>(1, 2, 3);
            Assert.AreEqual(x, x, "Since IEquatable<T> compares references");
        }

        [TestMethod]
        public void ImmutableArray_WhenEqual()
        {
            ImmutableArray<int> x = ImmutableArray.Create<int>(1, 2, 3);
            ImmutableArray<int> y = ImmutableArray.Create<int>(1, 2, 3);
            Assert.AreNotEqual(x, y, "Since IEquatable<T> compares references");
        }

        [TestMethod]
        public void ImmutableArray_WhenDifferentOrder()
        {
            ImmutableArray<int> x = ImmutableArray.Create<int>(1, 2, 3);
            ImmutableArray<int> y = ImmutableArray.Create<int>(3, 2, 1);
            Assert.AreNotEqual(x, y, "Since IEquatable<T> compares references");
        }

        [TestMethod]
        public void ImmutableArray_WhenDifferent()
        {
            ImmutableArray<int> x = ImmutableArray.Create<int>(1, 2, 3);
            ImmutableArray<int> y = ImmutableArray.Create<int>(4, 5, 6);
            Assert.AreNotEqual(x, y, "Since IEquatable<T> compares references");
        }
    }
}
