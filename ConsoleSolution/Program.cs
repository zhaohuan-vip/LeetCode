using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleSolution
{
    class Program
    {

        // 测试类
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            bool b = true;
            while (b)
            {
                try
                {
                    //Console.WriteLine("Input Num：");
                    //var num = Console.ReadLine();
                    //Console.WriteLine("Input k(int)：");
                    //var k = Convert.ToInt32(Console.ReadLine());


                    //var num = Convert.ToInt32(Console.ReadLine());
                    //string[] list = { "42", "   -42", "4193 with words", "words and 987", "-91283472332" };
                    //foreach(var s in list)
                    //{
                    //    var result = solution.MyAtoi(s);
                    //    Console.WriteLine("Result：" + result);
                    //}
                    Console.WriteLine("input:");
                    //var k = Convert.ToInt32(Console.ReadLine());
                    var s = Console.ReadLine();

                    
                    var result = solution.LengthOfLongestSubstring(s);

                    Console.WriteLine("Result：" + result);
                    Console.ReadKey();

                }
                catch(Exception ex)
                {
                    b = false;
                    var a = ex;
                }
            }

            Console.Read();
        }
    }
}
