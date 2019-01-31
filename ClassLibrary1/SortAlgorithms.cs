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
            bool shouldReSort = false;
            do
            {
                shouldReSort = false;
                for (int i =0; i < secquens.Count - 1; i++)
                {
                    if (secquens[i] > secquens[i+1])
                    {
                        int itemToMove = secquens[i];
                        secquens.RemoveAt(i);
                        secquens.Insert(i + 1, itemToMove);

                        shouldReSort = true;
                    }
                }
            } while (shouldReSort); 
            return secquens;
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
