using ClassLibrary1.SearchAlgorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class StrainghtInsertionSort : BaseInsertionSort
    {
        public StrainghtInsertionSort()
        {
        }
        protected override int FindIndextToInsert(List<int> newSeqence, int value)
        {
            int i = 0;
            
            while (i < newSeqence.Count && newSeqence[i] < value)
            {
                i += 1;
            }

            return i;
        }
    }
}
