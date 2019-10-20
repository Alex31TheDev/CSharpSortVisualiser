using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_visualiser.Sorts
{
    class radixMsdSort : Sort
    {
        public radixMsdSort ()
        {
            name = "Radix MSD Sort";
            id = 16;
        }
        public int Radix = 8;

        public override void run()
        {
            radixMSDSort(array, Radix);
        }

        public void radixMSDSort(int[] ac, int radix)
        {
            int highestpower = Util.analyze(ac, radix);
            int[] tmp = new int[ac.Length];
            Array.Copy(ac, tmp, ac.Length);
            radixMSDRec(ac, 0, ac.Length - 1, radix, highestpower);
        }

        public void radixMSDRec(int[] ac, int min, int max, int radix, int pow)
        {
            if (min >= max || pow < 0)
                return;
            mainClass.i.marked[2] = max;
            mainClass.i.marked[3] = min;
            dT();
            List<int>[] registers = new List<int>[radix];
            for (int i = 0; i < radix; i++)
                registers[i] = new List<int>();
            for (int i = min; i < max; i++)
            {
               mainClass.i. marked[1] = i;
                registers[Util.getDigit(ac[i], pow, radix)].Add(ac[i]);
                //dT();
            }
            Util.transcribermsd(ac, registers, min);

            int sum = 0;
            for (int i = 0; i < registers.Length; i++)
            {
                radixMSDRec(ac, sum + min, sum + min + registers[i].Count, radix, pow - 1);
                sum += registers[i].Count;
                registers[i].Clear();
            }
        }
    }
}
