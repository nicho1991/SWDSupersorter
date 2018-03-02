using System;
using System.Collections;
using System.Diagnostics;

namespace SuperSorter
{
    public abstract  class SuperSorter //template pattern
    {
        protected static Stopwatch sw = new Stopwatch();
        public double sort(int[] array)
        {
            startTime();
            sortBitch(array);
            endTime();

            return sw.Elapsed.TotalMilliseconds;
        }

        protected abstract void sortBitch(int[] array);

        void startTime()
        {
            sw.Start();
        }

        void endTime()
        {
            sw.Stop();
        }
    }

    public class quicksort : SuperSorter
    {
        protected override void sortBitch(int[] array)
        {
            Console.WriteLine("sorting started");
            QuickSort(array,0,array.Length-1);
        }

        private void QuickSort(int[] a, int start, int end)
        {
            if (start >= end)
            {
                return;
            }

            int num = a[start];

            int i = start, j = end;

            while (i < j)
            {
                while (i < j && a[j] >= num)
                {
                    j--;
                }

                a[i] = a[j];

                while (i < j && a[i] < num)
                {
                    i++;
                }

                a[j] = a[i];
            }

            a[i] = num;
            QuickSort(a, start, i - 1);
            QuickSort(a, i + 1, end);
        }
    }

    




    public class bubblesort : SuperSorter
    {
        protected override void sortBitch(int[] array)
        {
            int t;
            for (int p = 0; p <= array.Length - 2; p++)
            {
                for (int i = 0; i <= array.Length - 2; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        t = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = t;
                    }
                }
            }

        }
    }
}
