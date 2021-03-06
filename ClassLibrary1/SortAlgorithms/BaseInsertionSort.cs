﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class BaseInsertionSort : BaseSort
    {
        public override List<int> Sort(List<int> secquens)
        {
            List<int> newSeqence = new List<int>(secquens.Count);
            foreach (int value in secquens)
            {
                int indexToInsert = FindIndextToInsert(newSeqence, value);
                if (indexToInsert >= 0)
                    newSeqence.Insert(indexToInsert, value);
            }
            return newSeqence;
        }

        protected abstract int FindIndextToInsert(List<int> newSeqence, int value);
    }
}
