using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insersion_Sort_V1
{
    internal class Sorting
    {

        int j = 1;
        int n = 0;
        public void Sort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int k = j;
                while (k > n)
                {
                    if (array[k] < array[k - 1])
                    {
                        int temp = array[k];
                        array[k] = array[k - 1];
                        array[k - 1] = temp;
                        
                    }
                    k--;

                }
                j++;
                k = j;
            }
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }


        }

    }
}
