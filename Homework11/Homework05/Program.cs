using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    class Program
    {
        /*static void Main(string[] args)
        {
            OrderUI orderUI = new OrderUI();
            orderUI.orderService.Import("export.xml");
            bool running = true;
            while (running)
            {
                Console.WriteLine();
                Console.WriteLine("请输入需要的服务：");
                Console.WriteLine("“A”添加订单，“B”查询订单，“C”删除订单，“D”修改订单“E”退出程序");
                char select = char.Parse(Console.ReadLine());
                try
                {
                    switch (select)
                    {
                        case 'A': orderUI.Add().ForEach(o => Console.WriteLine(o));
                            orderUI.orderService.Export("export.xml"); break;
                        case 'B': orderUI.Select().ForEach(o3 => Console.WriteLine(o3));
                            orderUI.orderService.Export("export.xml"); break;
                        case 'C': if(orderUI.Delete()) Console.WriteLine("删除成功！");
                            orderUI.orderService.Export("export.xml"); break;
                        case 'D': if(orderUI.Change()) Console.WriteLine("修改成功！");
                            orderUI.orderService.Export("export.xml"); break;
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
            
            
        }*/
        //添加博客
        static void Main(string[] args)
        {

            //添加博客
            int newBlogId = 0;
            int newPostId = 0;
            using (var context = new OrderContext())
            {
                Client client = new Client("nihs");
                var order = new Order { Client = client, time = DateTime.Now };
                Merchandise mer1 = new Merchandise("goods1", 4.0);
                Merchandise mer2 = new Merchandise("goods2", 3.0);
                order.OrderItems = new List<OrderItem>() {
                new OrderItem() { merchandise=mer1,Num = 3},
                new OrderItem() { merchandise=mer2,Num = 4} 
                
            };
                Console.WriteLine("1");
                context.Orders.Add(order);
                Console.WriteLine("2");
                context.SaveChanges();
                Console.WriteLine("3");
                newBlogId = order.OrderNo;


            }
        }
    }
}
