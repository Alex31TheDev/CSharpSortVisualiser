using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_visualiser.Sorts
{
    class mergeSort : Sort
    {
        public mergeSort ()
        {
            name = "Merge Sort";
            id = 7;
        }

        public override void run()
        {
            mergeSortOP(array);
        }

        public void mergeSortOP(int[] ac)
        {
            int start = 0;
            int end = ac.Length;
            int mid = (end + start) / 2;
            mergeOP(ac, start, mid, end);
        }

        public void mergeOP(int[] ac, int start, int mid, int end)
        {
            if (start == mid)
                return;
            mergeOP(ac, start, (mid + start) / 2, mid);
            mergeOP(ac, mid, (mid + end) / 2, end);

            int[] tmp = new int[end - start];

            int low = start;
            int high = mid;
            for (int nxt = 0; nxt < tmp.Length; nxt++)
            {
                if (low >= mid && high >= end)
                    break;
                if (low < mid && high >= end)
                {
                    tmp[nxt] = ac[low];
                    low++;

                }
                else if (low >= mid && high < end)
                {
                    tmp[nxt] = ac[high];
                    high++;
                }
                else if (ac[low] < ac[high])
                {
                    tmp[nxt] = ac[low];
                    low++;
                }
                else
                {
                    tmp[nxt] = ac[high];
                    high++;
                }


               mainClass.i. marked[1] = low;
               mainClass.i. marked[2] = high;
                //if(end-start>=array.Length/10)
                dT();
            }
            //System.arraycopy(tmp, 0, array, start, tmp.length);
            mainClass.i.marked[2] = -5;
            for (int i = 0; i < tmp.Length; i++)
            {
                ac[start + i] = tmp[i];

                mainClass.i.marked[1] = start + i;
                if (end - start >= ac.Length / 100)
                    dT();
            }
        }
    }
}
