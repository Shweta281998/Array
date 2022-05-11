using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class RichestCustomerWealth
    {
        public int MaximumWealth(int[][] accounts)
        {
            int max = 0;
            for (int i = 0; i < accounts.Length; i++)
            {
                int sum = 0;
                for (int j = 0; j < accounts[i].Length; j++)
                {

                    sum = sum + accounts[i][j];
                    max = Math.Max(sum, max);
                }
            }
            return max;
        }
    }
}
