namespace jd5
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
            this.picPanel = new System.Windows.Forms.Panel();
            this.grbGraphics = new System.Windows.Forms.GroupBox();
            this.rdoSquare = new System.Windows.Forms.RadioButton();
            this.rdoRound = new System.Windows.Forms.RadioButton();
            this.grbColor = new System.Windows.Forms.GroupBox();
            this.rdoBlue = new System.Windows.Forms.RadioButton();
            this.rdoYellow = new System.Windows.Forms.RadioButton();
            this.rdoRed = new System.Windows.Forms.RadioButton();
            this.btnDraw = new System.Windows.Forms.Button();
            this.grbGraphics.SuspendLayout();
            this.grbColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // picPanel
            // 
            this.picPanel.Location = new System.Drawing.Point(48, 44);
            this.picPanel.Name = "picPanel";
            this.picPanel.Size = new System.Drawing.Size(320, 287);
            this.picPanel.TabIndex = 0;
            this.picPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.picPanel_Paint);
            // 
            // grbGraphics
            // 
            this.grbGraphics.Controls.Add(this.rdoSquare);
            this.grbGraphics.Controls.Add(this.rdoRound);
            this.grbGraphics.Location = new System.Drawing.Point(409, 29);
            this.grbGraphics.Name = "grbGraphics";
            this.grbGraphics.Size = new System.Drawing.Size(200, 123);
            this.grbGraphics.TabIndex = 1;
            this.grbGraphics.TabStop = false;
            this.grbGraphics.Text = "图形";
            // 
            // rdoSquare
            // 
            this.rdoSquare.AutoSize = true;
            this.rdoSquare.Location = new System.Drawing.Point(26, 81);
            this.rdoSquare.Name = "rdoSquare";
            this.rdoSquare.Size = new System.Drawing.Size(73, 19);
            this.rdoSquare.TabIndex = 1;
            this.rdoSquare.TabStop = true;
            this.rdoSquare.Text = "长方形";
            this.rdoSquare.UseVisualStyleBackColor = true;
            // 
            // rdoRound
            // 
            this.rdoRound.AutoSize = true;
            this.rdoRound.Checked = true;
            this.rdoRound.Location = new System.Drawing.Point(26, 36);
            this.rdoRound.Name = "rdoRound";
            this.rdoRound.Size = new System.Drawing.Size(58, 19);
            this.rdoRound.TabIndex = 0;
            this.rdoRound.TabStop = true;
            this.rdoRound.Text = "圆形";
            this.rdoRound.UseVisualStyleBackColor = true;
            // 
            // grbColor
            // 
            this.grbColor.Controls.Add(this.rdoBlue);
            this.grbColor.Controls.Add(this.rdoYellow);
            this.grbColor.Controls.Add(this.rdoRed);
            this.grbColor.Location = new System.Drawing.Point(409, 179);
            this.grbColor.Name = "grbColor";
            this.grbColor.Size = new System.Drawing.Size(200, 152);
            this.grbColor.TabIndex = 2;
            this.grbColor.TabStop = false;
            this.grbColor.Text = "颜色";
            // 
            // rdoBlue
            // 
            this.rdoBlue.AutoSize = true;
            this.rdoBlue.Location = new System.Drawing.Point(26, 116);
            this.rdoBlue.Name = "rdoBlue";
            this.rdoBlue.Size = new System.Drawing.Size(58, 19);
            this.rdoBlue.TabIndex = 0;
            this.rdoBlue.TabStop = true;
            this.rdoBlue.Text = "蓝色";
            this.rdoBlue.UseVisualStyleBackColor = true;
            // 
            // rdoYellow
            // 
            this.rdoYellow.AutoSize = true;
            this.rdoYellow.Location = new System.Drawing.Point(26, 79);
            this.rdoYellow.Name = "rdoYellow";
            this.rdoYellow.Size = new System.Drawing.Size(58, 19);
            this.rdoYellow.TabIndex = 0;
            this.rdoYellow.TabStop = true;
            this.rdoYellow.Text = "黄色";
            this.rdoYellow.UseVisualStyleBackColor = true;
            // 
            // rdoRed
            // 
            this.rdoRed.AutoSize = true;
            this.rdoRed.Checked = true;
            this.rdoRed.Location = new System.Drawing.Point(26, 40);
            this.rdoRed.Name = "rdoRed";
            this.rdoRed.Size = new System.Drawing.Size(58, 19);
            this.rdoRed.TabIndex = 0;
            this.rdoRed.TabStop = true;
            this.rdoRed.Text = "红色";
            this.rdoRed.UseVisualStyleBackColor = true;
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(495, 359);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(99, 29);
            this.btnDraw.TabIndex = 3;
            this.btnDraw.Text = "绘制";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 400);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.grbColor);
            this.Controls.Add(this.grbGraphics);
            this.Controls.Add(this.picPanel);
            this.Name = "Form1";
            this.Text = "绘图板";
            this.grbGraphics.ResumeLayout(false);
            this.grbGraphics.PerformLayout();
            this.grbColor.ResumeLayout(false);
            this.grbColor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbGraphics;
        private System.Windows.Forms.GroupBox grbColor;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.RadioButton rdoRound;
        private System.Windows.Forms.RadioButton rdoSquare;
        private System.Windows.Forms.RadioButton rdoRed;
        private System.Windows.Forms.RadioButton rdoBlue;
        private System.Windows.Forms.RadioButton rdoYellow;
        public System.Windows.Forms.Panel picPanel;
    }
}

