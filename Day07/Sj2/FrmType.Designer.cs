namespace Sj2
{
    partial class FrmType
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
            this.grbType = new System.Windows.Forms.GroupBox();
            this.lblLines = new System.Windows.Forms.Label();
            this.lblProblem = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.txtLines = new System.Windows.Forms.TextBox();
            this.txtproblem = new System.Windows.Forms.TextBox();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grbType.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbType
            // 
            this.grbType.Controls.Add(this.btnCancel);
            this.grbType.Controls.Add(this.btnSubmit);
            this.grbType.Controls.Add(this.txtDay);
            this.grbType.Controls.Add(this.txtproblem);
            this.grbType.Controls.Add(this.txtLines);
            this.grbType.Controls.Add(this.lblDay);
            this.grbType.Controls.Add(this.lblProblem);
            this.grbType.Controls.Add(this.lblLines);
            this.grbType.Location = new System.Drawing.Point(12, 24);
            this.grbType.Name = "grbType";
            this.grbType.Size = new System.Drawing.Size(393, 239);
            this.grbType.TabIndex = 0;
            this.grbType.TabStop = false;
            this.grbType.Text = "填写工作指标";
            // 
            // lblLines
            // 
            this.lblLines.AutoSize = true;
            this.lblLines.Location = new System.Drawing.Point(47, 54);
            this.lblLines.Name = "lblLines";
            this.lblLines.Size = new System.Drawing.Size(97, 15);
            this.lblLines.TabIndex = 0;
            this.lblLines.Text = "有效编码行数";
            // 
            // lblProblem
            // 
            this.lblProblem.AutoSize = true;
            this.lblProblem.Location = new System.Drawing.Point(50, 102);
            this.lblProblem.Name = "lblProblem";
            this.lblProblem.Size = new System.Drawing.Size(67, 15);
            this.lblProblem.TabIndex = 1;
            this.lblProblem.Text = "遗留问题";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(53, 149);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(82, 15);
            this.lblDay.TabIndex = 2;
            this.lblDay.Text = "所需工作日";
            // 
            // txtLines
            // 
            this.txtLines.Location = new System.Drawing.Point(171, 43);
            this.txtLines.Name = "txtLines";
            this.txtLines.Size = new System.Drawing.Size(165, 25);
            this.txtLines.TabIndex = 3;
            // 
            // txtproblem
            // 
            this.txtproblem.Location = new System.Drawing.Point(171, 92);
            this.txtproblem.Name = "txtproblem";
            this.txtproblem.Size = new System.Drawing.Size(165, 25);
            this.txtproblem.TabIndex = 3;
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(171, 139);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(165, 25);
            this.txtDay.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(109, 193);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 30);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "提交";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(249, 193);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 278);
            this.Controls.Add(this.grbType);
            this.Name = "FrmType";
            this.Text = "工作类型--编码";
            this.grbType.ResumeLayout(false);
            this.grbType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbType;
        private System.Windows.Forms.Label lblLines;
        private System.Windows.Forms.Label lblProblem;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.TextBox txtproblem;
        private System.Windows.Forms.TextBox txtLines;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
    }
}