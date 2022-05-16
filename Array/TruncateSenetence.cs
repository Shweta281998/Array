using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
   public class TruncateSenetence
    {
        public string TruncateSentence(string s, int k)
        {
            if (s == null && s == string.Empty)
                return s;
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                    count++;

                if (count == k)
                    return s.Substring(0, i);
            }
            return s;

        }
    }
}

