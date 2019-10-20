using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_visualiser.Sorts
{
    class waveMergeSort : Sort
    {
        public waveMergeSort()
        {
            name = "Wave Merge Sort";
            id = 8;
        }

        public override void run()
        {
            weaveMergeSort(array, 0, array.Length - 1);
        }

        void weaveMerge(int[] ac, int min, int max, int mid)
        {

            //radixLSDsortnd(2, min, max);

            int i = 1;
            int target = (mid - min);
            while (i <= target)
            {
                //swapUpTo(mid+(i-min), min+(i-min)*2, 0.01);
                Util.swapUpTo(ac, mid + i, min + i * 2 - 1);
                i++;

            }
            insertionSort(ac, min, max + 1);
            //sleep(100);


        }

        public void weaveMergeSort(int[] ac, int min, int max)
        {
            if (max - min == 0)
            {//only one element.
             //no swap
            }
            else if (max - min == 1)
            {//only two elements and swaps them
                if (ac[min] > ac[max])
                   Util. swap(ac, min, max);
            }
            else
            {
                int mid = ((int)Math.Floor((double)(min + max) / 2));//The midpoint

                weaveMergeSort(ac, min, mid);//sort the left side
                weaveMergeSort(ac, mid + 1, max);//sort the right side
                weaveMerge(ac, min, max, mid);//combines them
            }
        }

        public void insertionSort(int[] ac, int start, int end)
        {
            int pos;
            for (int i = start; i < end; i++)
            {
                pos = i;

               mainClass.i. marked[1] = i;
               mainClass.i. marked[2] = -5;
                while (pos > start && ac[pos] <= ac[pos - 1])
                {

                   Util. swap(ac, pos, pos - 1);

                    pos--;
                }
            }
        }
    }
}
