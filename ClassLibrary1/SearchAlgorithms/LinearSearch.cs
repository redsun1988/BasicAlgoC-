using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.SearchAlgorithms
{
    public class LinearSearch : BaseSearch
    {
        public override int Search(List<int> secquens, int value)
        {
            for (int i = 0; i < secquens.Count; i++)
                if (secquens[i] == value)
                    return i;
            return -1;
        }
    }
}
