using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class findValueOfVariableAfterPerformingOperations
    {
        public int FinalValueAfterOperations(string[] operations)
        {
            if (operations.Length == 0 || operations == null)
                return 0;
            int res = 0;
            foreach (var operation in operations)
            {
                if (operation == "++X" || operation == "X++")
                    res = res + 1;

                else
                {
                    res = res - 1;
                }
            }
            return res;
        }
    }
}
