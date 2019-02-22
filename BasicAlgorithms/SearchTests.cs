using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicAlgorithms.SearchAlgorithms
{
    [TestClass]
    public class SearchTests
    {
        [TestMethod]
        public void lsNoValueTest()
        {
            int value = 777;
            List<int> source = new List<int>() { 1, 2, 4, 5, 7, 77, 776, 778, 10 };
            int valueIndex = SearchAlgorithms.LinearSearch<int>(source, value);

            Assert.AreEqual(valueIndex, -1);
        }
        [TestMethod]
        public void lsListWasNotModifiedTest()
        {
            int value = 777;
            List<int> source = new List<int>() { 1, 2, 4, 5, 7, 77, 776, 778, 10 };

            List<int> copy = source.ToList();
            int valueIndex = SearchAlgorithms.LinearSearch<int>(source, value);

            bool isEqualsByElement = SortAlgorithms.EqualsByElements(source, copy);

            Assert.IsTrue(isEqualsByElement);
        }
        [TestMethod]
        public void LinearSearchTest()
        {
            int value = 777;
            List<int> source = new List<int>() { 1, 2, 4, 5, 7, 77, 776, 778, 10, 777 };
            int valueIndex = SearchAlgorithms.LinearSearch<int>(source, value);

            Assert.AreEqual(valueIndex, source.IndexOf(value));
        }
    }
}
