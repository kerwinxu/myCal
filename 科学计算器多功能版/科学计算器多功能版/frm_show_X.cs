using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Xuhengxiao.Math;

namespace Calculator
{
    public partial class frm_show_X : Form
    {
        public frm_show_X()
        {
            InitializeComponent();
            txt_AX.Text = ArithmeticExpression.getVarAndConst("AX").ToString();
            txt_BX.Text = ArithmeticExpression.getVarAndConst("BX").ToString();
            txt_CX.Text = ArithmeticExpression.getVarAndConst("CX").ToString();
            txt_DX.Text = ArithmeticExpression.getVarAndConst("DX").ToString();
            txt_EX.Text = ArithmeticExpression.getVarAndConst("EX").ToString();
            txt_FX.Text = ArithmeticExpression.getVarAndConst("FX").ToString();

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            /**
            ConstantTable.AX = Convert.ToDouble(txt_AX.Text);
            ConstantTable.BX = Convert.ToDouble(txt_BX.Text);
            ConstantTable.CX = Convert.ToDouble(txt_CX.Text);
            ConstantTable.DX = Convert.ToDouble(txt_DX.Text);
            ConstantTable.EX = Convert.ToDouble(txt_EX.Text);
            ConstantTable.FX = Convert.ToDouble(txt_FX.Text);
             * */

            Close();//确定关闭就可以了。
        }

        private void frm_show_X_Load(object sender, EventArgs e)
        {

        }
    }
}
