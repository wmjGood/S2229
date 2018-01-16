namespace FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsRecordList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.签到ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.签退ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsList = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.cmsRecordList.SuspendLayout();
            this.tsList.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.ContextMenuStrip = this.cmsRecordList;
            this.dataGridView1.Location = new System.Drawing.Point(12, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(568, 277);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Number";
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
            this.Column3.DataPropertyName = "Age";
            this.Column3.HeaderText = "年龄";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Sex";
            this.Column4.HeaderText = "性别";
            this.Column4.Name = "Column4";
            // 
            // cmsRecordList
            // 
            this.cmsRecordList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.签到ToolStripMenuItem,
            this.签退ToolStripMenuItem});
            this.cmsRecordList.Name = "cmsRecordList";
            this.cmsRecordList.Size = new System.Drawing.Size(109, 52);
            // 
            // 签到ToolStripMenuItem
            // 
            this.签到ToolStripMenuItem.Name = "签到ToolStripMenuItem";
            this.签到ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.签到ToolStripMenuItem.Text = "签到";
            this.签到ToolStripMenuItem.Click += new System.EventHandler(this.签到ToolStripMenuItem_Click);
            // 
            // 签退ToolStripMenuItem
            // 
            this.签退ToolStripMenuItem.Name = "签退ToolStripMenuItem";
            this.签退ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.签退ToolStripMenuItem.Text = "签退";
            this.签退ToolStripMenuItem.Click += new System.EventHandler(this.签退ToolStripMenuItem_Click);
            // 
            // tsList
            // 
            this.tsList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.tsList.Location = new System.Drawing.Point(0, 0);
            this.tsList.Name = "tsList";
            this.tsList.Size = new System.Drawing.Size(595, 27);
            this.tsList.TabIndex = 1;
            this.tsList.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(59, 24);
            this.toolStripButton1.Text = "增加";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(59, 24);
            this.toolStripButton2.Text = "修改";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(59, 24);
            this.toolStripButton3.Text = "删除";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(89, 24);
            this.toolStripButton4.Text = "打卡记录";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(94, 58);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(82, 15);
            this.lblNumber.TabIndex = 2;
            this.lblNumber.Text = "员工工号：";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(182, 55);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(225, 25);
            this.txtNumber.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(456, 45);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 40);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "查询";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 415);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.tsList);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmMain";
            this.Text = "员工信息维护";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.cmsRecordList.ResumeLayout(false);
            this.tsList.ResumeLayout(false);
            this.tsList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsList;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip cmsRecordList;
        private System.Windows.Forms.ToolStripMenuItem 签到ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 签退ToolStripMenuItem;
    }
}

