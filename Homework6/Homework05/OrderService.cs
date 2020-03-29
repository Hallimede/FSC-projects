using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Homework6
{
    class OrderException : ApplicationException
    {
        private int code;
        public OrderException(String message, int code):base(message){
            this.code = code;
        }
        public int Code { get => code; }

    }
    [Serializable]
    public class OrderService
    {
        public List<Order> orderList = new List<Order>();
        /*public OrderService()
        {
            AddOrder(new Order(1001,new Client("wu"), DateTime.Now));
            orderList[0].AddOrderItem(new OrderItem(new Merchandise("goods1", 4.0), 5));
            orderList[0].AddOrderItem(new OrderItem(new Merchandise("goods2", 5.0), 1));
            orderList[0].AddOrderItem(new OrderItem(new Merchandise("goods3", 4.3), 2));
            AddOrder(new Order(1002,new Client("wu"), DateTime.Now));
            orderList[1].AddOrderItem(new OrderItem(new Merchandise("goods1", 4.0), 5));
            orderList[1].AddOrderItem(new OrderItem(new Merchandise("goods2", 5.0), 1));
            AddOrder(new Order(1003,new Client("wu"), DateTime.Now));
            orderList[2].AddOrderItem(new OrderItem(new Merchandise("goods2", 5.0), 1));
            orderList[2].AddOrderItem(new OrderItem(new Merchandise("goods4", 2.0), 7));
            AddOrder(new Order(1004,new Client("wang"), DateTime.Now));
            orderList[3].AddOrderItem(new OrderItem(new Merchandise("goods4", 2.0), 6));
            AddOrder(new Order(1005,new Client("wang"), DateTime.Now));
            orderList[4].AddOrderItem(new OrderItem(new Merchandise("goods3", 7.0), 3));
            //orderList.ForEach(o => Console.WriteLine(o));
        }*/
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
        public List<Order> SelectOrder(char ch, string str)
        {
            List<Order> queryList=new List<Order>();
            switch(ch){
                case 'A':  //按订单号查询
                    int orderNumber = int.Parse(str);
                    queryList = (from o in orderList where o.orderNo == orderNumber select o).ToList();
                    break;
                case 'B':  //按商品名查询
                    string merName = str;
                    foreach (Order o in orderList)
                    {
                        foreach (OrderItem oi in o.orderItems)
                        {
                            if (oi.merchandise.Name == merName) queryList.Add(o);
                        }
                    }
                    queryList = (from o in queryList orderby o.getPrice() select o).ToList();
                    break;
                case 'C':
                    string clientName =str;
                    queryList = (from o in orderList
                            where o.client.Name == clientName
                            orderby o.getPrice()
                            select o).ToList();
                    break;
                default: break;
            }
            return queryList;
        }
        public bool DeleteOrder(Order orderdelete)
        {
            if (orderdelete==null)
            {
                throw new OrderException("删除时找不到订单", 1);
            }
            else
            {
                orderList.Remove(orderdelete);
                return true;
            }

        }
        public List<Order> AddOrder(Order order) {

            orderList.Add(order);
            //orderList.ForEach(o => Console.WriteLine(o));
            return orderList;
        }
        public bool ChangeOrder(int index,Order order)
        {
            orderList.RemoveAt(index);
            orderList.Add(order);
            return true;
        }
        public int IsInOrderList(int orderNumber)
        {
            //bool have = false;
            int index;
            foreach (Order o in orderList)
            {
                if (o.orderNo == orderNumber)
                {
                    index = orderList.IndexOf(o);
                    return index;
                }
                
            }
            return -1;
        }


    }
}
