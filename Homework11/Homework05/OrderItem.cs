using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    public class OrderItem
    {
        public Merchandise merchandise;
        private int num;
        public int OrderItemId { get; set; }
        public int Num { get => num; set => num = value; }
        public string Name { get => merchandise.Name; set => merchandise.Name = value; }
        public double Price { get => merchandise.Price; set => merchandise.Price = value; }
        //public Merchandise MerchandiseAttr { get => merchandise; set => merchandise = value; }

        //double TotalPrice;
       // public int OrderId { get; set; }
        public Order Order { get; set; }

        public OrderItem() {
            Merchandise mer = new Merchandise();
            merchandise = mer;
        }
        public OrderItem(Merchandise merchandise, int num)
        {
            this.merchandise = merchandise;
            this.Num = num;
        }

        public double getTotalPrice()
        {
            return Num * Price;
        }
        public override string ToString()
        {
            return merchandise + "      [数量：" + Num + "]      [价格：￥" + getTotalPrice() + "]";
        }

        public override bool Equals(object obj)
        {
            return obj is OrderItem item &&
                   merchandise.Equals(item.merchandise) &&
                   Num == item.Num;
        }

        public override int GetHashCode()
        {
            var hashCode = 126280675;
            hashCode = hashCode * -1521134295 + EqualityComparer<Merchandise>.Default.GetHashCode(merchandise);
            hashCode = hashCode * -1521134295 + Num.GetHashCode();
            return hashCode;
        }
       
    }
}
