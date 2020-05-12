using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
//using System.Data.Validation;

namespace Homework6
{
    class OrderException : ApplicationException
    {
        private int code;
        public OrderException(String message, int code):base(message)
        {
            this.code = code;
        }
        public int Code { get => code; }

    }
    [Serializable]
    public class OrderService
    {
        public List<Order> orderList = new List<Order>();

        public void Export(string path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using(FileStream fs=new FileStream(path,FileMode.Create)) {
                xmlSerializer.Serialize(fs, orderList);
            }
        }
        public void Import(string path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                orderList=(List<Order>)xmlSerializer.Deserialize(fs);  //通用方法，返回的是Object类，需要类型转换
            }
        }
        public List<Order> SelectOrder(int index, string str)
        {
            List<Order> queryList=new List<Order>();
            switch(index){
                case 0:  //按订单号查询
                    int orderNumber = int.Parse(str);
                    using (var context = new OrderContext())
                    {
                        var order = context.Orders.Include("Client").Include("OrderItems")
                            .Where(b => b.OrderNo == orderNumber);
                        if (order != null) queryList=order.ToList();
                    }
                    break;
                case 1:  //按商品名查询
                    string merName = str;
                    List<OrderItem> orderItems = new List<OrderItem>();
                    using (var context = new OrderContext())
                    {
                        orderItems = context.OrderItems.Include("Order")
                        .Where(b => b.Name == merName).ToList();
                    }
                    using (var context = new OrderContext())
                    {
                        foreach (var ot in orderItems)
                        {
                            var order = context.Orders.Include("Client").Include("OrderItems")
                            .SingleOrDefault(b => b.OrderNo == ot.Order.OrderNo);
                            //ot.Order.OrderNo
                            if (order != null) queryList.Add(order);
                        }
                    }
                    //queryList = (from o in queryList orderby o.getPrice() select o).ToList();
                    break;
                case 2:
                    string clientName = str;
                    using (var context = new OrderContext())
                    {
                        var order = context.Orders.Include("Client").Include("OrderItems")
                            .Where(b => b.ClientName == clientName);
                        if (order != null) queryList = order.ToList();
                    }
                    break;
                case 3:
                    using (var context = new OrderContext())
                    {
                        var order = context.Orders.Include("Client").Include("OrderItems");
                        if (order != null) queryList = order.ToList();
                    }
                    break;
                default: 
                    break;
            }
            return queryList;
        }
        public bool DeleteOrder(int orderNo)
        {
            using (var context = new OrderContext())
            {
                Order order = context.Orders.Include("Client").Include("OrderItems").FirstOrDefault(p => p.OrderNo == orderNo);
                if (order != null)
                {
                    try
                    {
                        //context.Orders.Attach(order);
                        //context.SaveChanges();
                        //context.Entry(order).State = System.Data.Entity.EntityState.Deleted;
                        context.Orders.Remove(order);
                        context.SaveChanges();
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    //context.SaveChanges();
                    return true;
                }
                else
                {
                    throw new OrderException("删除时找不到订单", 1);
                }
            }

        }
        public void AddOrder(Order order) 
        {
            using (var context = new OrderContext())
            {
                context.Orders.Add(order);
                context.SaveChanges();
            };

        }
        public bool ChangeOrder(int index,Order order)
        {
            using (var context = new OrderContext())
            {
                var ord = context.Orders.Where(p=>p.OrderNo==index).FirstOrDefault();
                orderList.Remove(ord);
                orderList.Add(order);
                return true;
            }
        }
        public int IsInOrderList(int orderNumber)
        {
            //bool have = false;
            int index;
            foreach (Order o in orderList)
            {
                if (o.OrderNo == orderNumber)
                {
                    index = orderList.IndexOf(o);
                    return index;
                }
            }
            return -1;
        }

    }
}
