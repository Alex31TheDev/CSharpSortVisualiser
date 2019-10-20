using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_visualiser.Sorts
{
    class gravitySort : Sort
    {
        public gravitySort()
        {
            name = "Gravity Sort";
            id = 12;
        }

        public override void run()
        {
            GravitySort(array);
        }

        public void GravitySort(int[] array)
        {
            int max = Util.analyzemax(array);
            int[][] abacus = new int[array.Length][];

            for (int i = 0; i < abacus.Length; i++)
            {
                abacus[i] = new int[max];
            }

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i]; j++)
                    abacus[i][abacus[0].Length - j - 1] = 1;
                mainClass.i. marked[1] = i;
                dT();
            }
            //apply gravity
            for (int i = 0; i < abacus[0].Length; i++)
            {


                for (int j = 0; j < abacus.Length; j++)
                {
                    if (abacus[j][i] == 1)
                    {
                        //Drop it
                        int droppos = j;
                        while (droppos + 1 < abacus.Length && abacus[droppos][i] == 1)
                            droppos++;
                        if (abacus[droppos][i] == 0)
                        {
                            abacus[j][i] = 0;
                            abacus[droppos][i] = 1;

                        }
                    }
                }



                int count = 0;
                for (int x = 0; x < abacus.Length; x++)
                {
                    count = 0;
                    for (int y = 0; y < abacus[0].Length; y++)
                        count += abacus[x][y];
                    array[x] = count;
                    //marked.Add(count);
                    // sleep(0.002);
                }
                mainClass.i.marked[1] = array.Length - i - 1;
                dT();







            }

        }
    }
}
