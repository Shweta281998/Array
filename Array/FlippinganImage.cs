using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class FlippinganImage
    {
        public int[][] FlipAndInvertImage(int[][] image)
        {

            int row = image.Length;
            int column = image[0].Length;

            for (int i = 0; i < row; i++)
            {
                int start = 0;
                int end = column - 1;

                while (start < end)
                {
                    var temp = image[i][start];
                    image[i][start] = image[i][end];
                    image[i][end] = temp;
                    start++;
                    end--;


                }
                for (int j = 0; j < column; j++)
                {
                    image[i][j] ^= 1;
                }
            }

            return image;
        }
    }
}
