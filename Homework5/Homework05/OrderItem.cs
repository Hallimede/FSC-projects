using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework05
{
    class OrderItem
    {
        public Merchandise merchandise;
        public int num;
        //double TotalPrice;
        
        public OrderItem(Merchandise merchandise, int num)
        {
            this.merchandise = merchandise;
            this.num = num;
        }

        public double getTotalPrice()
        {
            return num * merchandise.Price;
        }
        public override string ToString()
        {
            return merchandise + "      [数量：" + num + "]      [价格：￥" + getTotalPrice() + "]";
        }

        public override bool Equals(object obj)
        {
            return obj is OrderItem item &&
                   merchandise.Equals(item.merchandise) &&
                   num == item.num;
        }

        public override int GetHashCode()
        {
            var hashCode = 126280675;
            hashCode = hashCode * -1521134295 + EqualityComparer<Merchandise>.Default.GetHashCode(merchandise);
            hashCode = hashCode * -1521134295 + num.GetHashCode();
            return hashCode;
        }
       
    }
}
