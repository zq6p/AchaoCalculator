using System;

namespace Achao
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[] s = new char[] { '+', '-', '*', '/' };
            string Res = "";
            int iSeed = 10;
            Random ro = new Random(10);
            long tick = DateTime.Now.Ticks;
            Random ran = new Random((int)(tick & 0xffffffffL) | (int)(tick >> 32));
            Random nums = new Random();
            for (int i = 0; i < n; i++)
            {
                int Num1 = ro.Next(0, 100);
                int Num2 = ro.Next(0, 100);
                int Nums = nums.Next(0, 4);
                double res;
                if (s[Nums] == '+')
                {
                    res = Num1 + Num2;
                }
                else if (s[Nums] == '-')
                {
                    res = Num1 - Num2;
                }
                else if (s[Nums] == '*')
                {
                    res = Num1 * Num2;
                }
                else
                {
                    res = (double)Num1 / (double)Num2;
                }
                Res = Res + "第" + (i + 1) + "道题：" + Num1.ToString() + s[Nums].ToString() + Num2.ToString() + "=" + res.ToString() + "       ";

            }
            System.IO.File.WriteAllText("C:/Users/VULCAN/AchaoCalculator/zq6p/four.txt", Res);
        }
    }
}
