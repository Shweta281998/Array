using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
   public class ConcatenationOfArray
    {
        public int[] GetConcatenation(int[] nums)
        {
            int[] arr = new int[2 * nums.Length];
            int n = nums.Length;
            for (int i = 0; i < nums.Length; i++)
            {
                arr[i] = nums[i];
                arr[i + n] = nums[i];
            }
            return arr;
        }
    }
}

