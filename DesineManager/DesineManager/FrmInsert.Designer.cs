namespace DesineManager
{
    partial class FrmInsert
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
            this.lblDesineManager = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lblRoom = new System.Windows.Forms.Label();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.lblReason = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRenal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDesineManager
            // 
            this.lblDesineManager.AutoSize = true;
            this.lblDesineManager.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDesineManager.Location = new System.Drawing.Point(214, 51);
            this.lblDesineManager.Name = "lblDesineManager";
            this.lblDesineManager.Size = new System.Drawing.Size(135, 24);
            this.lblDesineManager.TabIndex = 0;
            this.lblDesineManager.Text = "会议室预定";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(130, 102);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(82, 15);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "预定日期：";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(218, 99);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(252, 25);
            this.txtTime.TabIndex = 2;
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Location = new System.Drawing.Point(133, 158);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(67, 15);
            this.lblRoom.TabIndex = 3;
            this.lblRoom.Text = "会议室：";
            // 
            // txtRoom
            // 
            this.txtRoom.Location = new System.Drawing.Point(218, 158);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(252, 25);
            this.txtRoom.TabIndex = 4;
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Location = new System.Drawing.Point(118, 217);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(82, 15);
            this.lblReason.TabIndex = 5;
            this.lblReason.Text = "预定事由：";
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(218, 206);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(252, 25);
            this.txtReason.TabIndex = 6;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(136, 276);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(67, 15);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "预订人：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(218, 266);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(252, 25);
            this.txtName.TabIndex = 8;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(139, 327);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(67, 15);
            this.lblNote.TabIndex = 9;
            this.lblNote.Text = "录入人：";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(218, 324);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(252, 25);
            this.txtNote.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(142, 401);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "确定";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(259, 401);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 30);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRenal
            // 
            this.btnRenal.Location = new System.Drawing.Point(383, 401);
            this.btnRenal.Name = "btnRenal";
            this.btnRenal.Size = new System.Drawing.Size(75, 30);
            this.btnRenal.TabIndex = 13;
            this.btnRenal.Text = "取消";
            this.btnRenal.UseVisualStyleBackColor = true;
            this.btnRenal.Click += new System.EventHandler(this.btnRenal_Click);
            // 
            // FrmInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 486);
            this.Controls.Add(this.btnRenal);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.lblReason);
            this.Controls.Add(this.txtRoom);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDesineManager);
            this.Name = "FrmInsert";
            this.Text = "会议室预定录入";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDesineManager;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRenal;
    }
}