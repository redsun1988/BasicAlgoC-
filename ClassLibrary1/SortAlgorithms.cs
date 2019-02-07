using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    public static class SortAlgorithms
    {
        static readonly BubleSort _BubleSort = new BubleSort();
        static readonly StraightInsertionSort _StraightInsertionSort = new StraightInsertionSort();
        static readonly QuickSort _QuickSort = new QuickSort();
        static readonly BinaryInsertionSort _BinaryInsertionSort = new BinaryInsertionSort();
        static readonly StraightSelectionSort _StraightSelectionSort = new StraightSelectionSort();

        public static List<int> BubleSort(List<int> sequence)
        {
            return _BubleSort.Sort(sequence);
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

        public static List<int> StraightInsertionSort(List<int> sequence)
        {
            return _StraightInsertionSort.Sort(sequence);
        }

        public static List<int> StraightSelectionSort(List<int> sequence)
        {
            return _StraightSelectionSort.Sort(sequence);
        }

        public static List<int> QuickSort(List<int> sequence)
        {
            return _QuickSort.Sort(sequence);
        }

        public static List<int> BinaryInsertionSort(List<int> sequence)
        {
            return _BinaryInsertionSort.Sort(sequence);
        }
    }
}
