namespace Calculator
{
    partial class FrmDateCalculate
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
            this.monthCalendarStartingDate = new System.Windows.Forms.MonthCalendar();
            this.monthCalendarExpiringDate = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDateDifference = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDateAfter = new System.Windows.Forms.TextBox();
            this.chkBoxIncludeToday1 = new System.Windows.Forms.CheckBox();
            this.chkBoxIncludeToday2 = new System.Windows.Forms.CheckBox();
            this.btnShowDadeAfter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthCalendarStartingDate
            // 
            this.monthCalendarStartingDate.Location = new System.Drawing.Point(18, 29);
            this.monthCalendarStartingDate.Name = "monthCalendarStartingDate";
            this.monthCalendarStartingDate.TabIndex = 0;
            this.monthCalendarStartingDate.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarStartingDate_DateSelected);
            // 
            // monthCalendarExpiringDate
            // 
            this.monthCalendarExpiringDate.Location = new System.Drawing.Point(344, 29);
            this.monthCalendarExpiringDate.Name = "monthCalendarExpiringDate";
            this.monthCalendarExpiringDate.TabIndex = 1;
            this.monthCalendarExpiringDate.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarStartingDate_DateSelected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "开始日期";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(463, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "到期日期";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "两天日期差为：";
            // 
            // txtDateDifference
            // 
            this.txtDateDifference.Location = new System.Drawing.Point(363, 188);
            this.txtDateDifference.Name = "txtDateDifference";
            this.txtDateDifference.Size = new System.Drawing.Size(100, 21);
            this.txtDateDifference.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "显示           天后是哪天。";
            // 
            // txtDateAfter
            // 
            this.txtDateAfter.Location = new System.Drawing.Point(295, 229);
            this.txtDateAfter.Name = "txtDateAfter";
            this.txtDateAfter.Size = new System.Drawing.Size(62, 21);
            this.txtDateAfter.TabIndex = 7;
            // 
            // chkBoxIncludeToday1
            // 
            this.chkBoxIncludeToday1.AutoSize = true;
            this.chkBoxIncludeToday1.Location = new System.Drawing.Point(168, 196);
            this.chkBoxIncludeToday1.Name = "chkBoxIncludeToday1";
            this.chkBoxIncludeToday1.Size = new System.Drawing.Size(72, 16);
            this.chkBoxIncludeToday1.TabIndex = 8;
            this.chkBoxIncludeToday1.Text = "包含今天";
            this.chkBoxIncludeToday1.UseVisualStyleBackColor = true;
            this.chkBoxIncludeToday1.CheckedChanged += new System.EventHandler(this.chkBoxIncludeToday1_CheckedChanged);
            // 
            // chkBoxIncludeToday2
            // 
            this.chkBoxIncludeToday2.AutoSize = true;
            this.chkBoxIncludeToday2.Location = new System.Drawing.Point(168, 234);
            this.chkBoxIncludeToday2.Name = "chkBoxIncludeToday2";
            this.chkBoxIncludeToday2.Size = new System.Drawing.Size(72, 16);
            this.chkBoxIncludeToday2.TabIndex = 9;
            this.chkBoxIncludeToday2.Text = "包含今天";
            this.chkBoxIncludeToday2.UseVisualStyleBackColor = true;
            this.chkBoxIncludeToday2.CheckedChanged += new System.EventHandler(this.chkBoxIncludeToday2_CheckedChanged);
            // 
            // btnShowDadeAfter
            // 
            this.btnShowDadeAfter.Location = new System.Drawing.Point(441, 227);
            this.btnShowDadeAfter.Name = "btnShowDadeAfter";
            this.btnShowDadeAfter.Size = new System.Drawing.Size(75, 23);
            this.btnShowDadeAfter.TabIndex = 10;
            this.btnShowDadeAfter.Text = "显示";
            this.btnShowDadeAfter.UseVisualStyleBackColor = true;
            this.btnShowDadeAfter.Click += new System.EventHandler(this.btnShowDadeAfter_Click);
            // 
            // FrmDateCalculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 310);
            this.Controls.Add(this.btnShowDadeAfter);
            this.Controls.Add(this.chkBoxIncludeToday2);
            this.Controls.Add(this.chkBoxIncludeToday1);
            this.Controls.Add(this.txtDateAfter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDateDifference);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendarExpiringDate);
            this.Controls.Add(this.monthCalendarStartingDate);
            this.Name = "FrmDateCalculate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "日期计算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendarStartingDate;
        private System.Windows.Forms.MonthCalendar monthCalendarExpiringDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDateDifference;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDateAfter;
        private System.Windows.Forms.CheckBox chkBoxIncludeToday1;
        private System.Windows.Forms.CheckBox chkBoxIncludeToday2;
        private System.Windows.Forms.Button btnShowDadeAfter;
    }
}