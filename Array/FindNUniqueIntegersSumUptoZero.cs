using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
   public class FindNUniqueIntegersSumUptoZero
    {
        public int[] SumZero(int n)
        {
            int[] arr = new int[n];
            for (int i = 0; i < n - 1; i += 2)
            {
                arr[i] = i + 1;
                arr[i + 1] = -i - 1;

            }
            if (n % 2 == 1)
            {
                arr[n - 1] = 0;
            }
            return arr;
        }
    }
}

