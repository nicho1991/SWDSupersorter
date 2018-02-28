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

            var arrayToSort = a.GenerateArray(200, 3200);

            Console.WriteLine("\nPrinting unsorted array:\n");

            PlzPrint(arrayToSort);

            Console.WriteLine("\n\nPrinting sorted array:\n");

            var time = sort.Sort(arrayToSort);

            PlzPrint(arrayToSort);

            Console.WriteLine("\n\nSorting took " + time + " miliseconds\n");
        }

        private static void PlzPrint(IEnumerable<int> arrayToSort)
        {
            foreach (var variable in arrayToSort)
            {
                Console.Write(variable + " , ");
            }
        }
    }
}
