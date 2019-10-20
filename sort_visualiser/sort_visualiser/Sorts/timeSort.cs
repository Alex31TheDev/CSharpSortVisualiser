using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace sort_visualiser.Sorts
{
    class timeSort : Sort
    {
        public timeSort()
        {
            name = "Time Sort";
            id = 13;
        }
        public int mul = 4;
        public override void run()
        {
            TimeSort(array, mul);
        }

        int next;
        public void TimeSort(int[] ac, int magnitude)
        {
            int A = magnitude;
            next = 0;
            List<Thread> threads = new List<Thread>();
            int[] tmp = new int[ac.Length];
            Array.Copy(ac, tmp, ac.Length);
            for (int i = 0; i < ac.Length; i++)
            {
                mainClass.i. marked[0] = i;
                int c = i;


                threads.Add(new Thread(new ThreadStart(() =>
                {
                    int a = tmp[c];

                    Thread.Sleep(a * A);


                    report(ac, a);
                })));



            }

            foreach (Thread t in threads)
                t.Start();
            Thread.Sleep(ac.Length * A);
            dT();
            insertionSort iS = new insertionSort();
            iS.array = array;
            iS.run();
            //countingSort(ac);
        }

        public void report(int[] ac, int a)
        {
            //marked[0] = next;
            ac[next] = a;
            next++;
            //dT();
        }
    }
}
