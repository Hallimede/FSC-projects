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
    public partial class DeleteForm : Form
    {
        public OrderService orderService;
       // public Order order = new Order();
        //public List<OrderItem> orderItemList = new List<OrderItem>();
        public int DeleteNo { get; set; }
        public DeleteForm(OrderService orderService)
        {
            InitializeComponent();
            this.orderService = orderService;
            cmbDeleteOrderNo.DataSource = orderService.orderList;
            cmbDeleteOrderNo.DisplayMember = "OrderNo";
            cmbDeleteOrderNo.DataBindings.Add("SelectedItem", this, "DeleteNo");
        }

        private void btnDeleteSubmit_Click(object sender, EventArgs e)
        {
            //消息框中需要显示哪些按钮，此处显示“确定”和“取消”
            MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
            //"确定要退出吗？"是对话框的显示信息，"退出系统"是对话框的标题
            //默认情况下，如MessageBox.Show("确定要退出吗？")只显示一个“确定”按钮。
            DialogResult dr = MessageBox.Show("确定删除吗?", "删除订单", messButton);
            
            if (dr == DialogResult.OK)//如果点击“确定”按钮
            {
                int index = cmbDeleteOrderNo.SelectedIndex;
                //MessageBox.Show(DeleteNo.ToString());
                orderService.DeleteOrder(orderService.orderList[index]);
                MessageBox.Show("删除成功");
                
                orderService.Export("export.xml");
                this.Dispose();
            }
            else//如果点击“取消”按钮
            {
                return;
            }

        }
    }
}
