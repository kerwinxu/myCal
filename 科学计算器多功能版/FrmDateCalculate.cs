using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class FrmDateCalculate : Form
    {
        public FrmDateCalculate()
        {
            InitializeComponent();
        }

        private void btnShowDadeAfter_Click(object sender, EventArgs e)
        {
            dateAfter();
        }

        private void dateAfter()
        {
            //首先判断是否有日期差,如没有就直接返回
            if (txtDateAfter.Text == "")
                return;
            
            
            //取得开始日期
            DateTime dt1 = monthCalendarStartingDate.SelectionStart;

            //取得根据多少天算出来的结束日期，不包含今天
            DateTime dt2 = dt1.AddDays(double.Parse(txtDateAfter.Text));

            //判断是否选中包含今天如包含今天，就减去一天.
            if (chkBoxIncludeToday2.Checked)
            {
                DateTime dt3 = dt2.AddDays(-1);
                monthCalendarExpiringDate.SelectionStart = dt3;
                monthCalendarExpiringDate.SelectionEnd = dt3;
                return;

            }

            //如果没有选择包含今天，就为不包含了。
            monthCalendarExpiringDate.SelectionStart = dt2;
            monthCalendarExpiringDate.SelectionEnd = dt2;


        }

        private void chkBoxIncludeToday2_CheckedChanged(object sender, EventArgs e)
        {
            dateAfter();
        }

        private void dateDifference()
        {
            //取得日期差
            int i=(monthCalendarExpiringDate.SelectionStart - monthCalendarStartingDate.SelectionStart).Days;
            
            //如果包含今天，就加上一天
            if (chkBoxIncludeToday1.Checked)
                i=i+1;

            //显示
            txtDateDifference.Text = i.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dateDifference();
        }

        private void monthCalendarStartingDate_DateSelected(object sender, DateRangeEventArgs e)
        {
            dateDifference();
        }

        private void chkBoxIncludeToday1_CheckedChanged(object sender, EventArgs e)
        {
            dateDifference();
        }

    }
}
