namespace Sj1
{
    partial class FrmMian
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
            this.grbPlay = new System.Windows.Forms.GroupBox();
            this.rdoPiano = new System.Windows.Forms.RadioButton();
            this.rdoViolin = new System.Windows.Forms.RadioButton();
            this.rdoSachs = new System.Windows.Forms.RadioButton();
            this.btnPaly = new System.Windows.Forms.Button();
            this.grbPlay.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbPlay
            // 
            this.grbPlay.Controls.Add(this.rdoSachs);
            this.grbPlay.Controls.Add(this.rdoViolin);
            this.grbPlay.Controls.Add(this.rdoPiano);
            this.grbPlay.Location = new System.Drawing.Point(45, 43);
            this.grbPlay.Name = "grbPlay";
            this.grbPlay.Size = new System.Drawing.Size(263, 217);
            this.grbPlay.TabIndex = 0;
            this.grbPlay.TabStop = false;
            // 
            // rdoPiano
            // 
            this.rdoPiano.AutoSize = true;
            this.rdoPiano.Location = new System.Drawing.Point(65, 48);
            this.rdoPiano.Name = "rdoPiano";
            this.rdoPiano.Size = new System.Drawing.Size(58, 19);
            this.rdoPiano.TabIndex = 0;
            this.rdoPiano.TabStop = true;
            this.rdoPiano.Text = "钢琴";
            this.rdoPiano.UseVisualStyleBackColor = true;
            // 
            // rdoViolin
            // 
            this.rdoViolin.AutoSize = true;
            this.rdoViolin.Location = new System.Drawing.Point(65, 102);
            this.rdoViolin.Name = "rdoViolin";
            this.rdoViolin.Size = new System.Drawing.Size(73, 19);
            this.rdoViolin.TabIndex = 1;
            this.rdoViolin.TabStop = true;
            this.rdoViolin.Text = "小提琴";
            this.rdoViolin.UseVisualStyleBackColor = true;
            // 
            // rdoSachs
            // 
            this.rdoSachs.AutoSize = true;
            this.rdoSachs.Location = new System.Drawing.Point(65, 159);
            this.rdoSachs.Name = "rdoSachs";
            this.rdoSachs.Size = new System.Drawing.Size(73, 19);
            this.rdoSachs.TabIndex = 2;
            this.rdoSachs.TabStop = true;
            this.rdoSachs.Text = "萨克斯";
            this.rdoSachs.UseVisualStyleBackColor = true;
            // 
            // btnPaly
            // 
            this.btnPaly.Location = new System.Drawing.Point(110, 282);
            this.btnPaly.Name = "btnPaly";
            this.btnPaly.Size = new System.Drawing.Size(88, 28);
            this.btnPaly.TabIndex = 1;
            this.btnPaly.Text = "演奏";
            this.btnPaly.UseVisualStyleBackColor = true;
            this.btnPaly.Click += new System.EventHandler(this.btnPaly_Click);
            // 
            // FrmMian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 331);
            this.Controls.Add(this.btnPaly);
            this.Controls.Add(this.grbPlay);
            this.Name = "FrmMian";
            this.Text = "乐器比赛";
            this.grbPlay.ResumeLayout(false);
            this.grbPlay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPlay;
        private System.Windows.Forms.RadioButton rdoPiano;
        private System.Windows.Forms.RadioButton rdoViolin;
        private System.Windows.Forms.RadioButton rdoSachs;
        private System.Windows.Forms.Button btnPaly;
    }
}