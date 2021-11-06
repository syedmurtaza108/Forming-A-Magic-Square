using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forming_A_Magic_Square
{
    class Program
    {
        const int MAGICCONST = 15;
        static void Main(string[] args)
        {
            int[][] s = new int[3][];
            for (int i = 0; i < 3; i++)
            {
                s[i] = Array.ConvertAll(Console.ReadLine().Split(' '), sTemp => Convert.ToInt32(sTemp));
            }

            int result = formingMagicSquare(s);
            Console.WriteLine(result);
        }


        //For 3 x 3 magic matrix magic constant is 15.
        static int formingMagicSquare(int[][] A)
        {
            int[,,] magic_mat = new int[8, 3, 3]{
    {{8, 1, 6}, {3, 5, 7}, {4, 9, 2}},
    {{6, 1, 8}, {7, 5, 3}, {2, 9, 4}},
    {{4, 9, 2}, {3, 5, 7}, {8, 1, 6}},
    {{2, 9, 4}, {7, 5, 3}, {6, 1, 8}},
    {{8, 3, 4}, {1, 5, 9}, {6, 7, 2}},
    {{4, 3, 8}, {9, 5, 1}, {2, 7, 6}},
    {{6, 7, 2}, {1, 5, 9}, {8, 3, 4}},
    {{2, 7, 6}, {9, 5, 1}, {4, 3, 8}},
};
            int min_cost = 81;
            for (int k = 0; k < 8; k++)
            {
                int crt_cost = 0;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                        crt_cost += Math.Abs((A[i][j] - magic_mat[k, i, j]));
                }
                if (crt_cost < min_cost)
                    min_cost = crt_cost;
            }
            return min_cost;
        }
    }
}
