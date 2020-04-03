namespace Homework7
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.lblN = new System.Windows.Forms.Label();
            this.txtLeng = new System.Windows.Forms.TextBox();
            this.lblLeng = new System.Windows.Forms.Label();
            this.txtPer1 = new System.Windows.Forms.TextBox();
            this.lblPer1 = new System.Windows.Forms.Label();
            this.txtPer2 = new System.Windows.Forms.TextBox();
            this.lblPer2 = new System.Windows.Forms.Label();
            this.txtTh1 = new System.Windows.Forms.TextBox();
            this.lblTh1 = new System.Windows.Forms.Label();
            this.txtTh2 = new System.Windows.Forms.TextBox();
            this.lblTh2 = new System.Windows.Forms.Label();
            this.lalColor = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.panelGraphics = new System.Windows.Forms.Panel();
            this.pnlBtn = new System.Windows.Forms.Panel();
            this.pnlInfo.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGenerate.Location = new System.Drawing.Point(22, 12);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(133, 44);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "生成（&R）";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point(95, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(194, 31);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "CaylayTree生成";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(171, 13);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(131, 28);
            this.txtN.TabIndex = 0;
            this.txtN.Text = "10";
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblN.Location = new System.Drawing.Point(17, 13);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(96, 28);
            this.lblN.TabIndex = 3;
            this.lblN.Text = "递归深度";
            // 
            // txtLeng
            // 
            this.txtLeng.Location = new System.Drawing.Point(171, 54);
            this.txtLeng.Name = "txtLeng";
            this.txtLeng.Size = new System.Drawing.Size(131, 28);
            this.txtLeng.TabIndex = 1;
            this.txtLeng.Text = "100";
            // 
            // lblLeng
            // 
            this.lblLeng.AutoSize = true;
            this.lblLeng.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLeng.Location = new System.Drawing.Point(17, 54);
            this.lblLeng.Name = "lblLeng";
            this.lblLeng.Size = new System.Drawing.Size(96, 28);
            this.lblLeng.TabIndex = 3;
            this.lblLeng.Text = "主干长度";
            // 
            // txtPer1
            // 
            this.txtPer1.Location = new System.Drawing.Point(171, 93);
            this.txtPer1.Name = "txtPer1";
            this.txtPer1.Size = new System.Drawing.Size(131, 28);
            this.txtPer1.TabIndex = 2;
            this.txtPer1.Text = "0.6";
            // 
            // lblPer1
            // 
            this.lblPer1.AutoSize = true;
            this.lblPer1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPer1.Location = new System.Drawing.Point(17, 89);
            this.lblPer1.Name = "lblPer1";
            this.lblPer1.Size = new System.Drawing.Size(138, 28);
            this.lblPer1.TabIndex = 3;
            this.lblPer1.Text = "右分支长度比";
            // 
            // txtPer2
            // 
            this.txtPer2.Location = new System.Drawing.Point(171, 130);
            this.txtPer2.Name = "txtPer2";
            this.txtPer2.Size = new System.Drawing.Size(131, 28);
            this.txtPer2.TabIndex = 3;
            this.txtPer2.Text = "0.7";
            // 
            // lblPer2
            // 
            this.lblPer2.AutoSize = true;
            this.lblPer2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPer2.Location = new System.Drawing.Point(17, 130);
            this.lblPer2.Name = "lblPer2";
            this.lblPer2.Size = new System.Drawing.Size(138, 28);
            this.lblPer2.TabIndex = 3;
            this.lblPer2.Text = "左分支长度比";
            // 
            // txtTh1
            // 
            this.txtTh1.Location = new System.Drawing.Point(171, 172);
            this.txtTh1.Name = "txtTh1";
            this.txtTh1.Size = new System.Drawing.Size(63, 28);
            this.txtTh1.TabIndex = 4;
            this.txtTh1.Text = "30";
            // 
            // lblTh1
            // 
            this.lblTh1.AutoSize = true;
            this.lblTh1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTh1.Location = new System.Drawing.Point(17, 172);
            this.lblTh1.Name = "lblTh1";
            this.lblTh1.Size = new System.Drawing.Size(117, 28);
            this.lblTh1.TabIndex = 3;
            this.lblTh1.Text = "右分支角度";
            // 
            // txtTh2
            // 
            this.txtTh2.Location = new System.Drawing.Point(171, 213);
            this.txtTh2.Name = "txtTh2";
            this.txtTh2.Size = new System.Drawing.Size(63, 28);
            this.txtTh2.TabIndex = 5;
            this.txtTh2.Text = "20";
            // 
            // lblTh2
            // 
            this.lblTh2.AutoSize = true;
            this.lblTh2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTh2.Location = new System.Drawing.Point(17, 213);
            this.lblTh2.Name = "lblTh2";
            this.lblTh2.Size = new System.Drawing.Size(117, 28);
            this.lblTh2.TabIndex = 3;
            this.lblTh2.Text = "左分支角度";
            // 
            // lalColor
            // 
            this.lalColor.AutoSize = true;
            this.lalColor.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lalColor.Location = new System.Drawing.Point(17, 257);
            this.lalColor.Name = "lalColor";
            this.lalColor.Size = new System.Drawing.Size(96, 28);
            this.lalColor.TabIndex = 3;
            this.lalColor.Text = "画笔颜色";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(240, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 28);
            this.label9.TabIndex = 3;
            this.label9.Text = "π/180";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(240, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 28);
            this.label10.TabIndex = 3;
            this.label10.Text = "π/180";
            // 
            // cmbColor
            // 
            this.cmbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Items.AddRange(new object[] {
            "BLUE",
            "RED",
            "YELLOW",
            "BLACK",
            "GREEN"});
            this.cmbColor.Location = new System.Drawing.Point(171, 257);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(131, 26);
            this.cmbColor.TabIndex = 6;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClear.Location = new System.Drawing.Point(171, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(131, 44);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button2_Click);
            // 
            // pnlInfo
            // 
            this.pnlInfo.Controls.Add(this.cmbColor);
            this.pnlInfo.Controls.Add(this.txtN);
            this.pnlInfo.Controls.Add(this.lblTh2);
            this.pnlInfo.Controls.Add(this.lblN);
            this.pnlInfo.Controls.Add(this.txtTh2);
            this.pnlInfo.Controls.Add(this.lalColor);
            this.pnlInfo.Controls.Add(this.lblTh1);
            this.pnlInfo.Controls.Add(this.txtLeng);
            this.pnlInfo.Controls.Add(this.txtTh1);
            this.pnlInfo.Controls.Add(this.lblLeng);
            this.pnlInfo.Controls.Add(this.lblPer2);
            this.pnlInfo.Controls.Add(this.txtPer1);
            this.pnlInfo.Controls.Add(this.txtPer2);
            this.pnlInfo.Controls.Add(this.lblPer1);
            this.pnlInfo.Controls.Add(this.label10);
            this.pnlInfo.Controls.Add(this.label9);
            this.pnlInfo.Location = new System.Drawing.Point(26, 64);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(323, 299);
            this.pnlInfo.TabIndex = 1;
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.pnlBtn);
            this.pnlRight.Controls.Add(this.pnlInfo);
            this.pnlRight.Controls.Add(this.lblTitle);
            this.pnlRight.Location = new System.Drawing.Point(579, 55);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(374, 459);
            this.pnlRight.TabIndex = 6;
            // 
            // panelGraphics
            // 
            this.panelGraphics.Location = new System.Drawing.Point(24, 56);
            this.panelGraphics.Name = "panelGraphics";
            this.panelGraphics.Size = new System.Drawing.Size(529, 457);
            this.panelGraphics.TabIndex = 7;
            // 
            // pnlBtn
            // 
            this.pnlBtn.Controls.Add(this.btnClear);
            this.pnlBtn.Controls.Add(this.btnGenerate);
            this.pnlBtn.Location = new System.Drawing.Point(26, 380);
            this.pnlBtn.Name = "pnlBtn";
            this.pnlBtn.Size = new System.Drawing.Size(322, 68);
            this.pnlBtn.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 572);
            this.Controls.Add(this.panelGraphics);
            this.Controls.Add(this.pnlRight);
            this.Name = "MainForm";
            this.Text = "CaylayTree";
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.pnlBtn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.TextBox txtLeng;
        private System.Windows.Forms.Label lblLeng;
        private System.Windows.Forms.TextBox txtPer1;
        private System.Windows.Forms.Label lblPer1;
        private System.Windows.Forms.TextBox txtPer2;
        private System.Windows.Forms.Label lblPer2;
        private System.Windows.Forms.TextBox txtTh1;
        private System.Windows.Forms.Label lblTh1;
        private System.Windows.Forms.TextBox txtTh2;
        private System.Windows.Forms.Label lblTh2;
        private System.Windows.Forms.Label lalColor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel panelGraphics;
        private System.Windows.Forms.Panel pnlBtn;
    }
}

