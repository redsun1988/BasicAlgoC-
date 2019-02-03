using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicAlgorithms
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void isEqualsTest()
        {
            List<int> sequence = new List<int> { 3, 5, 1, 3, 9, 11, 0, -1 };
            List<int> targetSequence = sequence.ToList();

            bool isEqualsByElement = SortAlgorithms.EqualsByElements(sequence, targetSequence);

            Assert.IsTrue(isEqualsByElement);
        }

        [TestMethod]
        public void BubleSortTest()
        {
            List<int> sequence = new List<int> { 3, 5, 1, 3, 9, 11, 0, -1 };
            List<int> targetSequence = sequence.OrderBy(r => r).ToList();

            List<int> resultSecquens = SortAlgorithms.BubleSort(sequence);


            bool isSorted = SortAlgorithms.EqualsByElements(resultSecquens, targetSequence);

            Assert.IsTrue(isSorted);
        }
    }
}
