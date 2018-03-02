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
            quicksort sort = new quicksort();

            IArrayGenerator a = new RandomArraygenerator();


            int[] arrayToSort = a.generateArray(50000000, 3200);
            
       
            //foreach (var VARIABLE in arrayToSort)
            //{
            //    Console.Write(VARIABLE + " , ");
            //}

            Console.WriteLine();
            double time = sort.sort(arrayToSort);

            //foreach (var VARIABLE in arrayToSort)
            //{
            //    Console.Write(VARIABLE + " , ");
            //}

            Console.WriteLine("sorting took " + time + "miliseconds");
        }
    }
}
