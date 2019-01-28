using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    public class SortAlgorithms
    {
        public static List<int> BubleSort(List<int> secquens)
        {
            throw new NotImplementedException();
        }

        public static bool EqualsByElements<T>(List<T> collection1, List<T> collection2)
        {
            if (collection1.Count != collection2.Count)
                return false;
            else
            {
                int count = collection1.Count;
                for (int i = 0; i < count; i++)
                {
                    if (! collection1[i].Equals(collection2[i]))
                        return false;
                }
                return true;
            }
        }
    }
}
