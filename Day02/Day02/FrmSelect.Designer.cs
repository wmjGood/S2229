namespace Day02
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblevaluate = new System.Windows.Forms.Label();
            this.txtevaluate = new System.Windows.Forms.TextBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.btnScore = new System.Windows.Forms.Button();
            this.btnreanle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(44, 71);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(82, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "员工名称：";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(149, 68);
            this.txtname.Name = "txtname";
            this.txtname.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(199, 25);
            this.txtname.TabIndex = 1;
            // 
            // lblevaluate
            // 
            this.lblevaluate.AutoSize = true;
            this.lblevaluate.Location = new System.Drawing.Point(47, 135);
            this.lblevaluate.Name = "lblevaluate";
            this.lblevaluate.Size = new System.Drawing.Size(82, 15);
            this.lblevaluate.TabIndex = 2;
            this.lblevaluate.Text = "填写评价：";
            // 
            // txtevaluate
            // 
            this.txtevaluate.Location = new System.Drawing.Point(149, 125);
            this.txtevaluate.Multiline = true;
            this.txtevaluate.Name = "txtevaluate";
            this.txtevaluate.Size = new System.Drawing.Size(199, 124);
            this.txtevaluate.TabIndex = 3;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(50, 274);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(82, 15);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "年度评分：";
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(149, 263);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(199, 25);
            this.txtScore.TabIndex = 5;
            // 
            // btnScore
            // 
            this.btnScore.Location = new System.Drawing.Point(91, 327);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(87, 29);
            this.btnScore.TabIndex = 6;
            this.btnScore.Text = "评分";
            this.btnScore.UseVisualStyleBackColor = true;
            this.btnScore.Click += new System.EventHandler(this.btnScore_Click);
            // 
            // btnreanle
            // 
            this.btnreanle.Location = new System.Drawing.Point(244, 327);
            this.btnreanle.Name = "btnreanle";
            this.btnreanle.Size = new System.Drawing.Size(85, 29);
            this.btnreanle.TabIndex = 7;
            this.btnreanle.Text = "取消";
            this.btnreanle.UseVisualStyleBackColor = true;
            // 
            // FrmSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 383);
            this.Controls.Add(this.btnreanle);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.txtevaluate);
            this.Controls.Add(this.lblevaluate);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblName);
            this.Name = "FrmSelect";
            this.Text = "FrmSelect";
            this.Load += new System.EventHandler(this.FrmSelect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblevaluate;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnScore;
        private System.Windows.Forms.Button btnreanle;
        public System.Windows.Forms.TextBox txtname;
        public System.Windows.Forms.TextBox txtevaluate;
        public System.Windows.Forms.TextBox txtScore;
    }
}