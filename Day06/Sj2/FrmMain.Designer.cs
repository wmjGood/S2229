﻿namespace Sj2
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
            this.btnOffice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOffice
            // 
            this.btnOffice.Location = new System.Drawing.Point(90, 72);
            this.btnOffice.Name = "btnOffice";
            this.btnOffice.Size = new System.Drawing.Size(143, 34);
            this.btnOffice.TabIndex = 0;
            this.btnOffice.Text = "员工汇报工作";
            this.btnOffice.UseVisualStyleBackColor = true;
            this.btnOffice.Click += new System.EventHandler(this.btnOffice_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 177);
            this.Controls.Add(this.btnOffice);
            this.Name = "FrmMain";
            this.Text = "MyOffice";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOffice;
    }
}

