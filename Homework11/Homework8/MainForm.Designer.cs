namespace Homework8
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlSelectSubmit = new System.Windows.Forms.Panel();
            this.txtSelect = new System.Windows.Forms.TextBox();
            this.cmbSelect = new System.Windows.Forms.ComboBox();
            this.lblSelect1 = new System.Windows.Forms.Label();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnSelectSubmit = new System.Windows.Forms.Button();
            this.dataGridOrder = new System.Windows.Forms.DataGridView();
            this.orderNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bindingSourceOrder = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.pnlSelectSubmit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.panel1);
            this.pnlTop.Controls.Add(this.pnlTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(824, 128);
            this.pnlTop.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Controls.Add(this.btnChange);
            this.panel1.Controls.Add(this.btnImport);
            this.panel1.Controls.Add(this.btnSelect);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 68);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(-9, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(838, 10);
            this.label1.TabIndex = 6;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExport.Enabled = false;
            this.btnExport.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExport.Location = new System.Drawing.Point(651, 10);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(105, 43);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "导出订单";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnChange
            // 
            this.btnChange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChange.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnChange.Location = new System.Drawing.Point(301, 10);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(105, 43);
            this.btnChange.TabIndex = 2;
            this.btnChange.Text = "修改订单";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnImport
            // 
            this.btnImport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnImport.Enabled = false;
            this.btnImport.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnImport.Location = new System.Drawing.Point(534, 10);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(105, 43);
            this.btnImport.TabIndex = 4;
            this.btnImport.Text = "导入订单";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSelect.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelect.Location = new System.Drawing.Point(63, 10);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(105, 43);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "查询订单";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.Location = new System.Drawing.Point(418, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 43);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "删除订单";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.Location = new System.Drawing.Point(183, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 43);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "添加订单";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.pnlTitle.Size = new System.Drawing.Size(824, 67);
            this.pnlTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point(349, 20);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(129, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "订单管理";
            // 
            // pnlSelectSubmit
            // 
            this.pnlSelectSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSelectSubmit.Controls.Add(this.txtSelect);
            this.pnlSelectSubmit.Controls.Add(this.cmbSelect);
            this.pnlSelectSubmit.Controls.Add(this.lblSelect1);
            this.pnlSelectSubmit.Controls.Add(this.btnSelectAll);
            this.pnlSelectSubmit.Controls.Add(this.btnSelectSubmit);
            this.pnlSelectSubmit.Location = new System.Drawing.Point(0, 134);
            this.pnlSelectSubmit.Name = "pnlSelectSubmit";
            this.pnlSelectSubmit.Size = new System.Drawing.Size(830, 48);
            this.pnlSelectSubmit.TabIndex = 1;
            // 
            // txtSelect
            // 
            this.txtSelect.Location = new System.Drawing.Point(170, 12);
            this.txtSelect.Name = "txtSelect";
            this.txtSelect.Size = new System.Drawing.Size(105, 28);
            this.txtSelect.TabIndex = 1;
            // 
            // cmbSelect
            // 
            this.cmbSelect.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbSelect.FormattingEnabled = true;
            this.cmbSelect.Items.AddRange(new object[] {
            "订单号",
            "商品名",
            "客户名"});
            this.cmbSelect.Location = new System.Drawing.Point(69, 10);
            this.cmbSelect.Name = "cmbSelect";
            this.cmbSelect.Size = new System.Drawing.Size(88, 32);
            this.cmbSelect.TabIndex = 0;
            this.cmbSelect.Text = "订单号";
            // 
            // lblSelect1
            // 
            this.lblSelect1.AutoSize = true;
            this.lblSelect1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSelect1.Location = new System.Drawing.Point(17, 13);
            this.lblSelect1.Name = "lblSelect1";
            this.lblSelect1.Size = new System.Drawing.Size(46, 24);
            this.lblSelect1.TabIndex = 0;
            this.lblSelect1.Text = "按照";
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelectAll.Location = new System.Drawing.Point(379, 6);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(142, 39);
            this.btnSelectAll.TabIndex = 3;
            this.btnSelectAll.Text = "查询所有订单";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnSelectSubmit
            // 
            this.btnSelectSubmit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelectSubmit.Location = new System.Drawing.Point(291, 6);
            this.btnSelectSubmit.Name = "btnSelectSubmit";
            this.btnSelectSubmit.Size = new System.Drawing.Size(77, 39);
            this.btnSelectSubmit.TabIndex = 2;
            this.btnSelectSubmit.Text = "查询";
            this.btnSelectSubmit.UseVisualStyleBackColor = true;
            this.btnSelectSubmit.Click += new System.EventHandler(this.btnSelectSubmit_Click);
            // 
            // dataGridOrder
            // 
            this.dataGridOrder.AllowUserToAddRows = false;
            this.dataGridOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridOrder.AutoGenerateColumns = false;
            this.dataGridOrder.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderNoDataGridViewTextBoxColumn,
            this.ClientName,
            this.Column4,
            this.Price,
            this.Item});
            this.dataGridOrder.DataSource = this.bindingSourceOrder;
            this.dataGridOrder.Location = new System.Drawing.Point(0, 188);
            this.dataGridOrder.Name = "dataGridOrder";
            this.dataGridOrder.RowHeadersWidth = 62;
            this.dataGridOrder.RowTemplate.Height = 30;
            this.dataGridOrder.Size = new System.Drawing.Size(824, 303);
            this.dataGridOrder.TabIndex = 0;
            this.dataGridOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridOrder_CellContentClick);
            // 
            // orderNoDataGridViewTextBoxColumn
            // 
            this.orderNoDataGridViewTextBoxColumn.DataPropertyName = "OrderNo";
            this.orderNoDataGridViewTextBoxColumn.HeaderText = "订单号";
            this.orderNoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.orderNoDataGridViewTextBoxColumn.Name = "orderNoDataGridViewTextBoxColumn";
            this.orderNoDataGridViewTextBoxColumn.Width = 150;
            // 
            // ClientName
            // 
            this.ClientName.DataPropertyName = "ClientName";
            this.ClientName.HeaderText = "客户名";
            this.ClientName.MinimumWidth = 8;
            this.ClientName.Name = "ClientName";
            this.ClientName.Width = 150;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Time";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column4.HeaderText = "时间";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "总价";
            this.Price.MinimumWidth = 8;
            this.Price.Name = "Price";
            this.Price.Width = 150;
            // 
            // Item
            // 
            this.Item.HeaderText = "订单项";
            this.Item.MinimumWidth = 8;
            this.Item.Name = "Item";
            this.Item.Text = "订单项";
            this.Item.UseColumnTextForButtonValue = true;
            this.Item.Width = 150;
            // 
            // bindingSourceOrder
            // 
            this.bindingSourceOrder.DataSource = typeof(Homework6.Order);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ClientAttr";
            this.dataGridViewTextBoxColumn1.HeaderText = "客户名";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ClientAttr";
            this.dataGridViewTextBoxColumn2.HeaderText = "客户名";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Client";
            this.dataGridViewTextBoxColumn3.HeaderText = "客户名";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Client";
            this.dataGridViewTextBoxColumn4.HeaderText = "客户名";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Client";
            this.dataGridViewTextBoxColumn5.HeaderText = "客户名";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Client";
            this.dataGridViewTextBoxColumn6.HeaderText = "客户名";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 484);
            this.Controls.Add(this.dataGridOrder);
            this.Controls.Add(this.pnlSelectSubmit);
            this.Controls.Add(this.pnlTop);
            this.Name = "MainForm";
            this.Text = "订单管理";
            this.pnlTop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlSelectSubmit.ResumeLayout(false);
            this.pnlSelectSubmit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel pnlSelectSubmit;
        private System.Windows.Forms.ComboBox cmbSelect;
        private System.Windows.Forms.Label lblSelect1;
        private System.Windows.Forms.TextBox txtSelect;
        private System.Windows.Forms.Button btnSelectSubmit;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.DataGridView dataGridOrder;
        private System.Windows.Forms.BindingSource bindingSourceOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewButtonColumn Item;
    }
}

