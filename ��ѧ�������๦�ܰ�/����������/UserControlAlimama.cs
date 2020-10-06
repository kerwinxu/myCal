using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 阿里妈妈广告
{
    public partial class UserControlAlimama : UserControl
    {
        public UserControlAlimama()
        {
            InitializeComponent();
        }

        int iPointX = 0;//这个是记录当前的位置
        int iSpend = 10;//滚屏速度

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                //我用这个计时器来实现自动滚屏
                HtmlDocument doc = webBrowser1.Document;
                int iHeight = doc.Body.ClientRectangle.Height;
                iPointX = (iPointX + iSpend) % iHeight;

                doc.Window.ScrollTo(0, iPointX);


            }
            catch (System.Exception ex)
            {
            	
            }

        }

    }
}
