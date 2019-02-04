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
                        Swap(secquens, i, i+1);

                        shouldReSort = true;
                    }
                }
            } while (shouldReSort); 
            return secquens;
        }

        private static void Swap(List<int> secquens, int i, int j)
        {
            int itemToMove = secquens[i];
            secquens[i] = secquens[j];
            secquens[j] = itemToMove;
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

        #region StrainghtInsertion
        public static List<int> StrainghtInsertionSort(List<int> sequence)
        {
            List<int> newSeqence = new List<int>();
            return newSeqence;
        }
        #endregion


        public static List<int> QuickSort(List<int> sequence)
        {
            int startIndex = 0;
            int endIndex = sequence.Count - 1;
            int pivotIndex = GetPivotIndexQuickSort(startIndex, endIndex);

            throw new NotImplementedException();
        }

        private static int GetPivotIndexQuickSort(int startIndex, int endIndex)
        {
            return (endIndex - startIndex) / 2;
        }
    }
}
