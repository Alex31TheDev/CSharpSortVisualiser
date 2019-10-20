using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_visualiser.Sorts
{
    class selectionSort:Sort
    {
        public selectionSort()
        {
            name = "Selection Sort";
            id = 2;
        }

        public override void run()
        {
            SelectionSort(array);
        }

        public void SelectionSort(int[] ac)
        {
            for (int i = 0; i < ac.Length - 1; i++)
            {
                int lowestindex = i;
                for (int j = i + 1; j < ac.Length; j++)
                {
                    if (ac[j] < ac[lowestindex])
                    {
                        lowestindex = j;
                    }
                }
                Util. swap(ac, i, lowestindex);
            }
        }
    }
}
