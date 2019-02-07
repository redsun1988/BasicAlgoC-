using System.Collections.Generic;
using ClassLibrary1;

namespace BasicAlgorithms
{
    public class BinaryInsertionSort: BaseInsertionSort
    {
        public BinaryInsertionSort()
        {
        }

        protected override int FindIndextToInsert(List<int> newSeqence, int value)
        {
            int left = 0;
            int right = newSeqence.Count;
            int midle = (left + right) / 2;

            while (left < right)
            {
                if (value < newSeqence[midle])
                    right = midle;
                else
                    left = midle + 1;

                midle = (left + right) / 2;
            }
            return midle;
        }
    }
}