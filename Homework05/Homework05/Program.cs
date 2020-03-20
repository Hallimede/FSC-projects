using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework05
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderUI orderUI = new OrderUI();
            bool running = true;
            while (running)
            {
                Console.WriteLine();
                Console.WriteLine("请输入需要的服务：");
                Console.WriteLine("“A”添加订单，“B”查询订单，“C”删除订单，“D”修改订单，“E”退出程序");
                char select = char.Parse(Console.ReadLine());
                try
                {
                    switch (select)
                    {
                        case 'A': orderUI.Add().ForEach(o => Console.WriteLine(o)); break;
                        case 'B': orderUI.Select().ForEach(o3 => Console.WriteLine(o3)); break;
                        case 'C': if(orderUI.Delete()) Console.WriteLine("删除成功！"); break;
                        case 'D': if(orderUI.Change()) Console.WriteLine("修改成功！"); break;
                        case 'E': running = false; break;
                        default: break;
                    }
                }catch(OrderException oe)
                {
                    Console.WriteLine(oe.Message+",错误代码"+oe.Code);
                }
                catch(FormatException fe)
                {
                    Console.WriteLine(fe.Message);
                }
            }
            
            
        }
    }
}
