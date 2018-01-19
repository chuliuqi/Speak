namespace WindowsFormsApp
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBroad = new System.Windows.Forms.Button();
            this.txtBroad = new System.Windows.Forms.TextBox();
            this.lblBroad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBroad
            // 
            this.btnBroad.Location = new System.Drawing.Point(12, 201);
            this.btnBroad.Name = "btnBroad";
            this.btnBroad.Size = new System.Drawing.Size(260, 48);
            this.btnBroad.TabIndex = 0;
            this.btnBroad.Text = "播放";
            this.btnBroad.UseVisualStyleBackColor = true;
            this.btnBroad.Click += new System.EventHandler(this.btnBroad_Click);
            // 
            // txtBroad
            // 
            this.txtBroad.Location = new System.Drawing.Point(12, 34);
            this.txtBroad.Multiline = true;
            this.txtBroad.Name = "txtBroad";
            this.txtBroad.Size = new System.Drawing.Size(260, 161);
            this.txtBroad.TabIndex = 1;
            // 
            // lblBroad
            // 
            this.lblBroad.AutoSize = true;
            this.lblBroad.Location = new System.Drawing.Point(13, 16);
            this.lblBroad.Name = "lblBroad";
            this.lblBroad.Size = new System.Drawing.Size(89, 12);
            this.lblBroad.TabIndex = 2;
            this.lblBroad.Text = "语音播放内容：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblBroad);
            this.Controls.Add(this.txtBroad);
            this.Controls.Add(this.btnBroad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBroad;
        private System.Windows.Forms.TextBox txtBroad;
        private System.Windows.Forms.Label lblBroad;
    }
}

