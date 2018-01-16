namespace jd4
{
    partial class SimATM
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
            this.grbSelect = new System.Windows.Forms.GroupBox();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblBalance2 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.btnAtm = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grbTransfer = new System.Windows.Forms.GroupBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.lblAccount = new System.Windows.Forms.Label();
            this.lblMoney3 = new System.Windows.Forms.Label();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.grbInformation = new System.Windows.Forms.GroupBox();
            this.lblUserName2 = new System.Windows.Forms.Label();
            this.lblNumber2 = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblCard = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.txtCard2 = new System.Windows.Forms.TextBox();
            this.txtPwd2 = new System.Windows.Forms.TextBox();
            this.btnInsertCard = new System.Windows.Forms.Button();
            this.btnBackCard = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grbSelect.SuspendLayout();
            this.grbTransfer.SuspendLayout();
            this.grbInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbSelect
            // 
            this.grbSelect.Controls.Add(this.txtMoney);
            this.grbSelect.Controls.Add(this.lblMoney);
            this.grbSelect.Controls.Add(this.lblBalance2);
            this.grbSelect.Controls.Add(this.lblBalance);
            this.grbSelect.Controls.Add(this.btnAtm);
            this.grbSelect.Controls.Add(this.btnSearch);
            this.grbSelect.Location = new System.Drawing.Point(22, 22);
            this.grbSelect.Name = "grbSelect";
            this.grbSelect.Size = new System.Drawing.Size(457, 166);
            this.grbSelect.TabIndex = 0;
            this.grbSelect.TabStop = false;
            this.grbSelect.Text = "查询余额";
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(258, 116);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(124, 25);
            this.txtMoney.TabIndex = 4;
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Location = new System.Drawing.Point(197, 124);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(52, 15);
            this.lblMoney.TabIndex = 3;
            this.lblMoney.Text = "金额：";
            // 
            // lblBalance2
            // 
            this.lblBalance2.AutoSize = true;
            this.lblBalance2.Location = new System.Drawing.Point(255, 50);
            this.lblBalance2.Name = "lblBalance2";
            this.lblBalance2.Size = new System.Drawing.Size(55, 15);
            this.lblBalance2.TabIndex = 2;
            this.lblBalance2.Text = "label1";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(197, 50);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(52, 15);
            this.lblBalance.TabIndex = 1;
            this.lblBalance.Text = "余额：";
            // 
            // btnAtm
            // 
            this.btnAtm.Enabled = false;
            this.btnAtm.Location = new System.Drawing.Point(54, 116);
            this.btnAtm.Name = "btnAtm";
            this.btnAtm.Size = new System.Drawing.Size(93, 30);
            this.btnAtm.TabIndex = 0;
            this.btnAtm.Text = "取款";
            this.btnAtm.UseVisualStyleBackColor = true;
            this.btnAtm.Click += new System.EventHandler(this.btnAtm_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Enabled = false;
            this.btnSearch.Location = new System.Drawing.Point(54, 42);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 30);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grbTransfer
            // 
            this.grbTransfer.Controls.Add(this.txtNumber);
            this.grbTransfer.Controls.Add(this.txtSum);
            this.grbTransfer.Controls.Add(this.lblAccount);
            this.grbTransfer.Controls.Add(this.lblMoney3);
            this.grbTransfer.Controls.Add(this.btnTransfer);
            this.grbTransfer.Location = new System.Drawing.Point(22, 194);
            this.grbTransfer.Name = "grbTransfer";
            this.grbTransfer.Size = new System.Drawing.Size(457, 126);
            this.grbTransfer.TabIndex = 1;
            this.grbTransfer.TabStop = false;
            this.grbTransfer.Text = "转账";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(258, 86);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(124, 25);
            this.txtNumber.TabIndex = 4;
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(258, 32);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(124, 25);
            this.txtSum.TabIndex = 4;
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(197, 89);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(52, 15);
            this.lblAccount.TabIndex = 1;
            this.lblAccount.Text = "账号：";
            // 
            // lblMoney3
            // 
            this.lblMoney3.AutoSize = true;
            this.lblMoney3.Location = new System.Drawing.Point(197, 42);
            this.lblMoney3.Name = "lblMoney3";
            this.lblMoney3.Size = new System.Drawing.Size(52, 15);
            this.lblMoney3.TabIndex = 1;
            this.lblMoney3.Text = "金额：";
            // 
            // btnTransfer
            // 
            this.btnTransfer.Enabled = false;
            this.btnTransfer.Location = new System.Drawing.Point(54, 52);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(93, 30);
            this.btnTransfer.TabIndex = 0;
            this.btnTransfer.Text = "转账";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // grbInformation
            // 
            this.grbInformation.Controls.Add(this.lblUserName2);
            this.grbInformation.Controls.Add(this.lblNumber2);
            this.grbInformation.Controls.Add(this.lblNumber);
            this.grbInformation.Controls.Add(this.lblUserName);
            this.grbInformation.Location = new System.Drawing.Point(22, 326);
            this.grbInformation.Name = "grbInformation";
            this.grbInformation.Size = new System.Drawing.Size(457, 107);
            this.grbInformation.TabIndex = 2;
            this.grbInformation.TabStop = false;
            this.grbInformation.Text = "详细信息";
            // 
            // lblUserName2
            // 
            this.lblUserName2.AutoSize = true;
            this.lblUserName2.Location = new System.Drawing.Point(170, 77);
            this.lblUserName2.Name = "lblUserName2";
            this.lblUserName2.Size = new System.Drawing.Size(55, 15);
            this.lblUserName2.TabIndex = 2;
            this.lblUserName2.Text = "label1";
            // 
            // lblNumber2
            // 
            this.lblNumber2.AutoSize = true;
            this.lblNumber2.Location = new System.Drawing.Point(167, 36);
            this.lblNumber2.Name = "lblNumber2";
            this.lblNumber2.Size = new System.Drawing.Size(55, 15);
            this.lblNumber2.TabIndex = 1;
            this.lblNumber2.Text = "label1";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(80, 36);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(52, 15);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "账号：";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(80, 77);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(67, 15);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "用户名：";
            // 
            // lblCard
            // 
            this.lblCard.AutoSize = true;
            this.lblCard.Location = new System.Drawing.Point(22, 487);
            this.lblCard.Name = "lblCard";
            this.lblCard.Size = new System.Drawing.Size(52, 15);
            this.lblCard.TabIndex = 3;
            this.lblCard.Text = "账号：";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(253, 487);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(52, 15);
            this.lblPwd.TabIndex = 3;
            this.lblPwd.Text = "密码：";
            // 
            // txtCard2
            // 
            this.txtCard2.Location = new System.Drawing.Point(80, 477);
            this.txtCard2.Name = "txtCard2";
            this.txtCard2.Size = new System.Drawing.Size(124, 25);
            this.txtCard2.TabIndex = 4;
            // 
            // txtPwd2
            // 
            this.txtPwd2.Location = new System.Drawing.Point(327, 477);
            this.txtPwd2.Name = "txtPwd2";
            this.txtPwd2.PasswordChar = '*';
            this.txtPwd2.Size = new System.Drawing.Size(124, 25);
            this.txtPwd2.TabIndex = 4;
            // 
            // btnInsertCard
            // 
            this.btnInsertCard.Location = new System.Drawing.Point(96, 525);
            this.btnInsertCard.Name = "btnInsertCard";
            this.btnInsertCard.Size = new System.Drawing.Size(83, 30);
            this.btnInsertCard.TabIndex = 5;
            this.btnInsertCard.Text = "插卡";
            this.btnInsertCard.UseVisualStyleBackColor = true;
            this.btnInsertCard.Click += new System.EventHandler(this.btnInsertCard_Click);
            // 
            // btnBackCard
            // 
            this.btnBackCard.Location = new System.Drawing.Point(222, 525);
            this.btnBackCard.Name = "btnBackCard";
            this.btnBackCard.Size = new System.Drawing.Size(83, 30);
            this.btnBackCard.TabIndex = 5;
            this.btnBackCard.Text = "退卡";
            this.btnBackCard.UseVisualStyleBackColor = true;
            this.btnBackCard.Click += new System.EventHandler(this.btnBackCard_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(346, 525);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(83, 30);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // SimATM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 567);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBackCard);
            this.Controls.Add(this.btnInsertCard);
            this.Controls.Add(this.txtPwd2);
            this.Controls.Add(this.txtCard2);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblCard);
            this.Controls.Add(this.grbInformation);
            this.Controls.Add(this.grbTransfer);
            this.Controls.Add(this.grbSelect);
            this.Name = "SimATM";
            this.Text = "SimATM";
            this.grbSelect.ResumeLayout(false);
            this.grbSelect.PerformLayout();
            this.grbTransfer.ResumeLayout(false);
            this.grbTransfer.PerformLayout();
            this.grbInformation.ResumeLayout(false);
            this.grbInformation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbSelect;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAtm;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblBalance2;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.GroupBox grbTransfer;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Label lblMoney3;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.GroupBox grbInformation;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblNumber2;
        private System.Windows.Forms.Label lblUserName2;
        private System.Windows.Forms.Label lblCard;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox txtCard2;
        private System.Windows.Forms.TextBox txtPwd2;
        private System.Windows.Forms.Button btnInsertCard;
        private System.Windows.Forms.Button btnBackCard;
        private System.Windows.Forms.Button btnExit;
    }
}

