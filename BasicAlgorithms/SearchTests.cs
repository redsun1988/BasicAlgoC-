using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicAlgorithms
{
    [TestClass]
    public class SearchTests
    {
        [TestMethod]
        public void LinearSearchTest1()
        {
            int value = 777;
            List<int> source = new List<int>() { 1, 2, 4, 5, 7, 77, 776, 778, 10 };
            int valueIndex = SearchAlgorithms.LinearSearch(source, value);

            Assert.AreEqual(valueIndex, -1);
        }
        [TestMethod]
        public void LinearSearchTest2()
        {
            int value = 777;
            List<int> source = new List<int>() { 1, 2, 4, 5, 7, 77, 776, 778, 10, 777 };
            int valueIndex = SearchAlgorithms.LinearSearch(source, value);

            Assert.AreEqual(valueIndex, source.IndexOf(valueIndex));
        }
    }
}
