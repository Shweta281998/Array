using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
  public  class HowManyNumbersareSmallerThancurrentNumber
    {
        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            int[] arr = new int[nums.Length];
            int count = 0, k = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j] && i != j)
                        count++;
                }
                arr[i] = count;
                count = 0;

            }
            return arr;
        }

        //optimize

        public int[] SmallerNumbersThanCurrent1(int[] nums)
        {
            List<int> list = new List<int>(nums);
            list.Sort();
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (!dict.ContainsKey(list[i]))
                    dict.Add(list[i], i);


            }
            int[] output = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                output[i] = dict[nums[i]];
            }
            return output;
        }
    }
}
