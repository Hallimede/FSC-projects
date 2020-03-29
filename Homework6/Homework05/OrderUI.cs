using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    class OrderUI
    {
        public OrderService orderService = new OrderService();
        public List<Order> Add()   //执行添加操作
        {   
            Console.WriteLine();
            Console.WriteLine("请输入订单号：");
            int orderNo = int.Parse(Console.ReadLine());

            Console.WriteLine("请输入订单用户名：");
            Client client = new Client(Console.ReadLine());

            Order order = new Order(orderNo, client, DateTime.Now);
            
            bool stop = false;
            while (!stop)
            {
                Console.WriteLine("请输入商品条目，A继续，B停止：");
                if (Console.ReadLine() == "A")
                {
                    Console.WriteLine("请输入商品名：");
                    string merName = Console.ReadLine();
                    Console.WriteLine("请输入商品价格：");
                    double merPrice = double.Parse(Console.ReadLine());
                    Merchandise merchandise = new Merchandise(merName, merPrice);

                    Console.WriteLine("请输入商品数量：");
                    int merNum = int.Parse(Console.ReadLine());
                    order.AddOrderItem(new OrderItem(merchandise, merNum));
                }
                else stop = true;
            }
            orderService.AddOrder(order);
            return orderService.orderList;
        }
        public bool Delete()
        {
            Console.WriteLine();
       
            Console.WriteLine("请输入订单号：");
            int orderNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("是否确认删除？“Y”for是，“N”for否");
            if (Console.ReadLine() != "Y") return false;
                   
            Order orderdelete = (from o in orderService.orderList
                                 where o.orderNo == orderNumber
                                 select o).FirstOrDefault();
            orderService.DeleteOrder(orderdelete);
            //orderListDelete.Add(order0);
            //orderListDelete = orderService.orderList.FindAll(o => o.orderNo == orderNumber);
                    

             //不符合实际要求
              /*case 'B':
                    Console.WriteLine("请输入商品名：");
                    string merName = Console.ReadLine();
                    Console.WriteLine("是否确认删除？“Y”for是，“N”for否");
                    if (Console.ReadLine() != "Y") return false;
                    //listOr=new List<OrderItem>();
                    foreach (Order o in orderService.orderList)
                    {
                        foreach(OrderItem oi in o.orderItems)
                        {
                            if (oi.merchandise.Name == merName) o.DeleteOrderItem(oi);
                        }
                        //List<OrderItem> listOr =o.orderItems.FindAll(oi => oi.merchandise.Name == merName);
                        //if (listOr.Count != 0) orderListDelete.Add(o);
                    } break;
                case 'B':
                    Console.WriteLine("请输入客户名：");
                    string clientName = Console.ReadLine();
                    Console.WriteLine("是否确认删除？“Y”for是，“N”for否");
                    if (Console.ReadLine() != "Y") return false;
                    foreach (Order o in orderService.orderList)
                    {
                        if (clientName == o.client.Name) orderService.DeleteOrder(o); 
                    }
                    break;
                // orderListDelete = (from o in orderService.orderList
                //                    where o.client.Name == clientName
                //                    select o).ToList(); break;
                //orderListDelete = orderList.FindAll(o5 => o5.client.Name == clientName);
                default: break;*/

            return true;
           
        }
        public List<Order> Select()
        {
            Console.WriteLine();
            Console.WriteLine("请选择查询方式：");
            Console.WriteLine("“A”按订单号查询，“B”按商品名查询，“C”按客户查询，“D”查询所有订单");
            char select = char.Parse(Console.ReadLine());
            //IEnumerable<Order> query;
            List<Order> orderListQuery = new List<Order>();
            switch (select)
            {
                case 'A':
                    Console.WriteLine("请输入订单号：");
                    orderListQuery = orderService.SelectOrder('A', Console.ReadLine());
                    break;
                    //orderListQuery = orderList.FindAll(o => o.orderNo == orderNumber); break;
                case 'B':
                    Console.WriteLine("请输入商品名：");
                    orderListQuery = orderService.SelectOrder('B', Console.ReadLine());
                    break;
                case 'C':
                    Console.WriteLine("请输入客户名：");
                    orderListQuery = orderService.SelectOrder('C', Console.ReadLine());
                    break;
                // orderListQuery.ForEach(o3 => Console.WriteLine(o3));
                case 'D':
                    orderListQuery = orderService.orderList; break;
                default: break;
            }
            //orderListQuery.Sort((o1, o2) => o1.orderItem.getTotalPrice() > o2.orderItem.getTotalPrice()?1:-1);  //如果相等？
            Console.WriteLine();
            if (orderListQuery.Count == 0) throw new OrderException("找不到查询结果", 3);
            //orderListQuery.ForEach(o3 => Console.WriteLine("【"+orderList.IndexOf(o3)+"】" + o3));
            return orderListQuery;
        }
        public bool Change()
        {
            Console.WriteLine();
            Console.WriteLine("请输入订单号：：");
            int orderNumber = int.Parse(Console.ReadLine());

            int index = orderService.IsInOrderList(orderNumber);
            if (index==-1) throw new OrderException("不存在该订单",7);

            Console.WriteLine("请输入订单用户名：");
            Client client = new Client(Console.ReadLine());

            Order order = new Order(orderNumber, client, DateTime.Now);

            bool stop = false;
            while (!stop)
            {
                Console.WriteLine("请输入商品条目，A继续，B停止：");
                if (Console.ReadLine() == "A")
                {
                    Console.WriteLine("请输入商品名：");
                    string merName = Console.ReadLine();
                    Console.WriteLine("请输入商品价格：");
                    double merPrice1 = double.Parse(Console.ReadLine());
                    Merchandise merchandise = new Merchandise(merName, merPrice1);

                    Console.WriteLine("请输入商品数量：");
                    int merNum1 = int.Parse(Console.ReadLine());
                    order.AddOrderItem(new OrderItem(merchandise, merNum1));
                }
                else stop = true;
            }
            orderService.ChangeOrder(index, order);
            return true;
        }
    }
}
