using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_visualiser.Sorts
{
    class countingSort :Sort
    {
        public countingSort()
        {
            name = "Counting Sort";
            id = 11;
        }

        public override void run()
        {
            CountingSort(array);
        }

        public void CountingSort(int[] ac)
        {
            int max = Util.analyzemax(ac);
            int[] counts = new int[max + 1];
            for (int i = 0; i < ac.Length; i++)
            {
                mainClass.i.marked[1] = (i);

                counts[ac[i]]++;
                dT();
            }
            int x = 0;
            for (int i = 0; i < ac.Length; i++)
            {
                if (counts[x] == 0)
                    x++;
                ac[i] = x;
                counts[x]--;
                mainClass.i. marked[1] = i;
                dT();
            }
        }
    }
}
