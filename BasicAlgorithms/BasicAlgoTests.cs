using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicAlgorithms
{
    [TestClass]
    public class BasicAlgoTests
    {
        [TestMethod]
        public void isEqualsTest()
        {
            List<int> sequence = new List<int> { 3, 5, 1, 3, 9, 11, 0, -1 };
            List<int> targetSequence = sequence.ToList();

            bool isEqualsByElement = SortAlgorithms.EqualsByElements(sequence, targetSequence);

            Assert.IsTrue(isEqualsByElement);
        }
    }
}
