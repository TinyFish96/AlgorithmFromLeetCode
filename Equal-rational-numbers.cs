using System;

namespace EqualRationalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "0.(142857)", t = "0.14285(714285)";

            //s的循环部分
            int sXunhuan = int.Parse(s.Split('.')[1].Split('(')[1].Split(')')[0]);

            //s排开循环部分的小数
            double sXiaoshu = double.Parse(s.Split('(')[0]);

            //t的循环部分
            int tXunhuan = int.Parse(t.Split('.')[1].Split('(')[1].Split(')')[0]);

            //t排开循环部分的小数
            double tXiaoshu = double.Parse(t.Split('(')[0]);
			
            if(Function(sXiaoshu,sXunhuan)==Function(tXiaoshu,tXunhuan))
            {
                Console.WriteLine("Equal!");
            }
            else
            {
                Console.WriteLine("Not Equal!");
            }
            Console.ReadKey();
        }

        private static double Function(double Xiaoshu, int Xunhuan)
        {
            //获取小数位数
            int Weishu = 0;
            if (Xiaoshu != 0.0)
            {
                Weishu = Xiaoshu.ToString().Split('.')[1].Length;
            }

            //获取循环部分位数
            int XunhuanWeishu = Xunhuan.ToString().Length;

            //乘以倍数
            double s = (Xiaoshu + Math.Pow(10, -(Weishu + XunhuanWeishu)) * Xunhuan) * Math.Pow(10, Weishu);
            //整数部分
            int s1 = int.Parse(s.ToString().Split('.')[0]);

            int s2 = (int)(s * Math.Pow(10, XunhuanWeishu));

            //分子
            int nume = s2 - s1;

            //分母
            int deno = (int)(Math.Pow(10, XunhuanWeishu)* Math.Pow(10, Weishu) - Math.Pow(10, Weishu));

            return nume / deno;
        }
    }
}
