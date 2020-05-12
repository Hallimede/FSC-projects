namespace Homework8
{
    partial class AddForm
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
            this.lblAddFormTitle = new System.Windows.Forms.Label();
            this.lblOrderNo = new System.Windows.Forms.Label();
            this.txtOrderNo = new System.Windows.Forms.TextBox();
            this.lblClientName = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.lblAddFormSubTitle = new System.Windows.Forms.Label();
            this.pnlAddOrderInfo = new System.Windows.Forms.Panel();
            this.pnlAddItemInfo = new System.Windows.Forms.Panel();
            this.txtMerPrice = new System.Windows.Forms.TextBox();
            this.lblMerPrice = new System.Windows.Forms.Label();
            this.txtMerName = new System.Windows.Forms.TextBox();
            this.lblMerName = new System.Windows.Forms.Label();
            this.lblMerNum = new System.Windows.Forms.Label();
            this.txtMerNum = new System.Windows.Forms.TextBox();
            this.btnAddItemSubmit = new System.Windows.Forms.Button();
            this.btnAddOrderSubmit = new System.Windows.Forms.Button();
            this.pnlAddBtns = new System.Windows.Forms.Panel();
            this.pnlAddOrderInfo.SuspendLayout();
            this.pnlAddItemInfo.SuspendLayout();
            this.pnlAddBtns.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAddFormTitle
            // 
            this.lblAddFormTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblAddFormTitle.AutoSize = true;
            this.lblAddFormTitle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAddFormTitle.Location = new System.Drawing.Point(214, 28);
            this.lblAddFormTitle.Name = "lblAddFormTitle";
            this.lblAddFormTitle.Size = new System.Drawing.Size(110, 31);
            this.lblAddFormTitle.TabIndex = 0;
            this.lblAddFormTitle.Text = "添加订单";
            // 
            // lblOrderNo
            // 
            this.lblOrderNo.AutoSize = true;
            this.lblOrderNo.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOrderNo.Location = new System.Drawing.Point(23, 18);
            this.lblOrderNo.Name = "lblOrderNo";
            this.lblOrderNo.Size = new System.Drawing.Size(72, 27);
            this.lblOrderNo.TabIndex = 1;
            this.lblOrderNo.Text = "订单号";
            // 
            // txtOrderNo
            // 
            this.txtOrderNo.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtOrderNo.Location = new System.Drawing.Point(101, 16);
            this.txtOrderNo.Name = "txtOrderNo";
            this.txtOrderNo.Size = new System.Drawing.Size(194, 31);
            this.txtOrderNo.TabIndex = 0;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblClientName.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblClientName.Location = new System.Drawing.Point(23, 65);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(72, 27);
            this.lblClientName.TabIndex = 1;
            this.lblClientName.Text = "客户名";
            // 
            // txtClientName
            // 
            this.txtClientName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtClientName.Location = new System.Drawing.Point(101, 63);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(194, 31);
            this.txtClientName.TabIndex = 1;
            // 
            // lblAddFormSubTitle
            // 
            this.lblAddFormSubTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblAddFormSubTitle.AutoSize = true;
            this.lblAddFormSubTitle.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAddFormSubTitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAddFormSubTitle.Location = new System.Drawing.Point(229, 187);
            this.lblAddFormSubTitle.Name = "lblAddFormSubTitle";
            this.lblAddFormSubTitle.Size = new System.Drawing.Size(84, 25);
            this.lblAddFormSubTitle.TabIndex = 0;
            this.lblAddFormSubTitle.Text = "添加条目";
            // 
            // pnlAddOrderInfo
            // 
            this.pnlAddOrderInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlAddOrderInfo.Controls.Add(this.txtClientName);
            this.pnlAddOrderInfo.Controls.Add(this.lblClientName);
            this.pnlAddOrderInfo.Controls.Add(this.txtOrderNo);
            this.pnlAddOrderInfo.Controls.Add(this.lblOrderNo);
            this.pnlAddOrderInfo.Location = new System.Drawing.Point(100, 73);
            this.pnlAddOrderInfo.Name = "pnlAddOrderInfo";
            this.pnlAddOrderInfo.Size = new System.Drawing.Size(337, 111);
            this.pnlAddOrderInfo.TabIndex = 1;
            // 
            // pnlAddItemInfo
            // 
            this.pnlAddItemInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlAddItemInfo.Controls.Add(this.txtMerNum);
            this.pnlAddItemInfo.Controls.Add(this.lblMerNum);
            this.pnlAddItemInfo.Controls.Add(this.txtMerPrice);
            this.pnlAddItemInfo.Controls.Add(this.lblMerPrice);
            this.pnlAddItemInfo.Controls.Add(this.txtMerName);
            this.pnlAddItemInfo.Controls.Add(this.lblMerName);
            this.pnlAddItemInfo.Location = new System.Drawing.Point(101, 215);
            this.pnlAddItemInfo.Name = "pnlAddItemInfo";
            this.pnlAddItemInfo.Size = new System.Drawing.Size(337, 155);
            this.pnlAddItemInfo.TabIndex = 2;
            // 
            // txtMerPrice
            // 
            this.txtMerPrice.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMerPrice.Location = new System.Drawing.Point(101, 63);
            this.txtMerPrice.Name = "txtMerPrice";
            this.txtMerPrice.Size = new System.Drawing.Size(194, 31);
            this.txtMerPrice.TabIndex = 1;
            // 
            // lblMerPrice
            // 
            this.lblMerPrice.AutoSize = true;
            this.lblMerPrice.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMerPrice.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMerPrice.Location = new System.Drawing.Point(23, 65);
            this.lblMerPrice.Name = "lblMerPrice";
            this.lblMerPrice.Size = new System.Drawing.Size(70, 27);
            this.lblMerPrice.TabIndex = 1;
            this.lblMerPrice.Text = "单   价";
            // 
            // txtMerName
            // 
            this.txtMerName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMerName.Location = new System.Drawing.Point(101, 16);
            this.txtMerName.Name = "txtMerName";
            this.txtMerName.Size = new System.Drawing.Size(194, 31);
            this.txtMerName.TabIndex = 0;
            // 
            // lblMerName
            // 
            this.lblMerName.AutoSize = true;
            this.lblMerName.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMerName.Location = new System.Drawing.Point(23, 18);
            this.lblMerName.Name = "lblMerName";
            this.lblMerName.Size = new System.Drawing.Size(72, 27);
            this.lblMerName.TabIndex = 1;
            this.lblMerName.Text = "商品名";
            // 
            // lblMerNum
            // 
            this.lblMerNum.AutoSize = true;
            this.lblMerNum.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMerNum.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMerNum.Location = new System.Drawing.Point(22, 112);
            this.lblMerNum.Name = "lblMerNum";
            this.lblMerNum.Size = new System.Drawing.Size(70, 27);
            this.lblMerNum.TabIndex = 1;
            this.lblMerNum.Text = "数   量";
            // 
            // txtMerNum
            // 
            this.txtMerNum.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMerNum.Location = new System.Drawing.Point(100, 110);
            this.txtMerNum.Name = "txtMerNum";
            this.txtMerNum.Size = new System.Drawing.Size(194, 31);
            this.txtMerNum.TabIndex = 2;
            // 
            // btnAddItemSubmit
            // 
            this.btnAddItemSubmit.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAddItemSubmit.Location = new System.Drawing.Point(24, 11);
            this.btnAddItemSubmit.Name = "btnAddItemSubmit";
            this.btnAddItemSubmit.Size = new System.Drawing.Size(124, 41);
            this.btnAddItemSubmit.TabIndex = 0;
            this.btnAddItemSubmit.Text = "添加条目";
            this.btnAddItemSubmit.UseVisualStyleBackColor = true;
            this.btnAddItemSubmit.Click += new System.EventHandler(this.btnAddItemSubmit_Click);
            // 
            // btnAddOrderSubmit
            // 
            this.btnAddOrderSubmit.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAddOrderSubmit.Location = new System.Drawing.Point(168, 11);
            this.btnAddOrderSubmit.Name = "btnAddOrderSubmit";
            this.btnAddOrderSubmit.Size = new System.Drawing.Size(124, 41);
            this.btnAddOrderSubmit.TabIndex = 1;
            this.btnAddOrderSubmit.Text = "完成添加";
            this.btnAddOrderSubmit.UseVisualStyleBackColor = true;
            this.btnAddOrderSubmit.Click += new System.EventHandler(this.btnAddOrderSubmit_Click);
            // 
            // pnlAddBtns
            // 
            this.pnlAddBtns.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlAddBtns.Controls.Add(this.btnAddOrderSubmit);
            this.pnlAddBtns.Controls.Add(this.btnAddItemSubmit);
            this.pnlAddBtns.Location = new System.Drawing.Point(100, 386);
            this.pnlAddBtns.Name = "pnlAddBtns";
            this.pnlAddBtns.Size = new System.Drawing.Size(336, 62);
            this.pnlAddBtns.TabIndex = 5;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 521);
            this.Controls.Add(this.pnlAddBtns);
            this.Controls.Add(this.pnlAddItemInfo);
            this.Controls.Add(this.pnlAddOrderInfo);
            this.Controls.Add(this.lblAddFormSubTitle);
            this.Controls.Add(this.lblAddFormTitle);
            this.Name = "AddForm";
            this.Text = "订单添加";
            this.pnlAddOrderInfo.ResumeLayout(false);
            this.pnlAddOrderInfo.PerformLayout();
            this.pnlAddItemInfo.ResumeLayout(false);
            this.pnlAddItemInfo.PerformLayout();
            this.pnlAddBtns.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddFormTitle;
        private System.Windows.Forms.Label lblOrderNo;
        private System.Windows.Forms.TextBox txtOrderNo;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Label lblAddFormSubTitle;
        private System.Windows.Forms.Panel pnlAddOrderInfo;
        private System.Windows.Forms.Panel pnlAddItemInfo;
        private System.Windows.Forms.TextBox txtMerNum;
        private System.Windows.Forms.Label lblMerNum;
        private System.Windows.Forms.TextBox txtMerPrice;
        private System.Windows.Forms.Label lblMerPrice;
        private System.Windows.Forms.TextBox txtMerName;
        private System.Windows.Forms.Label lblMerName;
        private System.Windows.Forms.Button btnAddItemSubmit;
        private System.Windows.Forms.Button btnAddOrderSubmit;
        private System.Windows.Forms.Panel pnlAddBtns;
    }
}