using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using io.github.kerwinxu.Math.LibMath;


namespace Calculator
{
    public partial class frm_show_X : Form
    {
        public frm_show_X()
        {
            InitializeComponent();


        }

        Parser parser;

        public void init(Parser parser)
        {
            this.parser = parser;
            txt_AX.Text = Parser.ComplexToString(parser.REG["AX"]);
            txt_BX.Text = Parser.ComplexToString(parser.REG["BX"]);
            txt_CX.Text = Parser.ComplexToString(parser.REG["CX"]);
            txt_DX.Text = Parser.ComplexToString(parser.REG["DX"]);
            txt_EX.Text = Parser.ComplexToString(parser.REG["EX"]);
            txt_FX.Text = Parser.ComplexToString(parser.REG["FX"]);
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            parser.REG["AX"] = parser.Parse(txt_AX.Text, false);
            parser.REG["BX"] = parser.Parse(txt_AX.Text, false);
            parser.REG["CX"] = parser.Parse(txt_AX.Text, false);
            parser.REG["DX"] = parser.Parse(txt_AX.Text, false);
            parser.REG["EX"] = parser.Parse(txt_AX.Text, false);
            parser.REG["FX"] = parser.Parse(txt_AX.Text, false);



            Close();//确定关闭就可以了。
        }

        private void frm_show_X_Load(object sender, EventArgs e)
        {

        }
    }
}
