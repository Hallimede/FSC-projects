using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    public class Order
    {
        public int orderNo;
        //public OrderItem orderItem;
        public List<OrderItem> orderItems=new List<OrderItem>();
        public Client client;
        DateTime time;
        public double getPrice()
        {
            double sum=0;
            foreach(OrderItem oi in orderItems)
            {
                sum += oi.getTotalPrice();
            }
            return sum;
        }
        public Order() { }
        public Order(int orderNo, Client client,DateTime time)
        {
            this.orderNo = orderNo;
            //this.orderItems = orderItems;
            this.client = client;
            this.time = time;
        }
        public bool AddOrderItem(OrderItem orderItem)
        {
            if (orderItems.Contains(orderItem))
                throw new OrderException("商品条目已经存在", 4);
            orderItems.Add(orderItem);
            return true;
        }
        public bool DeleteOrderItem(OrderItem orderItem)
        {
            if (orderItems.Contains(orderItem))
            {
                orderItems.Remove(orderItem);
                return true;
            }
            else
            {
                throw new OrderException("删除时找不到条目", 6);
            }
        }
        public override bool Equals(object obj)
        {
            return obj is Order order &&
                   orderNo == order.orderNo;
        }

        public override int GetHashCode()
        {
            return 1009780604 + orderNo.GetHashCode();
        }

        public override string ToString()
        {
            string tostring= "【" + orderNo + "】" + time+ "【总价】￥" + getPrice() + "\n";
            foreach (OrderItem orderItem in orderItems)
            {
                tostring+= orderItem.ToString() + client.ToString()+"\n";
            }
            return tostring;
        }

    }
}
