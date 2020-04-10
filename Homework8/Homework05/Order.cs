using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    public class Order
    {
        private int orderNo;
        //public OrderItem orderItem;
        private List<OrderItem> orderItems = new List<OrderItem>();
        private Client client;
        DateTime time;

        public int OrderNo { get => orderNo; set => orderNo = value; }
        public Client ClientAttr { get => client; set => client = value; }
        public DateTime Time { get => time; set => time = value; }
        public double Price { get => getPrice(); }
        public List<OrderItem> OrderItems { get => orderItems; set => orderItems = value; }

        public double getPrice()
        {
            double sum=0;
            foreach(OrderItem oi in OrderItems)
            {
                sum += oi.getTotalPrice();
            }
            return sum;
        }
        public Order() {
            Client cl = new Client();
            ClientAttr = cl;
            
        }
        public Order(int orderNo, Client client,DateTime time)
        {
            this.OrderNo = orderNo;
            //this.orderItems = orderItems;
            this.ClientAttr = client;
            this.Time = time;
        }
        public bool AddOrderItem(OrderItem orderItem)
        {
            if (OrderItems.Contains(orderItem))
                throw new OrderException("商品条目已经存在", 4);
            OrderItems.Add(orderItem);
            return true;
        }
        public bool DeleteOrderItem(OrderItem orderItem)
        {
            if (OrderItems.Contains(orderItem))
            {
                OrderItems.Remove(orderItem);
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
                   OrderNo == order.OrderNo;
        }

        public override int GetHashCode()
        {
            return 1009780604 + OrderNo.GetHashCode();
        }

        public override string ToString()
        {
            string tostring= "【" + OrderNo + "】" + Time+ "【总价】￥" + getPrice() + "\n";
            foreach (OrderItem orderItem in OrderItems)
            {
                tostring+= orderItem.ToString() + ClientAttr.ToString()+"\n";
            }
            return tostring;
        }

    }
}
