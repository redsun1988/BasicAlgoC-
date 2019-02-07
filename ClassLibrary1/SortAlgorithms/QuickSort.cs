using System;
using System.Collections.Generic;
using ClassLibrary1;

namespace BasicAlgorithms
{
    public class QuickSort : BaseSort
    {
        public override List<int> Sort(List<int> sequence)
        {
            int start = 0;
            int end = sequence.Count - 1;
            LandSequence(sequence, start, end);
            return sequence;
            //throw new NotImplementedException();
        }

        private void LandSequence(List<int> sequence, int start, int end)
        {
            int pivotIndex = GetPivotIndexQuickSort(start, end);
            int pivotValue = sequence[pivotIndex];
            int l = start;
            int r = end;
            do
            {
                while (sequence[l] < pivotValue) { l++; }
                while (sequence[r] > pivotValue) { r--; }

                if (l <= r)
                {
                    Swap(sequence, l, r);
                    l++;
                    r--;
                }
            } while (l <= r);

            if (start < r) LandSequence(sequence, start, r);

            if (end > l) LandSequence(sequence, l, end);
        }

        private static int GetPivotIndexQuickSort(int startIndex, int endIndex)
        {
            return startIndex + (endIndex - startIndex) / 2;
        }
    }
}