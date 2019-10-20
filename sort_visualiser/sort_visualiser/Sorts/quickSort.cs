using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_visualiser.Sorts
{
    class quickSort : Sort
    {
        public quickSort()
        {
            name = "Quick Sort";
            id = 10;
        }

        public override void run()
        {
            QuickSort(array, 0, array.Length - 1);
        }

        public void QuickSort(int[] ac, int p, int r)
        {
            if (p < r)
            {
                int q = partition(ac, p, r);

                QuickSort(ac, p, q);
                QuickSort(ac, q + 1, r);
            }
        }

        public int partition(int[] ac, int p, int r)
        {

            int x = ac[p];
            int i = p - 1;
            int j = r + 1;

            while (true)
            {
                //sleep(0.);
                i++;
                while (i < r && ac[i] < x)
                {
                    i++;

                    mainClass.i.marked[1] = j;

                }
                j--;
                while (j > p && ac[j] > x)
                {
                    j--;
                   mainClass.i. marked[2] = j;
                }

                if (i < j)
                   Util. swap(ac, i, j);
                else
                    return j;
            }
        }
    }
}
