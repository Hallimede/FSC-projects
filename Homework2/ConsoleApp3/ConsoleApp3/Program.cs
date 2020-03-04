using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("请输入一个整数");
                int number = Convert.ToInt32(Console.ReadLine());
                for (int i = 2; i <= number; )
                {

                    if (number % i == 0)
                    {
                        Console.WriteLine(i);
                        number /= i;
                    }
                    else 
                    {
                        i++; 
                    }
                }
            }catch(Exception e)
            {
                Console.WriteLine("输入整数错误"+e.Message);
            }
        }
    }
}
