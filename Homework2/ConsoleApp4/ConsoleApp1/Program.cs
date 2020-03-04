using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2~100以内的素数有：");
            Prime(100);

        }
        public static void Prime(int n)
        {
            bool[] array = new bool[n + 1];
            for (int i = 2; i <= n; i++)
            {
                array[i] = true;
            }
            for (int j = 2; j*j < 100; j++)
            {
                if (!array[j]) 
                {
                    continue; 
                }
                for(int k=2*j;k<=n ;k+=j) 
                {
                    array[k] = false;
                }
            }
            for(int i = 2; i <= 100; i++)
            {
                if (array[i])
                {
                    Console.Write(i + "  ");
                }
            }
        }
    }
}
