namespace Sj2
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
            this.components = new System.ComponentModel.Container();
            this.grbDoWork = new System.Windows.Forms.GroupBox();
            this.dgvDoWork = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsDoWork = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.执行ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.完成情况ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbDoWork.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoWork)).BeginInit();
            this.cmsDoWork.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDoWork
            // 
            this.grbDoWork.Controls.Add(this.dgvDoWork);
            this.grbDoWork.Location = new System.Drawing.Point(12, 24);
            this.grbDoWork.Name = "grbDoWork";
            this.grbDoWork.Size = new System.Drawing.Size(555, 350);
            this.grbDoWork.TabIndex = 0;
            this.grbDoWork.TabStop = false;
            this.grbDoWork.Text = "员工";
            // 
            // dgvDoWork
            // 
            this.dgvDoWork.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoWork.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvDoWork.ContextMenuStrip = this.cmsDoWork;
            this.dgvDoWork.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dgvDoWork.Location = new System.Drawing.Point(6, 24);
            this.dgvDoWork.Name = "dgvDoWork";
            this.dgvDoWork.RowHeadersVisible = false;
            this.dgvDoWork.RowTemplate.Height = 27;
            this.dgvDoWork.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoWork.Size = new System.Drawing.Size(543, 320);
            this.dgvDoWork.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Type";
            this.Column1.HeaderText = "工作类型";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "工作名称";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Description";
            this.Column3.HeaderText = "工作描述";
            this.Column3.Name = "Column3";
            // 
            // cmsDoWork
            // 
            this.cmsDoWork.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.执行ToolStripMenuItem,
            this.完成情况ToolStripMenuItem});
            this.cmsDoWork.Name = "cmsDoWork";
            this.cmsDoWork.Size = new System.Drawing.Size(153, 74);
            // 
            // 执行ToolStripMenuItem
            // 
            this.执行ToolStripMenuItem.Name = "执行ToolStripMenuItem";
            this.执行ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.执行ToolStripMenuItem.Text = "执行";
            this.执行ToolStripMenuItem.Click += new System.EventHandler(this.执行ToolStripMenuItem_Click);
            // 
            // 完成情况ToolStripMenuItem
            // 
            this.完成情况ToolStripMenuItem.Name = "完成情况ToolStripMenuItem";
            this.完成情况ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.完成情况ToolStripMenuItem.Text = "完成情况";
            this.完成情况ToolStripMenuItem.Click += new System.EventHandler(this.完成情况ToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 381);
            this.Controls.Add(this.grbDoWork);
            this.Name = "FrmMain";
            this.Text = "月工作列表";
            this.grbDoWork.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoWork)).EndInit();
            this.cmsDoWork.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDoWork;
        private System.Windows.Forms.DataGridView dgvDoWork;
        private System.Windows.Forms.ContextMenuStrip cmsDoWork;
        private System.Windows.Forms.ToolStripMenuItem 执行ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 完成情况ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

