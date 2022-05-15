using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
   public class ShuffleTheArray
    {
        public int[] Shuffle(int[] nums, int n)
        {
            int[] arr = new int[nums.Length];
            int k = 0;
            int i = 0, j = i + n;
            while (i < n)
            {
                arr[k++] = nums[i++];
                arr[k++] = nums[j++];
            }
            return arr;
        }
}
}
