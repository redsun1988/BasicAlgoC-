﻿using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicAlgorithms
{
    [TestClass]
    public class SortTests
    {
        [TestMethod]
        public void BubleSortTest()
        {
            List<int> sequence = new List<int> { 3, 5, 1, 3, 9, 11, 0, -1 };
            List<int> targetSequence = sequence.OrderBy(r => r).ToList();

            List<int> resultSecquens = SortAlgorithms.BubleSort(sequence);
            bool isSorted = SortAlgorithms.EqualsByElements(resultSecquens, targetSequence);

            Assert.IsTrue(isSorted);
        }

        [TestMethod]
        public void StraightSelectionSortTest()
        {
            List<int> sequence = new List<int> { 3, 5, 1, 3, 9, 11, 0, -1 };
            List<int> targetSequence = sequence.OrderBy(r => r).ToList();

            List<int> resultSecquens = SortAlgorithms.StraightSelectionSort(sequence);
            bool isSorted = SortAlgorithms.EqualsByElements(resultSecquens, targetSequence);

            Assert.IsTrue(isSorted);
        }


        [TestMethod]
        public void QuickSortTest()
        {
            List<int> sequence = new List<int> { 3, 5, 1, 3, 9, 11, 0, -1 };
            List<int> targetSequence = sequence.OrderBy(r => r).ToList();

            List<int> resultSecquens = SortAlgorithms.QuickSort(sequence);
            bool isSorted = SortAlgorithms.EqualsByElements(resultSecquens, targetSequence);

            Assert.IsTrue(isSorted);
        }

        [TestMethod]
        public void StraightInsertionSortTest()
        {
            List<int> sequence = new List<int> { 3, 5, 1, 3, 9, 11, 0, -1 };
            List<int> targetSequence = sequence.OrderBy(r => r).ToList();

            List<int> resultSecquens = SortAlgorithms.StraightInsertionSort(sequence);
            bool isSorted = SortAlgorithms.EqualsByElements(resultSecquens, targetSequence);

            Assert.IsTrue(isSorted);
        }

        [TestMethod]
        public void BinaryInsertionSortTest()
        {
            List<int> sequence = new List<int> { 3, 5, 1, 3, 9, 11, 0, -1 };
            List<int> targetSequence = sequence.OrderBy(r => r).ToList();

            List<int> resultSecquens = SortAlgorithms.BinaryInsertionSort(sequence);
            bool isSorted = SortAlgorithms.EqualsByElements(resultSecquens, targetSequence);

            Assert.IsTrue(isSorted);
        }
    }
}
