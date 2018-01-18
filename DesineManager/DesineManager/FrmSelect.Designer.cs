namespace DesineManager
{
    partial class FrmSelect
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
            this.lblRoonName = new System.Windows.Forms.Label();
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvDesineRoom = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DestineDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoardroomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesineReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DestineMan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoteMan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesineRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRoonName
            // 
            this.lblRoonName.AutoSize = true;
            this.lblRoonName.Location = new System.Drawing.Point(47, 43);
            this.lblRoonName.Name = "lblRoonName";
            this.lblRoonName.Size = new System.Drawing.Size(97, 15);
            this.lblRoonName.TabIndex = 0;
            this.lblRoonName.Text = "会议室名称：";
            // 
            // txtRoomName
            // 
            this.txtRoomName.Location = new System.Drawing.Point(187, 40);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(232, 25);
            this.txtRoomName.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(475, 40);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dgvDesineRoom
            // 
            this.dgvDesineRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDesineRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.DestineDate,
            this.BoardroomName,
            this.DesineReason,
            this.DestineMan,
            this.NoteMan});
            this.dgvDesineRoom.Location = new System.Drawing.Point(12, 86);
            this.dgvDesineRoom.Name = "dgvDesineRoom";
            this.dgvDesineRoom.RowTemplate.Height = 27;
            this.dgvDesineRoom.Size = new System.Drawing.Size(583, 309);
            this.dgvDesineRoom.TabIndex = 3;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "编号";
            this.ID.Name = "ID";
            // 
            // DestineDate
            // 
            this.DestineDate.DataPropertyName = "DestineDate";
            this.DestineDate.HeaderText = "预定日期";
            this.DestineDate.Name = "DestineDate";
            // 
            // BoardroomName
            // 
            this.BoardroomName.DataPropertyName = "BoardroomName";
            this.BoardroomName.HeaderText = "会议室";
            this.BoardroomName.Name = "BoardroomName";
            // 
            // DesineReason
            // 
            this.DesineReason.DataPropertyName = "DesineReason";
            this.DesineReason.HeaderText = "预定事由";
            this.DesineReason.Name = "DesineReason";
            // 
            // DestineMan
            // 
            this.DestineMan.DataPropertyName = "DestineMan";
            this.DestineMan.HeaderText = "预订人";
            this.DestineMan.Name = "DestineMan";
            // 
            // NoteMan
            // 
            this.NoteMan.DataPropertyName = "NoteMan";
            this.NoteMan.HeaderText = "录入人";
            this.NoteMan.Name = "NoteMan";
            // 
            // FrmSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 407);
            this.Controls.Add(this.dgvDesineRoom);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtRoomName);
            this.Controls.Add(this.lblRoonName);
            this.Name = "FrmSelect";
            this.Text = "预订记录";
            this.Load += new System.EventHandler(this.FrmSelect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesineRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRoonName;
        private System.Windows.Forms.TextBox txtRoomName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvDesineRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DestineDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BoardroomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesineReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn DestineMan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoteMan;
    }
}