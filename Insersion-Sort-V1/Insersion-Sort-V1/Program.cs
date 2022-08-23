using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insersion_Sort_V1
{
    internal class Program
    {
       
        static void Main(string[] args)

        {
            int[] array = { 15,-2,20,16,30,30,50,-23,0 };
            Sorting k = new Sorting();

            k.Sort(array);
            Console.ReadKey();
        }
    }
}
