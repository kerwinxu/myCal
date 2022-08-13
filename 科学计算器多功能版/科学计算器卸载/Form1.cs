using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 科学计算器卸载
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnUninstall_Click(object sender, EventArgs e)
        {
            //调用卸载程序

            //我这个卸载只是调用msiexec.exe 完成的。
            string strSys = Environment.SystemDirectory;//取得系统目录
            System.Diagnostics.Process.Start(strSys + "\\msiexec.exe", "/x {660CAB47-9E7D-42BA-854E-58BCFC8053EE} /passive ");//调用msiexec.exe卸载本程序

            this.Dispose();
        }
    }
}
