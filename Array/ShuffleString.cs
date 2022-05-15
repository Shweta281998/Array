using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
   public class ShuffleString
    {
        public string RestoreString(string s, int[] indices)
        {
            char[] arr = new char[indices.Length];
            for (int i = 0; i < s.Length; i++)
            {
                arr[indices[i]] = s[i];
            }
            return new String(arr);
        }
    }
}
