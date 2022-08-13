namespace 阿里妈妈广告
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
            this.userControlAlimama1 = new 阿里妈妈广告.UserControlAlimama();
            this.SuspendLayout();
            // 
            // userControlAlimama1
            // 
            this.userControlAlimama1.Location = new System.Drawing.Point(12, 26);
            this.userControlAlimama1.Name = "userControlAlimama1";
            this.userControlAlimama1.Size = new System.Drawing.Size(810, 210);
            this.userControlAlimama1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 262);
            this.Controls.Add(this.userControlAlimama1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControlAlimama userControlAlimama1;
    }
}

