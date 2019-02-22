using System.Collections.Generic;
using ClassLibrary1;

namespace BasicAlgorithms
{
    public class StraightSelectionSort: BaseSort
    {
        public StraightSelectionSort()
        {
        }

        public override List<int> Sort(List<int> secquens)
        {
            for (int cursor = 0; cursor< secquens.Count - 1; cursor++)
            {
                int min = secquens[cursor];
                int minIndex = cursor;
                for (int i = cursor; i < secquens.Count; i++)
                {
                    if (min > secquens[i])
                    {
                        min = secquens[i];
                        minIndex = i;
                    }
                }
                if (cursor != minIndex) 
                    Swap(secquens, cursor, minIndex);
            }
            return secquens;
        }
    }
}