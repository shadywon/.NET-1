﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = int.MinValue;//最大值
            int min = int.MaxValue;//最小值
            int sum = 0;//总和
            int count = 0, input = 0;
            int len = 10;//输入总数
            while (count < len)
            {
                Console.Write("请输入第" + (count + 1) + "个数:");
                if (int.TryParse(Console.ReadLine(), out input))//输入有效
                {
                    count++;
                    if (input > max) max = input;//最大值
                    if (input < min) min = input;//最小
                    sum += input;//总和
                }
                else Console.WriteLine("输入有误重新输入");
            }
            Console.WriteLine(string.Format("最大值为{0},最小为{1}，总和为{2},平均值{3}", max, min, sum, sum / len));
            Console.ReadKey();
        }
    }
}
