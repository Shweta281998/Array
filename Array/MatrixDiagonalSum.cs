using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
   public class MatrixDiagonalSum
    {
        public int DiagonalSum(int[][] mat)
        {
            int sum = 0, n = mat.Length;
            for (int i = 0; i < mat.Length; i++)
            {
                sum += mat[i][i] + mat[i][n - i - 1];
            }
            return n % 2 == 0 ? sum : sum - mat[n / 2][n / 2];
        }
    }
}
