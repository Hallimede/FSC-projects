using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace Homework6
{
    public class Order
    {
        private int orderNo;
        //public OrderItem orderItem;
        private List<OrderItem> orderItems = new List<OrderItem>();
        //public Client client;
        public DateTime time;
        public double price;
        //public string name;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderNo { get => orderNo; set => orderNo = value; }

        public int ClientId { get; set; }
        [ForeignKey("ClientId")]
        public Client Client { get ;  set; }
        public string ClientName { get=> (Client != null) ? Client.Name : ""; set=> Client.Name=value; }

        public DateTime Time { get => time; set => time = value; }
        public double Price { get=>price=getPrice(); set => price = value; }
        public List<OrderItem> OrderItems { get => orderItems; set => orderItems = value; }

        public double getPrice()
        {
            double sum=0;
            foreach(OrderItem oi in orderItems)
            {
                sum += oi.getTotalPrice();
            }
            return sum;
        }
        public Order() 
        {
            Client = new Client("9"); 
        }
        public Order(int orderNo, Client client,DateTime time)
        {
            this.OrderNo = orderNo;
            //this.orderItems = orderItems;
            this.Client = client;
            this.time = time;
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
                tostring+= orderItem.ToString() + Client.ToString()+"\n";
            }
            return tostring;
        }

    }


    public class OrderContext : DbContext
    {
        public OrderContext() : base("OrderDataBase")
        {
            Database.SetInitializer(
              new DropCreateDatabaseIfModelChanges<OrderContext>());
        }

        
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Merchandise> Merchandises { get; set; }

    }
}

