using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_visualiser.Sorts
{
    class doubleSelectionSort : Sort
    {
        public doubleSelectionSort()
        {
            name = "Double Selection Sort";
            id = 3;
        }

        public override void run()
        {
            DoubleSelectionSort(array);
        }

        public void DoubleSelectionSort(int[] array)
        {
            int i = 0;
            int j = array.Length - 1;
            while (i < j)
            {
                int dummy_index = i;
                int dummy = array[dummy_index];
                for (int k = i; k < j + 1; k++)
                {
                    if (array[k] > dummy)
                    {
                        dummy = array[k];
                        dummy_index = k;
                        dT();
                    }
                }
                int tmp = array[dummy_index];
                array[dummy_index] = array[j];
                array[j] = tmp;
                j--;

                dummy_index = j;
                dummy = array[dummy_index];
                for (int k = j; k > i - 1; k--)
                {
                    if (array[k] < dummy)
                    {
                        dummy = array[k];
                        dummy_index = k;
                        dT();
                    }
                }
                tmp = array[dummy_index];
                array[dummy_index] = array[i];
                array[i] = tmp;
                i++;
            }
        }
    }
}
