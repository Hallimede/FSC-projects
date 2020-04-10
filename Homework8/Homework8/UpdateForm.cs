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
    public partial class UpdateForm : Form
    {
        public OrderService orderService;
        public Order order = new Order();
        public List<OrderItem> orderItemList = new List<OrderItem>();
        public int UpdateNo { get; set; }
        public UpdateForm(OrderService orderService)
        {
            InitializeComponent();
            this.orderService = orderService;
            cmbUpOrderNo.DataSource = orderService.orderList;
            cmbUpOrderNo.DisplayMember = "OrderNo";
            cmbUpOrderNo.DataBindings.Add("SelectedItem", this, "UpdateNo");
        }

        private void cmbUpOrderNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cmbUpOrderNo.SelectedIndex;
            txtUpClientName.Text = orderService.orderList[index].ClientAttr.Name;
        }

        private void btnUpItemSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbUpOrderNo.Text == "")
                {
                    MessageBox.Show("请完善订单信息");
                    return;
                }

                string merName = txtUpMerName.Text;
                double merPrice = double.Parse(txtUpMerPrice.Text);
                Merchandise merchandise = new Merchandise(merName, merPrice);
                int merNum = int.Parse(txtUpMerNum.Text);
                OrderItem orderItem = new OrderItem(merchandise, merNum);

                orderItemList.Add(orderItem);
                txtUpClientName.ReadOnly = true;
                cmbUpOrderNo.Enabled = false;
                txtUpMerName.Clear();
                txtUpMerPrice.Clear();
                txtUpMerNum.Clear();
            }
            catch (FormatException fe)
            {
                MessageBox.Show("数据输入有误!");
            }
        }

        private void btnUpOrderSubmit_Click(object sender, EventArgs e)
        {
            try
            {

                if (orderItemList.Count == 0)
                {
                    MessageBox.Show("还未更新任何条目！");
                    return;
                }

                string clientName = txtUpClientName.Text;
                int orderNo = int.Parse(cmbUpOrderNo.Text);
                int index = cmbUpOrderNo.SelectedIndex;
                Client client = new Client(clientName);

                order.ClientAttr = client;
                order.OrderNo = orderNo;
                order.OrderItems = orderItemList;
                order.Time = DateTime.Now;

                orderService.ChangeOrder(index, order);

                MessageBox.Show("修改完成！");
                orderService.Export("export.xml");
                this.Dispose();
            }
            catch (FormatException fe)
            {
                MessageBox.Show("数据输入有误！");
            }
        }
    }
}
