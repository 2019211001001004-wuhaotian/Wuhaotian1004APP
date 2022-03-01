using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1HW3App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入要判断的年份");
            int year = Convert.ToInt32(Console.ReadLine());
            bool result = (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
