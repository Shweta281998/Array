using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
   public class MaximumNumberofwordsFoundInSentences
    {
        public int MostWordsFound(string[] sentences)
        {
            int max = 0;
            for (int i = 0; i < sentences.Length; i++)
            {

                max = Math.Max(max, (sentences[i].Split(" ").Length));
            }
            return max;
        }
    }
}

