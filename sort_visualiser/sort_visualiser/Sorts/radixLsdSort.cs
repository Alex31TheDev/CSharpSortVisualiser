using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_visualiser.Sorts
{
    class radixLsdSort :Sort
    {
        public radixLsdSort ()
        {
            name = "Radix LSD Sort";
            id = 14;
        }

        public override void run()
        {
            radixLSDsort(array, Radix);
        }

        public int Radix = 4;
        public void radixLSDsort(int[] ac, int radix)
        {

            int highestpower = Util.analyze(ac, radix);
            List<int>[] registers = new List<int>[radix];
            for (int i = 0; i < radix; i++)
                registers[i] = new List<int>();
            for (int p = 0; p <= highestpower; p++)
            {
                for (int i = 0; i < ac.Length; i++)
                {
                   mainClass.i. marked[1] = i;
                    if (i % 2 == 0)
                        dT();
                    registers[Util.getDigit(ac[i], p, radix)].Add(ac[i]);
                }
                Util.fancyTranscribe(ac, registers);
            }
        }
    }
}
