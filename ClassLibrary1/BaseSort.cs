using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class BaseSort
    {
        public abstract List<int> Sort(List<int> secquens);
        protected void Swap(List<int> secquens, int i, int j)
        {
            int itemToMove = secquens[i];
            secquens[i] = secquens[j];
            secquens[j] = itemToMove;
        }
    }
}
