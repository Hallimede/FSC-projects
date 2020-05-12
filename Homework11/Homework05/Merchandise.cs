using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Homework6
{
    public class Merchandise
    {
        public int MerchandiseId { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        public double Price { get; set; }
        public Merchandise() { }
        public Merchandise(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public override string ToString()
        {
            return "      [商品：" + Name + "]      [单价：" + Price +"]";
        }

        public override bool Equals(object obj)
        {
            return obj is Merchandise merchandise &&
                   Name == merchandise.Name &&
                   Price == merchandise.Price;
        }

        public override int GetHashCode()
        {
            var hashCode = -44027456;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + Price.GetHashCode();
            return hashCode;
        }
    }
}
