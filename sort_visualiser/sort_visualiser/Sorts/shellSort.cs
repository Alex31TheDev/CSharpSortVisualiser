using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_visualiser.Sorts
{
    class shellSort : Sort
    {
        public shellSort ()
        {
            name = "Shell Sort";
            id = 5;
        }

        public override void run()
        {
            ShellSort(array, array.Length - 1, 2);
        }

        public void ShellSort(int[] ac, int gap, int divrate)
        {
            double sleepamt = 1d;
            while (gap > 0)
            {
                for (int j = 0; j <= gap - 1; j++)
                {
                    for (int i = j + gap; i < ac.Length; i += gap)
                    {
                        int pos = i;
                        int prev = pos - gap;
                        while (prev >= 0)
                        {
                            if (ac[pos] < ac[prev])
                            {

                                Util. swap(ac, pos, prev);

                            }
                            else
                            {

                                break;
                            }
                            pos = prev;
                            prev = pos - gap;
                        }
                    }
                }

                if (gap == 1) //Done
                    break;

                gap = Math.Max(gap / divrate, 1); //Ensure that we do gap 1
                                                  //sleepamt /= divrate;
            }
        }
    }
}
