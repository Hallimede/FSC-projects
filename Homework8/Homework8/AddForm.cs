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
    public partial class AddForm : Form
    {
        public OrderService orderService;
        public Order order = new Order();
        public List<OrderItem> orderItemList = new List<OrderItem>();
        public AddForm(OrderService orderService)
        {
            InitializeComponent();
            this.orderService = orderService;
        }

        private void btnAddItemSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtClientName.Text == "" && txtOrderNo.Text == "")
                { 
                    MessageBox.Show("请完善订单信息");
                    return;
                }
                else
                {
                    int orderNo = int.Parse(txtOrderNo.Text); 
                }  //判定订单信息完整且正确

                string merName = txtMerName.Text;
                double merPrice = double.Parse(txtMerPrice.Text);
                Merchandise merchandise = new Merchandise(merName,merPrice);
                int merNum = int.Parse(txtMerNum.Text);
                OrderItem orderItem = new OrderItem(merchandise,merNum);

                orderItemList.Add(orderItem);
                txtClientName.ReadOnly = true;
                txtOrderNo.ReadOnly = true;
                txtMerName.Clear();
                txtMerPrice.Clear();
                txtMerNum.Clear();
            }
            catch(FormatException fe)
            {
                MessageBox.Show("数据输入有误!");
            }
        }
        private void btnAddOrderSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (orderItemList.Count == 0)
                {
                    MessageBox.Show("还未添加订单条目！");
                    return;
                }
                string clientName = txtClientName.Text;
                int orderNo = int.Parse(txtOrderNo.Text);
                Client client = new Client(clientName);

                order.ClientAttr = client;
                order.OrderNo = orderNo;
                order.OrderItems = orderItemList;
                order.Time = DateTime.Now;

                orderService.AddOrder(order);

                MessageBox.Show("添加完成！");
                orderService.Export("export.xml");
                this.Dispose();
            }
            catch(FormatException fe)
            {
                MessageBox.Show("数据输入有误！");
            }

        }
    }
}
