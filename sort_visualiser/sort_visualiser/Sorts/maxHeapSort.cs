using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_visualiser.Sorts
{
    class maxHeapSort : Sort
    {
        public maxHeapSort()
        {
            name = "Max Heap Sort";
            id = 9;
        }

        public override void run()
        {
            maxheapsort(array);
        }

        void maxheapifyrec(int[] ac, int pos, bool max)
        {
            if (pos >= ac.Length)
                return;

            int child1 = pos * 2 + 1;
            int child2 = pos * 2 + 2;

            maxheapifyrec(ac, child1, max);
            maxheapifyrec(ac, child2, max);

            if (child2 >= ac.Length)
            {
                if (child1 >= ac.Length)
                    return; //Done, no children
                if (ac[child1] > ac[pos])
                    Util.swap(ac, pos, child1);
                return;
            }

            //Find largest child
            int lrg = child1;
            if (ac[child2] > ac[child1])
                lrg = child2;

            //Swap with largest child
            if (ac[lrg] > ac[pos])
            {
                Util.swap(ac, pos, lrg);
                Util.percdwn(ac, lrg, true, ac.Length);
                return;
            }
        }

        public void maxheapsort(int[] ac)
        {
            maxheapifyrec(ac, 0, true);
            for (int i = ac.Length - 1; i > 0; i--)
            {
                Util.swap(ac, 0, i);
                Util. percdwn(ac, 0, true, i);
            }
        }
    }
}
