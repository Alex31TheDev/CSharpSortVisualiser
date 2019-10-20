using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_visualiser.Sorts
{
    class bubbleSort : Sort
    {
        public bubbleSort ()
        {
            name = "Bubble Sort";
            id = 0;
        }

        public override void run()
        {
            BubbleSort(array);
        }

        public void BubbleSort(int[] ac)
        {
            for (int i = ac.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {

                    if (ac[j] > ac[j + 1])
                    {

                        Util. swap(ac, j, j + 1);
                    }
                    else
                    {

                       mainClass.i. marked[1] = (j + 1);
                       mainClass.i. marked[2] = -5;
                    }
                }
                //marked.set(0, i);
            }
        }
    }
}
