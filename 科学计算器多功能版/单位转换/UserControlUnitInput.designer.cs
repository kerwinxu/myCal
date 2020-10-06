namespace Calculator
{
    partial class UserControlUnitInput
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtUnitValue = new System.Windows.Forms.TextBox();
            this.lblUnitName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.AutoSize = true;
            this.btnConvert.Location = new System.Drawing.Point(234, 3);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(45, 23);
            this.btnConvert.TabIndex = 1;
            this.btnConvert.Text = "换算";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // txtUnitValue
            // 
            this.txtUnitValue.Location = new System.Drawing.Point(55, 3);
            this.txtUnitValue.Name = "txtUnitValue";
            this.txtUnitValue.Size = new System.Drawing.Size(173, 21);
            this.txtUnitValue.TabIndex = 2;
            this.txtUnitValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnitValue_KeyPress);
            // 
            // lblUnitName
            // 
            this.lblUnitName.AutoSize = true;
            this.lblUnitName.Location = new System.Drawing.Point(3, 6);
            this.lblUnitName.Name = "lblUnitName";
            this.lblUnitName.Size = new System.Drawing.Size(29, 12);
            this.lblUnitName.TabIndex = 0;
            this.lblUnitName.Text = "单位";
            this.lblUnitName.Click += new System.EventHandler(this.lblUnitName_Click);
            // 
            // UserControlUnitInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblUnitName);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtUnitValue);
            this.Name = "UserControlUnitInput";
            this.Size = new System.Drawing.Size(282, 26);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.UserControlUnitInput_Layout);
            this.Resize += new System.EventHandler(this.UserControlUnitInput_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txtUnitValue;
        private System.Windows.Forms.Label lblUnitName;

    }
}
