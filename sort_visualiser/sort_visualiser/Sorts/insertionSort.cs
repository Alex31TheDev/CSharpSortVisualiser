using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_visualiser.Sorts
{
    class insertionSort : Sort
    {
        public insertionSort()
        {
            name = "Insertion Sort";
            id = 4;
        }

        public override void run()
        {
            InsertionSort(array);
        }

        public void InsertionSort(int[] ac)
        {
            int pos;
            for (int i = 1; i < ac.Length; i++)
            {
                pos = i;


               mainClass.i. marked[1] = i;
               mainClass.i. marked[2] = -5;
                while (pos > 0 && ac[pos] <= ac[pos - 1])
                {

                    Util.swap(ac, pos, pos - 1);
                    pos--;
                }
            }
        }
    }
}
