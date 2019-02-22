using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms.SearchAlgorithms
{
    public class LinearSearch : BaseSearch
    {
        public override int Search<T>(List<T> secquens, T value)
        {
            var index = 0;
            int count = secquens.Count;

            //Add terminal value 
            secquens.Add(value);

            //How to remove ! ???
            while (!secquens[index].Equals(value)) {
                index++;
            }
            //Remove terminal value
            secquens.RemoveAt(count);

            if (index == count)
                return -1;
            else
                return index;
        }
    }
}
