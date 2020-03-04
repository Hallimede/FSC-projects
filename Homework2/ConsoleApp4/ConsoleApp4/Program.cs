using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int length;
            Console.WriteLine("请输入一个数组长度");
            length = Convert.ToInt32(Console.ReadLine());
            //输入数组
            int[] num = new int[length];
            Console.WriteLine("请输入一个整数数组");
            for (int i = 0; i < length; i++)
            {
                num[i]=Convert.ToInt32(Console.ReadLine());
            }
            //输出结果
            double sum = getValue(num, out int max, out int min, out double avg);
            Console.WriteLine("最大值是：" + max);
            Console.WriteLine("最小值是：" + min);
            Console.WriteLine("平均值是：" + avg);
            Console.WriteLine("总和是：" + sum);
        }
        public static double getValue(int[] num,out int max,out int min,out double avg) {
            max = num[0];
            min = num[0];
            double sum = 0.0; 
            for (int i = 0; i < num.Length; i++)
            {
                max = max > num[i] ? max : num[i];
                min = max < num[i] ? min : num[i];
                sum += num[i];
            }
            avg = sum / num.Length ;
            return sum;
        }
    }
}
