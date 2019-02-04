using System;
using System.Collections.Generic;
using ClassLibrary1;

namespace BasicAlgorithms
{
    public class QuickSort : BaseSort
    {
        public override List<int> Sort(List<int> sequence)
        {
            int startIndex = 0;
            int endIndex = sequence.Count - 1;
            int pivotIndex = GetPivotIndexQuickSort(startIndex, endIndex);

            throw new NotImplementedException();
        }
        private static int GetPivotIndexQuickSort(int startIndex, int endIndex)
        {
            return (endIndex - startIndex) / 2;
        }
    }
}