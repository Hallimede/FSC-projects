namespace Homework8
{
    partial class UpdateForm
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
            this.pnlUpBtns = new System.Windows.Forms.Panel();
            this.btnUpOrderSubmit = new System.Windows.Forms.Button();
            this.btnUpItemSubmit = new System.Windows.Forms.Button();
            this.pnlUpItemInfo = new System.Windows.Forms.Panel();
            this.txtUpMerNum = new System.Windows.Forms.TextBox();
            this.lblUpMerNum = new System.Windows.Forms.Label();
            this.txtUpMerPrice = new System.Windows.Forms.TextBox();
            this.lblUpMerPrice = new System.Windows.Forms.Label();
            this.txtUpMerName = new System.Windows.Forms.TextBox();
            this.lblUpMerName = new System.Windows.Forms.Label();
            this.pnlUpOrderInfo = new System.Windows.Forms.Panel();
            this.cmbUpOrderNo = new System.Windows.Forms.ComboBox();
            this.txtUpClientName = new System.Windows.Forms.TextBox();
            this.lblUpClientName = new System.Windows.Forms.Label();
            this.lblUpOrderNo = new System.Windows.Forms.Label();
            this.lblUpFormSubTitle = new System.Windows.Forms.Label();
            this.lblUpdateFormTitle = new System.Windows.Forms.Label();
            this.pnlUpBtns.SuspendLayout();
            this.pnlUpItemInfo.SuspendLayout();
            this.pnlUpOrderInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUpBtns
            // 
            this.pnlUpBtns.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlUpBtns.Controls.Add(this.btnUpOrderSubmit);
            this.pnlUpBtns.Controls.Add(this.btnUpItemSubmit);
            this.pnlUpBtns.Location = new System.Drawing.Point(98, 393);
            this.pnlUpBtns.Name = "pnlUpBtns";
            this.pnlUpBtns.Size = new System.Drawing.Size(336, 62);
            this.pnlUpBtns.TabIndex = 3;
            // 
            // btnUpOrderSubmit
            // 
            this.btnUpOrderSubmit.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpOrderSubmit.Location = new System.Drawing.Point(170, 11);
            this.btnUpOrderSubmit.Name = "btnUpOrderSubmit";
            this.btnUpOrderSubmit.Size = new System.Drawing.Size(124, 41);
            this.btnUpOrderSubmit.TabIndex = 1;
            this.btnUpOrderSubmit.Text = "完成修改";
            this.btnUpOrderSubmit.UseVisualStyleBackColor = true;
            this.btnUpOrderSubmit.Click += new System.EventHandler(this.btnUpOrderSubmit_Click);
            // 
            // btnUpItemSubmit
            // 
            this.btnUpItemSubmit.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpItemSubmit.Location = new System.Drawing.Point(26, 11);
            this.btnUpItemSubmit.Name = "btnUpItemSubmit";
            this.btnUpItemSubmit.Size = new System.Drawing.Size(124, 41);
            this.btnUpItemSubmit.TabIndex = 0;
            this.btnUpItemSubmit.Text = "添加条目";
            this.btnUpItemSubmit.UseVisualStyleBackColor = true;
            this.btnUpItemSubmit.Click += new System.EventHandler(this.btnUpItemSubmit_Click);
            // 
            // pnlUpItemInfo
            // 
            this.pnlUpItemInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlUpItemInfo.Controls.Add(this.txtUpMerNum);
            this.pnlUpItemInfo.Controls.Add(this.lblUpMerNum);
            this.pnlUpItemInfo.Controls.Add(this.txtUpMerPrice);
            this.pnlUpItemInfo.Controls.Add(this.lblUpMerPrice);
            this.pnlUpItemInfo.Controls.Add(this.txtUpMerName);
            this.pnlUpItemInfo.Controls.Add(this.lblUpMerName);
            this.pnlUpItemInfo.Location = new System.Drawing.Point(99, 222);
            this.pnlUpItemInfo.Name = "pnlUpItemInfo";
            this.pnlUpItemInfo.Size = new System.Drawing.Size(337, 155);
            this.pnlUpItemInfo.TabIndex = 2;
            // 
            // txtUpMerNum
            // 
            this.txtUpMerNum.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUpMerNum.Location = new System.Drawing.Point(100, 110);
            this.txtUpMerNum.Name = "txtUpMerNum";
            this.txtUpMerNum.Size = new System.Drawing.Size(194, 31);
            this.txtUpMerNum.TabIndex = 2;
            // 
            // lblUpMerNum
            // 
            this.lblUpMerNum.AutoSize = true;
            this.lblUpMerNum.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblUpMerNum.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUpMerNum.Location = new System.Drawing.Point(22, 112);
            this.lblUpMerNum.Name = "lblUpMerNum";
            this.lblUpMerNum.Size = new System.Drawing.Size(70, 27);
            this.lblUpMerNum.TabIndex = 1;
            this.lblUpMerNum.Text = "数   量";
            // 
            // txtUpMerPrice
            // 
            this.txtUpMerPrice.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUpMerPrice.Location = new System.Drawing.Point(101, 63);
            this.txtUpMerPrice.Name = "txtUpMerPrice";
            this.txtUpMerPrice.Size = new System.Drawing.Size(194, 31);
            this.txtUpMerPrice.TabIndex = 1;
            // 
            // lblUpMerPrice
            // 
            this.lblUpMerPrice.AutoSize = true;
            this.lblUpMerPrice.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblUpMerPrice.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUpMerPrice.Location = new System.Drawing.Point(23, 65);
            this.lblUpMerPrice.Name = "lblUpMerPrice";
            this.lblUpMerPrice.Size = new System.Drawing.Size(70, 27);
            this.lblUpMerPrice.TabIndex = 1;
            this.lblUpMerPrice.Text = "单   价";
            // 
            // txtUpMerName
            // 
            this.txtUpMerName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUpMerName.Location = new System.Drawing.Point(101, 16);
            this.txtUpMerName.Name = "txtUpMerName";
            this.txtUpMerName.Size = new System.Drawing.Size(194, 31);
            this.txtUpMerName.TabIndex = 0;
            // 
            // lblUpMerName
            // 
            this.lblUpMerName.AutoSize = true;
            this.lblUpMerName.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUpMerName.Location = new System.Drawing.Point(23, 18);
            this.lblUpMerName.Name = "lblUpMerName";
            this.lblUpMerName.Size = new System.Drawing.Size(72, 27);
            this.lblUpMerName.TabIndex = 1;
            this.lblUpMerName.Text = "商品名";
            // 
            // pnlUpOrderInfo
            // 
            this.pnlUpOrderInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlUpOrderInfo.Controls.Add(this.cmbUpOrderNo);
            this.pnlUpOrderInfo.Controls.Add(this.txtUpClientName);
            this.pnlUpOrderInfo.Controls.Add(this.lblUpClientName);
            this.pnlUpOrderInfo.Controls.Add(this.lblUpOrderNo);
            this.pnlUpOrderInfo.Location = new System.Drawing.Point(98, 80);
            this.pnlUpOrderInfo.Name = "pnlUpOrderInfo";
            this.pnlUpOrderInfo.Size = new System.Drawing.Size(337, 111);
            this.pnlUpOrderInfo.TabIndex = 1;
            // 
            // cmbUpOrderNo
            // 
            this.cmbUpOrderNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUpOrderNo.FormattingEnabled = true;
            this.cmbUpOrderNo.Location = new System.Drawing.Point(101, 19);
            this.cmbUpOrderNo.Name = "cmbUpOrderNo";
            this.cmbUpOrderNo.Size = new System.Drawing.Size(191, 26);
            this.cmbUpOrderNo.TabIndex = 0;
            this.cmbUpOrderNo.SelectedIndexChanged += new System.EventHandler(this.cmbUpOrderNo_SelectedIndexChanged);
            // 
            // txtUpClientName
            // 
            this.txtUpClientName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUpClientName.Location = new System.Drawing.Point(101, 63);
            this.txtUpClientName.Name = "txtUpClientName";
            this.txtUpClientName.Size = new System.Drawing.Size(194, 31);
            this.txtUpClientName.TabIndex = 1;
            // 
            // lblUpClientName
            // 
            this.lblUpClientName.AutoSize = true;
            this.lblUpClientName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblUpClientName.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUpClientName.Location = new System.Drawing.Point(23, 65);
            this.lblUpClientName.Name = "lblUpClientName";
            this.lblUpClientName.Size = new System.Drawing.Size(72, 27);
            this.lblUpClientName.TabIndex = 1;
            this.lblUpClientName.Text = "客户名";
            // 
            // lblUpOrderNo
            // 
            this.lblUpOrderNo.AutoSize = true;
            this.lblUpOrderNo.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUpOrderNo.Location = new System.Drawing.Point(23, 18);
            this.lblUpOrderNo.Name = "lblUpOrderNo";
            this.lblUpOrderNo.Size = new System.Drawing.Size(72, 27);
            this.lblUpOrderNo.TabIndex = 1;
            this.lblUpOrderNo.Text = "订单号";
            // 
            // lblUpFormSubTitle
            // 
            this.lblUpFormSubTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblUpFormSubTitle.AutoSize = true;
            this.lblUpFormSubTitle.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUpFormSubTitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblUpFormSubTitle.Location = new System.Drawing.Point(227, 194);
            this.lblUpFormSubTitle.Name = "lblUpFormSubTitle";
            this.lblUpFormSubTitle.Size = new System.Drawing.Size(84, 25);
            this.lblUpFormSubTitle.TabIndex = 6;
            this.lblUpFormSubTitle.Text = "重设条目";
            // 
            // lblUpdateFormTitle
            // 
            this.lblUpdateFormTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblUpdateFormTitle.AutoSize = true;
            this.lblUpdateFormTitle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUpdateFormTitle.Location = new System.Drawing.Point(212, 35);
            this.lblUpdateFormTitle.Name = "lblUpdateFormTitle";
            this.lblUpdateFormTitle.Size = new System.Drawing.Size(110, 31);
            this.lblUpdateFormTitle.TabIndex = 0;
            this.lblUpdateFormTitle.Text = "修改订单";
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 521);
            this.Controls.Add(this.pnlUpBtns);
            this.Controls.Add(this.pnlUpItemInfo);
            this.Controls.Add(this.pnlUpOrderInfo);
            this.Controls.Add(this.lblUpFormSubTitle);
            this.Controls.Add(this.lblUpdateFormTitle);
            this.Name = "UpdateForm";
            this.Text = "订单修改";
            this.pnlUpBtns.ResumeLayout(false);
            this.pnlUpItemInfo.ResumeLayout(false);
            this.pnlUpItemInfo.PerformLayout();
            this.pnlUpOrderInfo.ResumeLayout(false);
            this.pnlUpOrderInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlUpBtns;
        private System.Windows.Forms.Button btnUpOrderSubmit;
        private System.Windows.Forms.Button btnUpItemSubmit;
        private System.Windows.Forms.Panel pnlUpItemInfo;
        private System.Windows.Forms.TextBox txtUpMerNum;
        private System.Windows.Forms.Label lblUpMerNum;
        private System.Windows.Forms.TextBox txtUpMerPrice;
        private System.Windows.Forms.Label lblUpMerPrice;
        private System.Windows.Forms.TextBox txtUpMerName;
        private System.Windows.Forms.Label lblUpMerName;
        private System.Windows.Forms.Panel pnlUpOrderInfo;
        private System.Windows.Forms.TextBox txtUpClientName;
        private System.Windows.Forms.Label lblUpClientName;
        private System.Windows.Forms.Label lblUpOrderNo;
        private System.Windows.Forms.Label lblUpFormSubTitle;
        private System.Windows.Forms.Label lblUpdateFormTitle;
        private System.Windows.Forms.ComboBox cmbUpOrderNo;
    }
}