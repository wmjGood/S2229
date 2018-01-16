namespace MyMoShou
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.lblAdmin = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPwd = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblRemark = new System.Windows.Forms.Label();
            this.lblregister = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.BackColor = System.Drawing.Color.Transparent;
            this.lblAdmin.Font = new System.Drawing.Font("仿宋", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAdmin.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblAdmin.Location = new System.Drawing.Point(34, 140);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(160, 24);
            this.lblAdmin.TabIndex = 0;
            this.lblAdmin.Text = "电子邮件地址";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(47, 199);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(465, 25);
            this.txtEmail.TabIndex = 1;
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.BackColor = System.Drawing.Color.Transparent;
            this.lblPwd.Font = new System.Drawing.Font("仿宋", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPwd.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblPwd.Location = new System.Drawing.Point(44, 257);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(60, 24);
            this.lblPwd.TabIndex = 2;
            this.lblPwd.Text = "密码";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(47, 307);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(465, 25);
            this.txtPwd.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("仿宋", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLogin.Location = new System.Drawing.Point(68, 378);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(93, 40);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.BackColor = System.Drawing.Color.Transparent;
            this.lblRemark.Font = new System.Drawing.Font("仿宋", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRemark.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblRemark.Location = new System.Drawing.Point(44, 440);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(219, 20);
            this.lblRemark.TabIndex = 5;
            this.lblRemark.Text = "还没有通行证？现在就";
            // 
            // lblregister
            // 
            this.lblregister.AutoSize = true;
            this.lblregister.BackColor = System.Drawing.Color.Transparent;
            this.lblregister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblregister.Font = new System.Drawing.Font("仿宋", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblregister.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblregister.Location = new System.Drawing.Point(269, 440);
            this.lblregister.Name = "lblregister";
            this.lblregister.Size = new System.Drawing.Size(51, 20);
            this.lblregister.TabIndex = 6;
            this.lblregister.Text = "注册";
            this.lblregister.Click += new System.EventHandler(this.lblregister_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(600, 524);
            this.Controls.Add(this.lblregister);
            this.Controls.Add(this.lblRemark);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblAdmin);
            this.Name = "FrmLogin";
            this.Text = "登录页面";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.Label lblregister;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtPwd;
    }
}

