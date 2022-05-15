using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class KidswithGreaterNumberOfCandies
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            List<bool> list = new List<bool>();
            int max = candies.Max();
            for (int i = 0; i < candies.Length; i++)
            {
                if (candies[i] + extraCandies >= max)
                    list.Add(true);

                else
                {
                    list.Add(false);
                }
            }
            return list;
        }
    }
}
