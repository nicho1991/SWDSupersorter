using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperSorter;
using SuperSorter = SuperSorter.SuperSorter;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Quicksort sort = new Quicksort();

            IArrayGenerator a = new NearlySortedArrayGenerator();


            int[] arrayToSort = a.GenerateArray(200, 3200);


            foreach (var VARIABLE in arrayToSort)
            {
                Console.Write(VARIABLE + " , ");
            }

            Console.WriteLine();
            var time = sort.Sort(arrayToSort);

            foreach (var VARIABLE in arrayToSort)
            {
                Console.Write(VARIABLE + " , ");
            }

            Console.WriteLine("sorting took " + time + " miliseconds");
        }
    }
}
