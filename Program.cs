using System;

/// <summary>
/// The Broken Calculator (LeetCode No.991)
/// https://leetcode-cn.com/articles/broken-calculator/
/// </summary>
namespace BrokenCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int step = 0;
            int x, y;
            Console.WriteLine("input x:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("input y:");
            y = int.Parse(Console.ReadLine());

            while (x != y)
            {
                if (x > y)
                {
                    step += x - y;
                }
                if (x <= y / 2)
                {
                    x = x * 2;
                    step++;
                }
                if (x > y / 2 && x < y)
                {
                    x--;
                    step++;
                }
            }

            Console.WriteLine(step);
            Console.ReadKey();
        }
    }
}
