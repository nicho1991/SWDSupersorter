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

            IArrayGenerator a = new FewUniqueArrayGenerator();


            int[] arrayToSort = a.generateArray(200, 3200);
            
       
            //foreach (var VARIABLE in arrayToSort)
            //{
            //    Console.Write(VARIABLE + " , ");
            //}

            Console.WriteLine();
            int time = sort.sort(arrayToSort);

            //foreach (var VARIABLE in arrayToSort)
            //{
            //    Console.Write(VARIABLE + " , ");
            //}

            Console.WriteLine("sorting took " + time + "miliseconds");
        }
    }
}
