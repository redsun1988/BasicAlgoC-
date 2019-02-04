using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class BubleSort : BaseSort
    {
        public override List<int> Sort(List<int> secquens)
        {
            bool shouldReSort = false;
            do
            {
                shouldReSort = false;
                for (int i = 0; i < secquens.Count - 1; i++)
                {
                    if (secquens[i] > secquens[i + 1])
                    {
                        Swap(secquens, i, i + 1);
                        shouldReSort = true;
                    }
                }
            } while (shouldReSort);
            return secquens;
        }
    }
}
