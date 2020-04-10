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
    public partial class MainForm : Form
    {
        public OrderService orderService = new OrderService();
        public MainForm()
        {
            InitializeComponent();

            orderService.Import("export.xml");

            pnlSelectSubmit.Visible = false;
            dataGridOrder.Visible = false;
            for(int i=0;i<dataGridOrder.Columns.Count;i++)
            dataGridOrder.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

        }

        private void dataGridOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewColumn column = dataGridOrder.Columns[e.ColumnIndex];
                if (column is DataGridViewButtonColumn)
                {
                    Order or =bindingSourceOrder.Current as Order;
                    //Order or = (Order)bindingSourceOrder[e.RowIndex];

                    OrderItemForm orderItemForm = new OrderItemForm(or);
                    orderItemForm.Show();
                    //这里可以编写你需要的任意关于按钮事件的操作~
                    //MessageBox.Show("点击");
                } 
            }
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            pnlSelectSubmit.Visible=true;
        }

        private void btnSelectSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                int index = cmbSelect.SelectedIndex;
                string str = txtSelect.Text;
                bindingSourceOrder.DataSource = orderService.SelectOrder(index, str);
                dataGridOrder.Visible = true;
            }
            catch (FormatException fe)
            {
                MessageBox.Show("输入数据异常，请检查");
            }
        }
        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            bindingSourceOrder.DataSource = orderService.orderList;
            bindingSourceOrder.ResetBindings(false);
            dataGridOrder.Visible = true;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "C# Corner Open File Dialog";
            openFileDialog1.InitialDirectory = @"c:\";
            openFileDialog1.Filter = "XML（*.xml）|*.xml";
            /*
             * FilterIndex 属性用于选择了何种文件类型,缺省设置为0,系统取Filter属性设置第一项
             * ,相当于FilterIndex 属性设置为1.如果你编了3个文件类型，当FilterIndex ＝2时是指第2个.
             */
            //openFileDialog1.FilterIndex = 2;
            /*
             *如果值为false，那么下一次选择文件的初始目录是上一次你选择的那个目录，
             *不固定；如果值为true，每次打开这个对话框初始目录不随你的选择而改变，是固定的  
             */
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                orderService.Import(System.IO.Path.GetFullPath(openFileDialog1.FileName));
                //System.IO.Path.GetFullPath(openFileDialog1.FileName); //绝对路径
                //System.IO.Path.GetExtension(openFileDialog1.FileName); //文件扩展名
                //System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.FileName); //文件名没有扩展名
                //System.IO.Path.GetFileName(openFileDialog1.FileName); //得到文件
                //System.IO.Path.GetDirectoryName(openFileDialog1.FileName); //得到路径
                MessageBox.Show("导入成功!");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm(orderService);
            addForm.ShowDialog();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "C# Corner Save File Dialog";
            saveFileDialog.InitialDirectory = @"c:\";
            saveFileDialog.Filter = "XML(*.xml)|*.xml"; //设置文件类型
            saveFileDialog.FileName = "export";//设置默认文件名
            saveFileDialog.DefaultExt = "xml";//设置默认格式（可以不设）
            saveFileDialog.AddExtension = true;//设置自动在文件名中添加扩展名

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                orderService.Export(saveFileDialog.FileName);
                MessageBox.Show("保存成功!");
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            UpdateForm updateForm = new UpdateForm(orderService);
            updateForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteForm deleteForm =new DeleteForm(orderService);
            deleteForm.ShowDialog();
        }
    }
}
