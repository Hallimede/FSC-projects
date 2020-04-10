using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Homework6;

namespace Homework8
{
    public partial class OrderItemForm : Form
    {
        /*public OrderItemForm()
        {
            Order or0 = new Order();
            OrderItem oritm = new OrderItem(new Merchandise("sdsdf",10),2);
            or0.OrderItems.Add(oritm);
            bindingSourceOrderItem.DataSource = or0.OrderItems;
        }*/
        public OrderItemForm(Order or)
        {
            InitializeComponent();
            bindingSourceOrderItem.DataSource = or.OrderItems;
            //bindingSourceOrderItem.DataMember = merchandise;
        }
    }
}
