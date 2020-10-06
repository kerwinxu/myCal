using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Xuhengxiao.Math;


namespace Calculator
{
    public partial class UserControlUnitInput : UserControl
    {
        
        public static string strJiaoDuDanWei="HuDu";

        public UserControlUnitInput()
        {
            InitializeComponent();
            FenMu = 16;//默认分母等于256
        }

        private bool isBritishSystem;
        private decimal decFenMu;//对于英制分数表示，可以选择分母

        //这个用户控件实现两个属性，一个方法就可以了。再加上一个属性，是否英制.
        //单位名称
        public string UnitName
        {
            get { return lblUnitName.Text;}
            set { lblUnitName.Text = value;}
        }

        public bool BritishSystem
        {
            get {return isBritishSystem;}
            set { isBritishSystem = value; }
        }

        public decimal FenMu
        {
            get { return decFenMu; }
            set { decFenMu = value; }
        }

        //单位数值
        //为照顾英制的输入.如果判断为英制，则计算其数值.
        public double UnitValue
        {
            get {

                //这个首先判断是否为空
                if (txtUnitValue.Text == "")
                    return 0.0;

                string str;

                //再判断是否是英制
                if (this.BritishSystem || (txtUnitValue.Text.Contains("/")))
                {
                    //因为英制是有空格的，先将空格替换成 “+” 号
                    str = txtUnitValue.Text.Replace(" ", "+");
                }
                else
                {
                    str = txtUnitValue.Text;
                }
                /**
                //再进行词法分析
                //词法分析
                PhraseAnalyzer.PhraseAnalyzer pa;
                GrammerAnalyzer.SemanticAnalyzer sa;
                PhraseAnalyzer.PhraseStorage ps;

                ps = new PhraseStorage();
                pa = new PhraseAnalyzer.PhraseAnalyzer(str + "#=", ref ps);
                if (pa.Succeed == false)
                {
                    MessageBox.Show("如果要输入英寸几分之一格式的，请这样输入 1+3/8  ，可以允许输入的符号为数字、/、 .");
                    return 0.0;
                }
                //文法分析

                sa = new GrammerAnalyzer.SemanticAnalyzer(ref ps);
                if (sa.Check() == false)
                {	//文法出错
                    MessageBox.Show(sa.ErrorTip);
                    return 0.0;
                }
                //词法正确，计算
                Calculator.CalUnit cunit;
                cunit = new CalUnit(ref ps);

                if (strJiaoDuDanWei.ToUpper() == "JiaoDu".ToUpper())
                {
                    cunit.JiaoDuDanWei = "JiaoDu";
                }
                cunit.Run();
                 * */
                ArithmeticExpression a = new ArithmeticExpression();

                //显示结果
                if (strJiaoDuDanWei.ToUpper() == "JiaoDu".ToUpper())
                {
                    a.JiaoDuDanWei=enumJiaoDuDanWei.JiaoDu;

                }else
                {
                    a.JiaoDuDanWei=enumJiaoDuDanWei.HuDu;

                }


                //显示结果
                return a.Eval2(str);
 
 
            }
            set 
            {
                if (value == 0.0)
                {
                    txtUnitValue.Text = "";
                    return;
                }

                //如果没有小数点，那就不用判断了。
                if (!(value.ToString().Contains(".")))
                {
                    txtUnitValue.Text = value.ToString();
                    return ;
                }


                //如果为英制
                if (this.BritishSystem )
                {
                    //我这里以128为分母
                    string[] strs = ((decimal)value).ToString().Split('.');//double类型的值往往用的是科学记数法。
                    //double dblXiaoshu = double.Parse("0." + strs[1]);//取小数部分，加上小数点了。
                    decimal decXiaoShu = decimal.Parse("0." + strs[1]);//取小数部分，加上小数点了。
                    int intZhengshu = int.Parse(strs[0]);//取得整数部分
                    decimal decFenzi = 1;
                    //decimal decFenMu = 256;//这个设为属性了。


                    //分子一直在增大,退出条件是当分子/分母大于小数部分.
                    while ((decXiaoShu > (decFenzi/ decFenMu))&&(decFenzi<decFenMu))
                    {
                        decFenzi = decFenzi + 1;

                    }//退出说明找到一个刚好大于等于这个小数的数.

                    //再判断这个是否是最接近的.
                    if (((decFenzi / decFenMu) - decXiaoShu) > (decXiaoShu - ((decFenzi - 1) / decFenMu)))
                        decFenzi = decFenzi - 1;//这个说明这个更接近一点。

                    //如果这个分子是偶数，说明还可以精简。
                    while (((int)decFenzi % 2) == 0&&(decFenzi>0))
                    {
                        decFenzi = decFenzi / 2;
                        decFenMu = decFenMu / 2;
                    }

                    //到这里就找到了其分子和分母了。
                    //下边就是组合起来了。
                    txtUnitValue.Text = intZhengshu.ToString() + " " + decFenzi.ToString() + "/" + decFenMu.ToString();
                    return;
                    
                }

                //其他情况,有小数，但不是英制了.
                txtUnitValue.Text = value.ToString();

            }
        }


        private void lblUnitName_Click(object sender, EventArgs e)
        {

        }

        private void UserControlUnitInput_Resize(object sender, EventArgs e)
        {

            BuJu();

            //如下是原先的根据布局做的，
            /*
            //调整控件大小事件处理过程
            //要做到 txtUnitValue 随大小改变.
            //这里只是大概算一下大小.
            int  intWidth=this.Width - lblUnitName.Width - this.btnConvert.Width - 30;
            if (intWidth > 20)//最窄得20
            {
                txtUnitValue.Width = intWidth;
            }
            else
            {
                txtUnitValue.Width = 20;
            }
             */
        }

        public event EventHandler btnConvertClick;

        private void btnConvert_Click(object sender, EventArgs e)
        {
            //触发事件
            btnConvertClick(sender, e);
        }

        private void UserControlUnitInput_Layout(object sender, LayoutEventArgs e)
        {
            BuJu();
        }

        private void BuJu()
        {
            //如下是 单位名称设置,单位名称的宽度是自动调整的
            lblUnitName.Location = new Point(3, 6);

            //如下是换算按钮的位置以及大小
            //这个换算按钮不改变大小，
            //btnConvert.Size = new Size(45, 23);//我已经改成按钮自动调整大小。
            //这个换算按钮的位置是从右边算起的,两个5为按钮两边的空隙
            btnConvert.Location = new Point((this.Width - 5  - btnConvert.Size.Width), 3);

            //这个文本框是随大小改变的。5为空隙
            txtUnitValue.Location = new Point((lblUnitName.Location.X + lblUnitName.Width ), 3);
            txtUnitValue.Width = btnConvert.Location.X - txtUnitValue.Location.X - 5;

        }

        private void txtUnitValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                txtUnitValue.Text = "";

            }
            else if ((e.KeyChar == (char)Keys.Enter))
            {
                //触发事件
                btnConvertClick(sender, e);
            }

        }


    }
}
