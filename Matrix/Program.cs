using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入二维数组的行数：");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入二维数组的列数：");
            int n = int.Parse(Console.ReadLine());
            int[,] cost = new int[m, n];
            Console.WriteLine("请输入二维数组的值：");
            for (int i = 0; i < m; i++)
            {
                string str = Console.ReadLine();
                string[] tmp = str.Split(" ".ToCharArray());
                for (int j = 0; j < n; j++)
                {
                    cost[i, j] = int.Parse(tmp[j]);
                }
            }
            var result = IsTMatrix(cost);
            Console.WriteLine(result);
        }

        private static bool IsTMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                    if (matrix[i + 1, j + 1] != matrix[i, j])
                    {
                        return false;
                    }
            return true;
        }
    }
}
