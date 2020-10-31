using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入一个数：");
            int n = Convert.ToInt32(Console.ReadLine());
            //输出1~n之间的所有素数，n>=3
            Console.Write("1 2 ");

            int i, j = 0;
            for (i = 3; i <= n; i = i + 2)
            {
                int k = (int)Math.Sqrt(i);
                for (j = 2; j <= k; j++)
                {
                    if ((i % j) == 0)
                    {
                        break;
                    }
                }

                if (j > k)
                {
                    Console.Write(i.ToString() + " ");
                }
            }
        }
    }
}
