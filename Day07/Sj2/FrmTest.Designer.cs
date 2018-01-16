namespace Sj2
{
    partial class FrmTest
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
            this.grbTest = new System.Windows.Forms.GroupBox();
            this.btncanenel = new System.Windows.Forms.Button();
            this.btnSubmitted = new System.Windows.Forms.Button();
            this.txtWorkDay = new System.Windows.Forms.TextBox();
            this.txtpub = new System.Windows.Forms.TextBox();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.lblWorkDay = new System.Windows.Forms.Label();
            this.lblPub = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.grbTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbTest
            // 
            this.grbTest.Controls.Add(this.btncanenel);
            this.grbTest.Controls.Add(this.btnSubmitted);
            this.grbTest.Controls.Add(this.txtWorkDay);
            this.grbTest.Controls.Add(this.txtpub);
            this.grbTest.Controls.Add(this.txtTest);
            this.grbTest.Controls.Add(this.lblWorkDay);
            this.grbTest.Controls.Add(this.lblPub);
            this.grbTest.Controls.Add(this.lblSum);
            this.grbTest.Location = new System.Drawing.Point(12, 25);
            this.grbTest.Name = "grbTest";
            this.grbTest.Size = new System.Drawing.Size(393, 239);
            this.grbTest.TabIndex = 1;
            this.grbTest.TabStop = false;
            this.grbTest.Text = "填写工作指标";
            // 
            // btncanenel
            // 
            this.btncanenel.Location = new System.Drawing.Point(249, 193);
            this.btncanenel.Name = "btncanenel";
            this.btncanenel.Size = new System.Drawing.Size(75, 30);
            this.btncanenel.TabIndex = 4;
            this.btncanenel.Text = "取消";
            this.btncanenel.UseVisualStyleBackColor = true;
            // 
            // btnSubmitted
            // 
            this.btnSubmitted.Location = new System.Drawing.Point(109, 193);
            this.btnSubmitted.Name = "btnSubmitted";
            this.btnSubmitted.Size = new System.Drawing.Size(75, 30);
            this.btnSubmitted.TabIndex = 4;
            this.btnSubmitted.Text = "提交";
            this.btnSubmitted.UseVisualStyleBackColor = true;
            this.btnSubmitted.Click += new System.EventHandler(this.btnSubmitted_Click);
            // 
            // txtWorkDay
            // 
            this.txtWorkDay.Location = new System.Drawing.Point(171, 139);
            this.txtWorkDay.Name = "txtWorkDay";
            this.txtWorkDay.Size = new System.Drawing.Size(165, 25);
            this.txtWorkDay.TabIndex = 3;
            // 
            // txtpub
            // 
            this.txtpub.Location = new System.Drawing.Point(171, 92);
            this.txtpub.Name = "txtpub";
            this.txtpub.Size = new System.Drawing.Size(165, 25);
            this.txtpub.TabIndex = 3;
            // 
            // txtTest
            // 
            this.txtTest.Location = new System.Drawing.Point(171, 43);
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(165, 25);
            this.txtTest.TabIndex = 3;
            // 
            // lblWorkDay
            // 
            this.lblWorkDay.AutoSize = true;
            this.lblWorkDay.Location = new System.Drawing.Point(53, 149);
            this.lblWorkDay.Name = "lblWorkDay";
            this.lblWorkDay.Size = new System.Drawing.Size(82, 15);
            this.lblWorkDay.TabIndex = 2;
            this.lblWorkDay.Text = "所需工作日";
            // 
            // lblPub
            // 
            this.lblPub.AutoSize = true;
            this.lblPub.Location = new System.Drawing.Point(50, 102);
            this.lblPub.Name = "lblPub";
            this.lblPub.Size = new System.Drawing.Size(106, 15);
            this.lblPub.TabIndex = 1;
            this.lblPub.Text = "发现的Bug数量";
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(47, 54);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(97, 15);
            this.lblSum.TabIndex = 0;
            this.lblSum.Text = "测试用例个数";
            // 
            // FrmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 280);
            this.Controls.Add(this.grbTest);
            this.Name = "FrmTest";
            this.Text = "工作类型--测试";
            this.grbTest.ResumeLayout(false);
            this.grbTest.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTest;
        private System.Windows.Forms.Button btncanenel;
        private System.Windows.Forms.Button btnSubmitted;
        private System.Windows.Forms.TextBox txtWorkDay;
        private System.Windows.Forms.TextBox txtpub;
        private System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.Label lblWorkDay;
        private System.Windows.Forms.Label lblPub;
        private System.Windows.Forms.Label lblSum;
    }
}