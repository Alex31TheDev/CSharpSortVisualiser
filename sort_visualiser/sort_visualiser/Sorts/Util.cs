using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace sort_visualiser.Sorts
{
    class Util
    {
        public static void transcribermsd(int[] ac, List<int>[] registers, int min)
        {
            int total = 0;
            foreach (List<int> ai in registers)
                total += ai.Count();
            int tmp = 0;
            for (int ai = registers.Length; ai >= 0; ai--)
            {
                for (int i = registers[ai].Count - 1; i >= 0; i--)
                {
                    ac[total + min - tmp - 1] = registers[ai][i];

                    mainClass.i.marked[1] = total + min - tmp - 1;
                    tmp++;
                    mainClass.i.dT();
                }
            }
        }

        public static void swapnm(int[] ac, int i, int j)
        {


            int temp = ac[i];
            ac[i] = ac[j];
            ac[j] = temp;

            mainClass.i.marked[1] = i;
            mainClass.i.marked[2] = j;
            //mainClass.i.dT();
            //dT();
        }

        public static void swapUpTo(int[] ac, int pos, int to)
        {
            if (to - pos > 0)
                for (int i = pos; i < to; i++)
                    swap(ac, i, i + 1);
            else
                for (int i = pos; i > to; i--)
                    swap(ac, i, i - 1);
           /// mainClass.i.dT();
        }

        public static void swapUpToNM(int[] ac, int pos, int to)
        {
            if (to - pos > 0)
                for (int i = pos; i < to; i++)
                    swapnm(ac, i, i + 1);
            else
                for (int i = pos; i > to; i--)
                    swapnm(ac, i, i - 1);
            mainClass.i. dT();

        }

        public static void swapUp(int[] ac, int pos)
        {
            for (int i = pos; i < ac.Length; i++)
                swap(ac, i, i + 1);


        }

        public static int analyze(int[] ac, int bse)
        {
            int a = 0;
            for (int i = 0; i < ac.Length; i++)
            {
                mainClass.i. marked[1] = i;

                mainClass.i. dT();
                if ((int)(Math.Log(ac[i]) / Math.Log(bse)) > a)
                {
                    a = (int)(Math.Log(ac[i]) / Math.Log(bse));
                }
            }
            return a;
        }
        public static void push(int[] ac, int s, int e)
        {

            for (int i = s; i < e; i++)
            {
                if (ac[i] > ac[i + 1])
                {

                    swap(ac, i, i + 1);
                }
            }


        }
        public static void swap(int[] ac, int i, int j)
        {
            mainClass.i.marked[1] = (i);
            mainClass.i.marked[2] = (j);
            // TODO Auto-generated method stub
            int temp = ac[i];
            ac[i] = ac[j];
            ac[j] = temp;
            mainClass.i.dT();
        }
        public static void percdwn(int[] ac, int pos, bool max, int len)
        {
            int child1 = pos * 2 + 1;
            int child2 = pos * 2 + 2;

            if (child2 >= len)
            {
                if (child1 >= len) //Done
                    return;
                else
                {
                    //Single Child
                    if ((max && (ac[child1] > ac[pos])) || (!max && (ac[child1] < ac[pos])))
                        swap(ac, pos, child1);
                    return;
                }
            }


            if (ac[child1] > ac[child2])
            {
                //Ensure child1 is the smallest for easy programming
                int tmp = child1;
                child1 = child2;
                child2 = tmp;
            }


            if (max && (ac[child2] > ac[pos]))
            {
                swap(ac, pos, child2);
                percdwn(ac, child2, max, len);
            }
            else if (!max && (ac[child1] < ac[pos]))
            {
                swap(ac, pos, child1);
                percdwn(ac, child1, max, len);
            }
        }
        public static int getDigit(int a, int power, int radix)
        {
            return (int)(a / Math.Pow(radix, power)) % radix;
        }
        public static int analyzemax(int[] ac)
        {
            int a = 0;
            for (int i = 0; i < ac.Length; i++)
            {
                if (ac[i] > a)
                    a = ac[i];
                mainClass.i. marked[1] = i;

                mainClass.i. dT();
            }
            return a;
        }

        public static void fancyTranscribe(int[] ac, List<int>[] registers)
        {
            int[] tmp = new int[ac.Length];
            bool[] tmpwrite = new bool[ac.Length];
            int radix = registers.Length;
            transcribenm(registers, tmp);
            for (int i = 0; i < tmp.Length; i++)
            {
                int register = i % radix;
                if (register == 0)
                    Thread.Sleep(radix);//radix
                int pos = (int)(((double)register * ((double)tmp.Length / radix)) + ((double)i / radix));
                if (tmpwrite[pos] == false)
                {
                    ac[pos] = tmp[pos];
                    tmpwrite[pos] = true;
                }

                mainClass.i.marked[register] = pos;
                mainClass.i.dT();
            }
            for (int i = 0; i < tmpwrite.Length; i++)
                if (tmpwrite[i] == false)
                {

                    mainClass.i.marked[i] = tmp[i];
                    mainClass.i.dT();
                }
        }

        public static void transcribenm(List<int>[] registers, int[] array)
        {
            int total = 0;
            for (int ai = 0; ai < registers.Length; ai++)
            {
                for (int i = 0; i < registers[ai].ToArray().Length; i++)
                {
                    array[total] = registers[ai][i];
                    total++;

                }
                registers[ai].Clear();
            }
        }

    }
}
