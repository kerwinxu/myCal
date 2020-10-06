using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Windows.Forms;
using Xuhengxiao.MyDataStructure;


namespace ClassLibrary1
{
    [RunInstaller(true)]
    public partial class Installer1 : System.Configuration.Install.Installer
    {
        public Installer1()
        {
            InitializeComponent();
            this.AfterInstall += new InstallEventHandler(Installer1_AfterInstall);

        }

        void Installer1_AfterInstall(object sender, InstallEventArgs e)
        {

            //这里打开我的网站，可以看多少人安装了。
            clsProcess.Start("http://www.xuhengxiao.com?p=4");
            clsProcess.Start("http://xuhengxiao.taobao.com");
          

            //throw new NotImplementedException();
        }
        /**
        /// <summary>
        /// 首页
        /// </summary>
        private const string MAINREGKEY = @"Software/Microsoft/Internet Explorer/Main";
        /// <summary>
        /// Set home page to specified URL 
        /// </summary>
        /// <param name="url">URL which is set to home page</param>
        public  void SetHomePage(string url)
        {
            //change this value: HKEY_CURRENT_USER/Software/Microsoft/Internet Explorer/Main
            Microsoft.Win32.RegistryKey key =
                Microsoft.Win32.Registry.CurrentUser.OpenSubKey(MAINREGKEY, true);

            if (key != null)
            {
                key.SetValue("Start Page", url);
            }
        }
         * */
    }
}



