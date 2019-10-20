using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_visualiser.Sorts
{
    class mergeSortIP : Sort
    {
        public mergeSortIP()
        {
            name = "Merge Sort In Place";
            id = 6;
        }

        public override void run()
        {
            mergeSort(array, 0, array.Length-1);
        }

        void merge(int[] ac, int min, int max, int mid)
        {

            //radixLSDsortnd(2, min, max);


            int i = min;
            while (i <= mid)
            {
                if (ac[i] > ac[mid + 1])
                {

                    Util.swap(ac, i, mid + 1);
                    Util.push(ac, mid + 1, max);
                }
                i++;
            }



        }




        public void mergeSort(int[] ac, int min, int max)
        {
            if (max - min == 0)
            {//only one element.
             //no swap
            }
            else if (max - min == 1)
            {//only two elements and swaps them
                if (array[min] > array[max])
                    Util. swap(ac, min, max);
            }
            else
            {
                int mid = ((int)Math.Floor((double)(min + max) / 2));//The midpoint

                mergeSort(ac, min, mid);//sort the left side
                mergeSort(ac, mid + 1, max);//sort the right side
                merge(ac, min, max, mid);//combines them
            }
        }
    }
}
