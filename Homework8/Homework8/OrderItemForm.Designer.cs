namespace Homework8
{
    partial class OrderItemForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridOrderItem = new System.Windows.Forms.DataGridView();
            this.bindingSourceOrderItem = new System.Windows.Forms.BindingSource(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrderItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOrderItem)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridOrderItem
            // 
            this.dataGridOrderItem.AllowUserToAddRows = false;
            this.dataGridOrderItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridOrderItem.AutoGenerateColumns = false;
            this.dataGridOrderItem.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridOrderItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrderItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.numDataGridViewTextBoxColumn});
            this.dataGridOrderItem.DataSource = this.bindingSourceOrderItem;
            this.dataGridOrderItem.Location = new System.Drawing.Point(0, 0);
            this.dataGridOrderItem.Name = "dataGridOrderItem";
            this.dataGridOrderItem.RowHeadersWidth = 62;
            this.dataGridOrderItem.RowTemplate.Height = 30;
            this.dataGridOrderItem.Size = new System.Drawing.Size(785, 229);
            this.dataGridOrderItem.TabIndex = 0;
            // 
            // bindingSourceOrderItem
            // 
            this.bindingSourceOrderItem.DataSource = typeof(Homework6.OrderItem);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Name";
            this.Column1.HeaderText = "商品名";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Price";
            this.Column2.HeaderText = "商品单价";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // numDataGridViewTextBoxColumn
            // 
            this.numDataGridViewTextBoxColumn.DataPropertyName = "Num";
            this.numDataGridViewTextBoxColumn.HeaderText = "商品数量";
            this.numDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.numDataGridViewTextBoxColumn.Name = "numDataGridViewTextBoxColumn";
            this.numDataGridViewTextBoxColumn.Width = 150;
            // 
            // OrderItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 230);
            this.Controls.Add(this.dataGridOrderItem);
            this.Name = "OrderItemForm";
            this.Text = "订单详细";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrderItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOrderItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridOrderItem;
        private System.Windows.Forms.BindingSource bindingSourceOrderItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDataGridViewTextBoxColumn;
    }
}