using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms.SearchAlgorithms
{
    public abstract class BaseSearch
    {
        public abstract int Search<T>(List<T> secquens, T value);
    }
}
