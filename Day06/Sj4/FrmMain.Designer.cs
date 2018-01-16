namespace Sj4
{
    partial class FrmMain
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.grbNum = new System.Windows.Forms.GroupBox();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.cboHao = new System.Windows.Forms.ComboBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.btnSum = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblResult2 = new System.Windows.Forms.Label();
            this.grbNum.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbNum
            // 
            this.grbNum.Controls.Add(this.btnSum);
            this.grbNum.Controls.Add(this.txtNum2);
            this.grbNum.Controls.Add(this.cboHao);
            this.grbNum.Controls.Add(this.txtNum1);
            this.grbNum.Location = new System.Drawing.Point(27, 28);
            this.grbNum.Name = "grbNum";
            this.grbNum.Size = new System.Drawing.Size(525, 110);
            this.grbNum.TabIndex = 0;
            this.grbNum.TabStop = false;
            this.grbNum.Text = "计算";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(48, 43);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 25);
            this.txtNum1.TabIndex = 0;
            // 
            // cboHao
            // 
            this.cboHao.FormattingEnabled = true;
            this.cboHao.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cboHao.Location = new System.Drawing.Point(196, 44);
            this.cboHao.Name = "cboHao";
            this.cboHao.Size = new System.Drawing.Size(60, 23);
            this.cboHao.TabIndex = 1;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(296, 43);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 25);
            this.txtNum2.TabIndex = 2;
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(429, 38);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(75, 31);
            this.btnSum.TabIndex = 3;
            this.btnSum.Text = "计算";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(175, 162);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(67, 15);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "计算结果";
            // 
            // lblResult2
            // 
            this.lblResult2.AutoSize = true;
            this.lblResult2.Location = new System.Drawing.Point(278, 162);
            this.lblResult2.Name = "lblResult2";
            this.lblResult2.Size = new System.Drawing.Size(55, 15);
            this.lblResult2.TabIndex = 2;
            this.lblResult2.Text = "label1";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 203);
            this.Controls.Add(this.lblResult2);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.grbNum);
            this.Name = "FrmMain";
            this.Text = "计算器";
            this.grbNum.ResumeLayout(false);
            this.grbNum.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbNum;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.ComboBox cboHao;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblResult2;
    }
}

