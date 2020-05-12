namespace Homework8
{
    partial class DeleteForm
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
            this.lblDeleteFormTitle = new System.Windows.Forms.Label();
            this.btnDeleteSubmit = new System.Windows.Forms.Button();
            this.lblDeleteOrderNo = new System.Windows.Forms.Label();
            this.cmbDeleteOrderNo = new System.Windows.Forms.ComboBox();
            this.pnlDeleteInfo = new System.Windows.Forms.Panel();
            this.pnlDeleteInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDeleteFormTitle
            // 
            this.lblDeleteFormTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblDeleteFormTitle.AutoSize = true;
            this.lblDeleteFormTitle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDeleteFormTitle.Location = new System.Drawing.Point(155, 45);
            this.lblDeleteFormTitle.Name = "lblDeleteFormTitle";
            this.lblDeleteFormTitle.Size = new System.Drawing.Size(110, 31);
            this.lblDeleteFormTitle.TabIndex = 0;
            this.lblDeleteFormTitle.Text = "删除订单";
            // 
            // btnDeleteSubmit
            // 
            this.btnDeleteSubmit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeleteSubmit.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDeleteSubmit.Location = new System.Drawing.Point(147, 168);
            this.btnDeleteSubmit.Name = "btnDeleteSubmit";
            this.btnDeleteSubmit.Size = new System.Drawing.Size(124, 41);
            this.btnDeleteSubmit.TabIndex = 2;
            this.btnDeleteSubmit.Text = "删除订单";
            this.btnDeleteSubmit.UseVisualStyleBackColor = true;
            this.btnDeleteSubmit.Click += new System.EventHandler(this.btnDeleteSubmit_Click);
            // 
            // lblDeleteOrderNo
            // 
            this.lblDeleteOrderNo.AutoSize = true;
            this.lblDeleteOrderNo.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDeleteOrderNo.Location = new System.Drawing.Point(15, 19);
            this.lblDeleteOrderNo.Name = "lblDeleteOrderNo";
            this.lblDeleteOrderNo.Size = new System.Drawing.Size(72, 27);
            this.lblDeleteOrderNo.TabIndex = 1;
            this.lblDeleteOrderNo.Text = "订单号";
            // 
            // cmbDeleteOrderNo
            // 
            this.cmbDeleteOrderNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDeleteOrderNo.FormattingEnabled = true;
            this.cmbDeleteOrderNo.Location = new System.Drawing.Point(93, 20);
            this.cmbDeleteOrderNo.Name = "cmbDeleteOrderNo";
            this.cmbDeleteOrderNo.Size = new System.Drawing.Size(191, 26);
            this.cmbDeleteOrderNo.TabIndex = 3;
            // 
            // pnlDeleteInfo
            // 
            this.pnlDeleteInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlDeleteInfo.Controls.Add(this.cmbDeleteOrderNo);
            this.pnlDeleteInfo.Controls.Add(this.lblDeleteOrderNo);
            this.pnlDeleteInfo.Location = new System.Drawing.Point(59, 78);
            this.pnlDeleteInfo.Name = "pnlDeleteInfo";
            this.pnlDeleteInfo.Size = new System.Drawing.Size(312, 73);
            this.pnlDeleteInfo.TabIndex = 1;
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 270);
            this.Controls.Add(this.pnlDeleteInfo);
            this.Controls.Add(this.btnDeleteSubmit);
            this.Controls.Add(this.lblDeleteFormTitle);
            this.Name = "DeleteForm";
            this.Text = "订单删除";
            this.pnlDeleteInfo.ResumeLayout(false);
            this.pnlDeleteInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeleteFormTitle;
        private System.Windows.Forms.Button btnDeleteSubmit;
        private System.Windows.Forms.Label lblDeleteOrderNo;
        private System.Windows.Forms.ComboBox cmbDeleteOrderNo;
        private System.Windows.Forms.Panel pnlDeleteInfo;
    }
}