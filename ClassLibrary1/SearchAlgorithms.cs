using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms.SearchAlgorithms
{
    public static class SearchAlgorithms
    {
        static LinearSearch _lSearch = new LinearSearch();
        public static int LinearSearch<T>(List<T> source, T value)
        {
            return _lSearch.Search<T>(source, value);
        }
    }
}
