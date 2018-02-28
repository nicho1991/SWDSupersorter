using System;
using System.Collections;
using System.Diagnostics;

namespace SuperSorter
{
    public abstract class SuperSorter //template pattern
    {
        protected static Stopwatch Sw = new Stopwatch();
        public int Sort(int[] array)
        {
            startTime();
            SortBitch(array);
            endTime();

            return Sw.Elapsed.Milliseconds;
        }

        protected abstract void SortBitch(int[] array);

        void startTime()
        {
            Sw.Start();
        }

        void endTime()
        {
            Sw.Stop();
        }
    }

    public class Quicksort : SuperSorter
    {
        protected override void SortBitch(int[] array)
        {
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

    




    public class Bubblesort : SuperSorter
    {
        protected override void SortBitch(int[] array)
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
