using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_visualiser.Sorts
{
    class inplaceRadixSort : Sort
    {
        public inplaceRadixSort() {
            name = "In Place Radix LSD Sort";
            id = 15;
            }
        public int Base = 10;

        public override void run()
        {
            inPlaceRadixLSDSort(array, Base);
        }

        public void inPlaceRadixLSDSort(int[] ac, int radix)
        {
            int pos = 0;
            int[] vregs = new int[radix - 1];
            int maxpower = Util.analyze(ac, radix);
            double smul = Math.Sqrt(radix);
            for (int p = 0; p <= maxpower; p++)
            {
                for (int i = 0; i < vregs.Length; i++)
                    vregs[i] = ac.Length - 1;
                pos = 0;
                for (int i = 0; i < ac.Length; i++)
                {
                    int digit = Util.getDigit(ac[pos], p, radix);
                    if (digit == 0)
                    {
                        pos++;
                       mainClass.i. marked[0] = pos;
                        //dT();
                    }
                    else
                    {
                        for (int j = 0; j < vregs.Length; j++)
                            mainClass.i.marked[j + 1] = vregs[j];
                        Util. swapUpToNM(ac, pos, vregs[digit - 1]);
                        for (int j = digit - 1; j > 0; j--)
                            vregs[j - 1]--;
                    }
                }

            }
        }
    }
}
