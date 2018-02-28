using System;
using System.Collections.Generic;
using System.Text;

namespace SuperSorter
{
    public interface IArrayGenerator //strategy pattern
    {
        int[] generateArray(int n, int seed);
    }


    public class RandomArraygenerator:IArrayGenerator
    {
        public int[] generateArray(int n, int seed)
        {
            Random randomThisShit = new Random(seed);
            int[] theArray = new int[n];

            for (int i = 0; i <n; i++)
            {
                theArray[i] = randomThisShit.Next(0, n);
            }

            return theArray;
        }
    }

    public class NearlySortedArrayGenerator :IArrayGenerator
    {
        public int[] generateArray(int n, int seed)
        {
            Random randomThisShit = new Random(seed);
            int[] theArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                if (i % 5 == 0)
                {
                    theArray[i] = randomThisShit.Next(0, n);
                }
                else
                    theArray[i] = i;
            }

            return theArray;
        }
    }

    public class ReverseOrderArrayGenerator : IArrayGenerator
    {
        public int[] generateArray(int n, int seed)
        {
            int[] theArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                theArray[i] = n - i;
            }

            return theArray;
        }

    }

    public class FewUniqueArrayGenerator : IArrayGenerator
    {
        public int[] generateArray(int n, int seed)
        {
            Random randomThisShit = new Random(seed);

            int[] theArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                if ( i % (n/5)  == 0)
                {
                    theArray[i] = randomThisShit.Next(0, n);
                }
                else
                    theArray[i] = 1;
            }

            //ghaiodfgpoadf'
            foreach (var item in theArray)
            {
                Console.Write(item + " , ");
                
            }
            //dusiaAnfas
            return theArray;
        }
    }
}

