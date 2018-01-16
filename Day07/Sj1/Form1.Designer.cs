namespace Sj1
{
    partial class Form1
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
            this.grbEngineer = new System.Windows.Forms.GroupBox();
            this.dgvPlay = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsPlay = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.演奏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbEngineer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlay)).BeginInit();
            this.cmsPlay.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbEngineer
            // 
            this.grbEngineer.Controls.Add(this.dgvPlay);
            this.grbEngineer.Location = new System.Drawing.Point(28, 40);
            this.grbEngineer.Name = "grbEngineer";
            this.grbEngineer.Size = new System.Drawing.Size(561, 316);
            this.grbEngineer.TabIndex = 0;
            this.grbEngineer.TabStop = false;
            this.grbEngineer.Text = "参赛选手";
            // 
            // dgvPlay
            // 
            this.dgvPlay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvPlay.ContextMenuStrip = this.cmsPlay;
            this.dgvPlay.Location = new System.Drawing.Point(18, 24);
            this.dgvPlay.Name = "dgvPlay";
            this.dgvPlay.RowHeadersVisible = false;
            this.dgvPlay.RowTemplate.Height = 27;
            this.dgvPlay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlay.Size = new System.Drawing.Size(520, 274);
            this.dgvPlay.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "工号";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "姓名";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Pop";
            this.Column3.HeaderText = "人气值";
            this.Column3.Name = "Column3";
            // 
            // cmsPlay
            // 
            this.cmsPlay.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.演奏ToolStripMenuItem});
            this.cmsPlay.Name = "cmsPlay";
            this.cmsPlay.Size = new System.Drawing.Size(109, 28);
            // 
            // 演奏ToolStripMenuItem
            // 
            this.演奏ToolStripMenuItem.Name = "演奏ToolStripMenuItem";
            this.演奏ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.演奏ToolStripMenuItem.Text = "演奏";
            this.演奏ToolStripMenuItem.Click += new System.EventHandler(this.演奏ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 387);
            this.Controls.Add(this.grbEngineer);
            this.Name = "Form1";
            this.Text = "EngineerForm";
            this.grbEngineer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlay)).EndInit();
            this.cmsPlay.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbEngineer;
        private System.Windows.Forms.ContextMenuStrip cmsPlay;
        private System.Windows.Forms.ToolStripMenuItem 演奏ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        public System.Windows.Forms.DataGridView dgvPlay;
    }
}

