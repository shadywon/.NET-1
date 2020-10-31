using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class main
    {
        static void Main(string[] args)
        {
            try
            {
                List<Shape> shapes = new List<Shape>();
                for (int i = 0; i < 10; i++)//循环创建十个随机模型
                {
                    shapes.Add(ShapeFactory.CreateRandomShape());
                }


                foreach (Shape shape in shapes)//循环遍历打印出每个图形的信息
                    Console.WriteLine(shape.Info + $"{shape.Info}, area={shape.Area}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
