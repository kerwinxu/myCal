
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Xuhengxiao.Math;
using System.Numerics;
using System.IO;
using Xuhengxiao.MyDataStructure;
using System.Diagnostics;

namespace Calculator
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class MyCal : System.Windows.Forms.Form
	{
		//private System.Windows.Forms.Button btnEqual;
		private System.Windows.Forms.Button btnPlus;
		private System.Windows.Forms.Button btnDivide;
		private System.Windows.Forms.Button btnTimes;
		private System.Windows.Forms.Button btnMinus;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnNum2;
		private System.Windows.Forms.Button btnNum5;
		private System.Windows.Forms.Button btnNum8;
		private System.Windows.Forms.Button btnNum3;
		private System.Windows.Forms.Button btnNum6;
		private System.Windows.Forms.Button btnNum9;
		private System.Windows.Forms.Button btnNum7;
		private System.Windows.Forms.Button btnNum4;
		private System.Windows.Forms.Button btnNum1;
		private System.Windows.Forms.Button btnNum0;
		private System.Windows.Forms.Button btnDot;
		private System.Windows.Forms.TextBox tbResult;
		private System.Windows.Forms.Button btnMod;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnPI;
		private System.Windows.Forms.Button btnANS;
		private System.Windows.Forms.Button btnExp;
		public System.Windows.Forms.Button btnLog;
		public System.Windows.Forms.Button btnLn;
		public System.Windows.Forms.Button btnLg;
		public System.Windows.Forms.Button btnLeftBracket;
		public System.Windows.Forms.Button btnRightBracket;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSqrt;
		private System.Windows.Forms.Button btnCbrt;
		public System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.GroupBox groupBox3;
		public System.Windows.Forms.Button btnAC;
		private System.Windows.Forms.GroupBox groupBox5;
		public System.Windows.Forms.Button btnSto;
		private System.Windows.Forms.Button btnAx;
		private System.Windows.Forms.Button btnBx;
		private System.Windows.Forms.Button btnCx;
		private System.Windows.Forms.Button btnFx;
		private System.Windows.Forms.Button btnEx;
		private System.Windows.Forms.Button btnDx;
		public System.Windows.Forms.Button btnFact;
		private System.Windows.Forms.Button btnX_3;
		private System.Windows.Forms.Button btnX_2;
		private System.Windows.Forms.Button btnX_1;
		public System.Windows.Forms.Button btnClr;
		private System.Windows.Forms.Button btnNegative;
		private System.Windows.Forms.Label tbTip;
		private System.Windows.Forms.TextBox txt_Expression;
        private System.Windows.Forms.Button btnEqual;
        private Button button1;
        private ToolTip toolTip1;
        private Button btnBackspace;
        private Button btnConverter;
        private Button btnDateCalculate;
        private GroupBox groupBox6;
        private RadioButton radioButtonHuDu;
        private RadioButton radioButtonJiaoDu;
        private TextBox textBox1;
        private Button button2;
        private TextBox txtExpression2;
        private Label label2;
        private CheckBox chkFront;
        private IContainer components;
        private Button btnAbs;
        private Label label3;
        private Button button4;
        public Button btnCos;
        public Button btnTg;
        public Button btnSin;
        public Button btnCtg;
        public Button btnAtg;
        public Button btnAsin;
        public Button btnAcos;
        public Button btnActg;
        public Button btnarcsh;
        public Button btncosh;
        public Button btnSinh;
        public Button btnarcch;
        public Button btntanh;
        public Button btnarcth;
        private GroupBox groupBox4;
        public Button button6;


        string strPathHostory = Application.StartupPath + "\\hostory.txt";

		public MyCal()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//



            //加载历史记录
            try
            {
                string strPathHostory = Application.StartupPath + "\\hostory.txt";
                using (System.IO.FileStream fs=File.OpenRead(strPathHostory))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        txtExpression2.AppendText(sr.ReadToEnd());
                    }
                }
            }
            catch (System.Exception ex)
            {
            	
            }

		}

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyCal));
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnTimes = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNegative = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnNum0 = new System.Windows.Forms.Button();
            this.btnNum2 = new System.Windows.Forms.Button();
            this.btnNum5 = new System.Windows.Forms.Button();
            this.btnNum8 = new System.Windows.Forms.Button();
            this.btnNum3 = new System.Windows.Forms.Button();
            this.btnNum6 = new System.Windows.Forms.Button();
            this.btnNum9 = new System.Windows.Forms.Button();
            this.btnNum7 = new System.Windows.Forms.Button();
            this.btnNum4 = new System.Windows.Forms.Button();
            this.btnNum1 = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.btnMod = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPI = new System.Windows.Forms.Button();
            this.btnANS = new System.Windows.Forms.Button();
            this.btnExp = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnLn = new System.Windows.Forms.Button();
            this.btnLg = new System.Windows.Forms.Button();
            this.btnLeftBracket = new System.Windows.Forms.Button();
            this.btnRightBracket = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnCbrt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPower = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnFact = new System.Windows.Forms.Button();
            this.btnX_3 = new System.Windows.Forms.Button();
            this.btnX_2 = new System.Windows.Forms.Button();
            this.btnX_1 = new System.Windows.Forms.Button();
            this.btnSto = new System.Windows.Forms.Button();
            this.btnAC = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnFx = new System.Windows.Forms.Button();
            this.btnEx = new System.Windows.Forms.Button();
            this.btnDx = new System.Windows.Forms.Button();
            this.btnCx = new System.Windows.Forms.Button();
            this.btnBx = new System.Windows.Forms.Button();
            this.btnAx = new System.Windows.Forms.Button();
            this.btnClr = new System.Windows.Forms.Button();
            this.tbTip = new System.Windows.Forms.Label();
            this.txt_Expression = new System.Windows.Forms.TextBox();
            this.btnEqual = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnAbs = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnTg = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnCtg = new System.Windows.Forms.Button();
            this.btnAtg = new System.Windows.Forms.Button();
            this.btnAsin = new System.Windows.Forms.Button();
            this.btnAcos = new System.Windows.Forms.Button();
            this.btnActg = new System.Windows.Forms.Button();
            this.btnarcsh = new System.Windows.Forms.Button();
            this.btncosh = new System.Windows.Forms.Button();
            this.btnSinh = new System.Windows.Forms.Button();
            this.btnarcch = new System.Windows.Forms.Button();
            this.btntanh = new System.Windows.Forms.Button();
            this.btnarcth = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.btnConverter = new System.Windows.Forms.Button();
            this.btnDateCalculate = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.radioButtonHuDu = new System.Windows.Forms.RadioButton();
            this.radioButtonJiaoDu = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtExpression2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkFront = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPlus.Location = new System.Drawing.Point(144, 120);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(30, 20);
            this.btnPlus.TabIndex = 2;
            this.btnPlus.Text = "+";
            this.toolTip1.SetToolTip(this.btnPlus, "加");
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDivide.Location = new System.Drawing.Point(144, 192);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(30, 20);
            this.btnDivide.TabIndex = 3;
            this.btnDivide.Text = "/";
            this.toolTip1.SetToolTip(this.btnDivide, "除");
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnTimes
            // 
            this.btnTimes.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnTimes.Location = new System.Drawing.Point(144, 168);
            this.btnTimes.Name = "btnTimes";
            this.btnTimes.Size = new System.Drawing.Size(30, 20);
            this.btnTimes.TabIndex = 5;
            this.btnTimes.Text = "*";
            this.toolTip1.SetToolTip(this.btnTimes, "乘");
            this.btnTimes.Click += new System.EventHandler(this.btnTimes_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMinus.Location = new System.Drawing.Point(144, 144);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(30, 20);
            this.btnMinus.TabIndex = 6;
            this.btnMinus.Text = "-";
            this.toolTip1.SetToolTip(this.btnMinus, "减，也可以作为负号");
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNegative);
            this.groupBox1.Controls.Add(this.btnDot);
            this.groupBox1.Controls.Add(this.btnNum0);
            this.groupBox1.Controls.Add(this.btnNum2);
            this.groupBox1.Controls.Add(this.btnNum5);
            this.groupBox1.Controls.Add(this.btnNum8);
            this.groupBox1.Controls.Add(this.btnNum3);
            this.groupBox1.Controls.Add(this.btnNum6);
            this.groupBox1.Controls.Add(this.btnNum9);
            this.groupBox1.Controls.Add(this.btnNum7);
            this.groupBox1.Controls.Add(this.btnNum4);
            this.groupBox1.Controls.Add(this.btnNum1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(8, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 124);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // btnNegative
            // 
            this.btnNegative.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNegative.Location = new System.Drawing.Point(88, 88);
            this.btnNegative.Name = "btnNegative";
            this.btnNegative.Size = new System.Drawing.Size(30, 25);
            this.btnNegative.TabIndex = 26;
            this.btnNegative.Text = "i";
            this.toolTip1.SetToolTip(this.btnNegative, "虚数“i”");
            this.btnNegative.Click += new System.EventHandler(this.btnNegative_Click);
            // 
            // btnDot
            // 
            this.btnDot.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDot.Location = new System.Drawing.Point(48, 88);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(30, 25);
            this.btnDot.TabIndex = 25;
            this.btnDot.Text = ".";
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // btnNum0
            // 
            this.btnNum0.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNum0.Location = new System.Drawing.Point(8, 88);
            this.btnNum0.Name = "btnNum0";
            this.btnNum0.Size = new System.Drawing.Size(30, 25);
            this.btnNum0.TabIndex = 24;
            this.btnNum0.Text = "0";
            this.btnNum0.Click += new System.EventHandler(this.btnNum0_Click);
            // 
            // btnNum2
            // 
            this.btnNum2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNum2.Location = new System.Drawing.Point(48, 16);
            this.btnNum2.Name = "btnNum2";
            this.btnNum2.Size = new System.Drawing.Size(30, 25);
            this.btnNum2.TabIndex = 23;
            this.btnNum2.Text = "2";
            this.btnNum2.Click += new System.EventHandler(this.btnNum2_Click);
            // 
            // btnNum5
            // 
            this.btnNum5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNum5.Location = new System.Drawing.Point(48, 40);
            this.btnNum5.Name = "btnNum5";
            this.btnNum5.Size = new System.Drawing.Size(30, 25);
            this.btnNum5.TabIndex = 22;
            this.btnNum5.Text = "5";
            this.btnNum5.Click += new System.EventHandler(this.btnNum5_Click);
            // 
            // btnNum8
            // 
            this.btnNum8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNum8.Location = new System.Drawing.Point(48, 64);
            this.btnNum8.Name = "btnNum8";
            this.btnNum8.Size = new System.Drawing.Size(30, 25);
            this.btnNum8.TabIndex = 21;
            this.btnNum8.Text = "8";
            this.btnNum8.Click += new System.EventHandler(this.btnNum8_Click);
            // 
            // btnNum3
            // 
            this.btnNum3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNum3.Location = new System.Drawing.Point(88, 16);
            this.btnNum3.Name = "btnNum3";
            this.btnNum3.Size = new System.Drawing.Size(30, 25);
            this.btnNum3.TabIndex = 20;
            this.btnNum3.Text = "3";
            this.btnNum3.Click += new System.EventHandler(this.btnNum3_Click);
            // 
            // btnNum6
            // 
            this.btnNum6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNum6.Location = new System.Drawing.Point(88, 40);
            this.btnNum6.Name = "btnNum6";
            this.btnNum6.Size = new System.Drawing.Size(30, 25);
            this.btnNum6.TabIndex = 19;
            this.btnNum6.Text = "6";
            this.btnNum6.Click += new System.EventHandler(this.btnNum6_Click);
            // 
            // btnNum9
            // 
            this.btnNum9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNum9.Location = new System.Drawing.Point(88, 64);
            this.btnNum9.Name = "btnNum9";
            this.btnNum9.Size = new System.Drawing.Size(30, 25);
            this.btnNum9.TabIndex = 18;
            this.btnNum9.Text = "9";
            this.btnNum9.Click += new System.EventHandler(this.btnNum9_Click);
            // 
            // btnNum7
            // 
            this.btnNum7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNum7.Location = new System.Drawing.Point(8, 64);
            this.btnNum7.Name = "btnNum7";
            this.btnNum7.Size = new System.Drawing.Size(30, 25);
            this.btnNum7.TabIndex = 17;
            this.btnNum7.Text = "7";
            this.btnNum7.Click += new System.EventHandler(this.btnNum7_Click);
            // 
            // btnNum4
            // 
            this.btnNum4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNum4.Location = new System.Drawing.Point(8, 40);
            this.btnNum4.Name = "btnNum4";
            this.btnNum4.Size = new System.Drawing.Size(30, 25);
            this.btnNum4.TabIndex = 16;
            this.btnNum4.Text = "4";
            this.btnNum4.Click += new System.EventHandler(this.btnNum4_Click);
            // 
            // btnNum1
            // 
            this.btnNum1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNum1.Location = new System.Drawing.Point(8, 16);
            this.btnNum1.Name = "btnNum1";
            this.btnNum1.Size = new System.Drawing.Size(30, 25);
            this.btnNum1.TabIndex = 15;
            this.btnNum1.Text = "1";
            this.btnNum1.Click += new System.EventHandler(this.btnNum1_Click);
            // 
            // tbResult
            // 
            this.tbResult.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbResult.Location = new System.Drawing.Point(208, 88);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(136, 23);
            this.tbResult.TabIndex = 16;
            this.tbResult.Text = "0.0";
            this.tbResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnMod
            // 
            this.btnMod.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMod.Location = new System.Drawing.Point(144, 216);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(30, 20);
            this.btnMod.TabIndex = 27;
            this.btnMod.Text = "%";
            this.toolTip1.SetToolTip(this.btnMod, "余数");
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPI);
            this.groupBox2.Controls.Add(this.btnANS);
            this.groupBox2.Controls.Add(this.btnExp);
            this.groupBox2.Location = new System.Drawing.Point(10, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(128, 40);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            // 
            // btnPI
            // 
            this.btnPI.Location = new System.Drawing.Point(48, 13);
            this.btnPI.Name = "btnPI";
            this.btnPI.Size = new System.Drawing.Size(32, 20);
            this.btnPI.TabIndex = 28;
            this.btnPI.Text = "PI";
            this.toolTip1.SetToolTip(this.btnPI, "圆周率");
            this.btnPI.Click += new System.EventHandler(this.btnPI_Click);
            // 
            // btnANS
            // 
            this.btnANS.Location = new System.Drawing.Point(8, 13);
            this.btnANS.Name = "btnANS";
            this.btnANS.Size = new System.Drawing.Size(32, 20);
            this.btnANS.TabIndex = 27;
            this.btnANS.Text = "ANS";
            this.toolTip1.SetToolTip(this.btnANS, "上一次计算的结果");
            this.btnANS.Click += new System.EventHandler(this.btnANS_Click);
            // 
            // btnExp
            // 
            this.btnExp.Location = new System.Drawing.Point(88, 13);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(32, 20);
            this.btnExp.TabIndex = 29;
            this.btnExp.Text = "EXP";
            this.toolTip1.SetToolTip(this.btnExp, "也就是e");
            this.btnExp.Click += new System.EventHandler(this.btnExp_Click);
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(242, 144);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(38, 20);
            this.btnLog.TabIndex = 30;
            this.btnLog.Text = "Log";
            this.toolTip1.SetToolTip(this.btnLog, "例子： 10 log 100 =  2，以10为底100的对数等于2");
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnLn
            // 
            this.btnLn.Location = new System.Drawing.Point(242, 168);
            this.btnLn.Name = "btnLn";
            this.btnLn.Size = new System.Drawing.Size(38, 20);
            this.btnLn.TabIndex = 31;
            this.btnLn.Text = "Ln";
            this.toolTip1.SetToolTip(this.btnLn, "以e为底的对数");
            this.btnLn.Click += new System.EventHandler(this.btnLn_Click);
            // 
            // btnLg
            // 
            this.btnLg.Location = new System.Drawing.Point(242, 120);
            this.btnLg.Name = "btnLg";
            this.btnLg.Size = new System.Drawing.Size(38, 20);
            this.btnLg.TabIndex = 32;
            this.btnLg.Text = "Lg";
            this.toolTip1.SetToolTip(this.btnLg, "以10为底的对数 lg 100=2");
            this.btnLg.Click += new System.EventHandler(this.btnLg_Click);
            // 
            // btnLeftBracket
            // 
            this.btnLeftBracket.Location = new System.Drawing.Point(16, 88);
            this.btnLeftBracket.Name = "btnLeftBracket";
            this.btnLeftBracket.Size = new System.Drawing.Size(30, 20);
            this.btnLeftBracket.TabIndex = 33;
            this.btnLeftBracket.Text = "(";
            this.btnLeftBracket.Click += new System.EventHandler(this.btnLeftBracket_Click);
            // 
            // btnRightBracket
            // 
            this.btnRightBracket.Location = new System.Drawing.Point(56, 88);
            this.btnRightBracket.Name = "btnRightBracket";
            this.btnRightBracket.Size = new System.Drawing.Size(30, 20);
            this.btnRightBracket.TabIndex = 34;
            this.btnRightBracket.Text = ")";
            this.btnRightBracket.Click += new System.EventHandler(this.btnRightBracket_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.Location = new System.Drawing.Point(192, 144);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(40, 20);
            this.btnSqrt.TabIndex = 43;
            this.btnSqrt.Text = "sqrt";
            this.toolTip1.SetToolTip(this.btnSqrt, "开平方");
            this.btnSqrt.Click += new System.EventHandler(this.btnsqrt_Click);
            // 
            // btnCbrt
            // 
            this.btnCbrt.Location = new System.Drawing.Point(192, 168);
            this.btnCbrt.Name = "btnCbrt";
            this.btnCbrt.Size = new System.Drawing.Size(40, 20);
            this.btnCbrt.TabIndex = 44;
            this.btnCbrt.Text = "cbrt";
            this.toolTip1.SetToolTip(this.btnCbrt, "开立方");
            this.btnCbrt.Click += new System.EventHandler(this.btnCbrt_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(144, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 45;
            this.label1.Text = "ANS";
            // 
            // btnPower
            // 
            this.btnPower.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPower.Location = new System.Drawing.Point(144, 240);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(30, 20);
            this.btnPower.TabIndex = 46;
            this.btnPower.Text = "^";
            this.toolTip1.SetToolTip(this.btnPower, "例子：平方3^2=9 ，开平方 9^(1/2)=3，这个可以任何方或者任何开方");
            this.btnPower.Click += new System.EventHandler(this.btnPower_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnFact);
            this.groupBox3.Controls.Add(this.btnX_3);
            this.groupBox3.Controls.Add(this.btnX_2);
            this.groupBox3.Controls.Add(this.btnX_1);
            this.groupBox3.Location = new System.Drawing.Point(12, 277);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(168, 36);
            this.groupBox3.TabIndex = 51;
            this.groupBox3.TabStop = false;
            // 
            // btnFact
            // 
            this.btnFact.Location = new System.Drawing.Point(8, 10);
            this.btnFact.Name = "btnFact";
            this.btnFact.Size = new System.Drawing.Size(30, 20);
            this.btnFact.TabIndex = 54;
            this.btnFact.Text = "x!";
            this.toolTip1.SetToolTip(this.btnFact, "阶乘，仅整数,其他请用伽玛函数");
            this.btnFact.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnX_3
            // 
            this.btnX_3.Location = new System.Drawing.Point(128, 10);
            this.btnX_3.Name = "btnX_3";
            this.btnX_3.Size = new System.Drawing.Size(32, 20);
            this.btnX_3.TabIndex = 53;
            this.btnX_3.Text = "x^3";
            this.toolTip1.SetToolTip(this.btnX_3, "立方");
            this.btnX_3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnX_2
            // 
            this.btnX_2.Location = new System.Drawing.Point(88, 10);
            this.btnX_2.Name = "btnX_2";
            this.btnX_2.Size = new System.Drawing.Size(32, 20);
            this.btnX_2.TabIndex = 52;
            this.btnX_2.Text = "x^2";
            this.toolTip1.SetToolTip(this.btnX_2, "平方");
            this.btnX_2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnX_1
            // 
            this.btnX_1.Location = new System.Drawing.Point(48, 10);
            this.btnX_1.Name = "btnX_1";
            this.btnX_1.Size = new System.Drawing.Size(32, 20);
            this.btnX_1.TabIndex = 51;
            this.btnX_1.Text = "1/x";
            this.btnX_1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSto
            // 
            this.btnSto.Location = new System.Drawing.Point(298, 120);
            this.btnSto.Name = "btnSto";
            this.btnSto.Size = new System.Drawing.Size(40, 18);
            this.btnSto.TabIndex = 51;
            this.btnSto.Text = "STO";
            this.toolTip1.SetToolTip(this.btnSto, "赋值给变量，如AX,BX");
            this.btnSto.Click += new System.EventHandler(this.btnSto_Click);
            // 
            // btnAC
            // 
            this.btnAC.Location = new System.Drawing.Point(96, 88);
            this.btnAC.Name = "btnAC";
            this.btnAC.Size = new System.Drawing.Size(38, 20);
            this.btnAC.TabIndex = 54;
            this.btnAC.Text = "AC";
            this.toolTip1.SetToolTip(this.btnAC, "清空");
            this.btnAC.Click += new System.EventHandler(this.btnAC_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.btnFx);
            this.groupBox5.Controls.Add(this.btnEx);
            this.groupBox5.Controls.Add(this.btnDx);
            this.groupBox5.Controls.Add(this.btnCx);
            this.groupBox5.Controls.Add(this.btnBx);
            this.groupBox5.Controls.Add(this.btnAx);
            this.groupBox5.Location = new System.Drawing.Point(296, 156);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(48, 186);
            this.groupBox5.TabIndex = 55;
            this.groupBox5.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(5, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 20);
            this.button2.TabIndex = 27;
            this.button2.Text = "变量";
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // btnFx
            // 
            this.btnFx.Location = new System.Drawing.Point(8, 136);
            this.btnFx.Name = "btnFx";
            this.btnFx.Size = new System.Drawing.Size(32, 18);
            this.btnFx.TabIndex = 26;
            this.btnFx.Text = "FX";
            // 
            // btnEx
            // 
            this.btnEx.Location = new System.Drawing.Point(8, 112);
            this.btnEx.Name = "btnEx";
            this.btnEx.Size = new System.Drawing.Size(32, 18);
            this.btnEx.TabIndex = 25;
            this.btnEx.Text = "EX";
            this.btnEx.Click += new System.EventHandler(this.btnEx_Click);
            // 
            // btnDx
            // 
            this.btnDx.Location = new System.Drawing.Point(8, 88);
            this.btnDx.Name = "btnDx";
            this.btnDx.Size = new System.Drawing.Size(32, 18);
            this.btnDx.TabIndex = 24;
            this.btnDx.Text = "DX";
            this.btnDx.Click += new System.EventHandler(this.btnDx_Click);
            // 
            // btnCx
            // 
            this.btnCx.Location = new System.Drawing.Point(8, 64);
            this.btnCx.Name = "btnCx";
            this.btnCx.Size = new System.Drawing.Size(32, 18);
            this.btnCx.TabIndex = 23;
            this.btnCx.Text = "CX";
            this.btnCx.Click += new System.EventHandler(this.btnCx_Click);
            // 
            // btnBx
            // 
            this.btnBx.Location = new System.Drawing.Point(8, 40);
            this.btnBx.Name = "btnBx";
            this.btnBx.Size = new System.Drawing.Size(32, 18);
            this.btnBx.TabIndex = 22;
            this.btnBx.Text = "BX";
            this.btnBx.Click += new System.EventHandler(this.btnBx_Click);
            // 
            // btnAx
            // 
            this.btnAx.Location = new System.Drawing.Point(8, 16);
            this.btnAx.Name = "btnAx";
            this.btnAx.Size = new System.Drawing.Size(32, 18);
            this.btnAx.TabIndex = 21;
            this.btnAx.Text = "AX";
            this.btnAx.Click += new System.EventHandler(this.btnAx_Click);
            // 
            // btnClr
            // 
            this.btnClr.Location = new System.Drawing.Point(298, 144);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(40, 18);
            this.btnClr.TabIndex = 56;
            this.btnClr.Text = "CLR";
            this.toolTip1.SetToolTip(this.btnClr, "清除变量");
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // tbTip
            // 
            this.tbTip.BackColor = System.Drawing.SystemColors.Info;
            this.tbTip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTip.Location = new System.Drawing.Point(96, 56);
            this.tbTip.Name = "tbTip";
            this.tbTip.Size = new System.Drawing.Size(248, 23);
            this.tbTip.TabIndex = 57;
            // 
            // txt_Expression
            // 
            this.txt_Expression.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Expression.Location = new System.Drawing.Point(8, 8);
            this.txt_Expression.Multiline = true;
            this.txt_Expression.Name = "txt_Expression";
            this.txt_Expression.Size = new System.Drawing.Size(336, 40);
            this.txt_Expression.TabIndex = 0;
            this.txt_Expression.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbExpression_KeyPress);
            // 
            // btnEqual
            // 
            this.btnEqual.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEqual.Location = new System.Drawing.Point(172, 88);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(30, 20);
            this.btnEqual.TabIndex = 59;
            this.btnEqual.Text = "=";
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 23);
            this.button1.TabIndex = 62;
            this.button1.Text = "关于";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnAbs
            // 
            this.btnAbs.Location = new System.Drawing.Point(192, 120);
            this.btnAbs.Name = "btnAbs";
            this.btnAbs.Size = new System.Drawing.Size(40, 20);
            this.btnAbs.TabIndex = 76;
            this.btnAbs.Text = "abs";
            this.toolTip1.SetToolTip(this.btnAbs, "绝对值");
            this.btnAbs.Click += new System.EventHandler(this.btnAbs_Click);
            // 
            // btnCos
            // 
            this.btnCos.Location = new System.Drawing.Point(56, 16);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(38, 20);
            this.btnCos.TabIndex = 43;
            this.btnCos.Text = "cos";
            this.toolTip1.SetToolTip(this.btnCos, "余弦");
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // btnTg
            // 
            this.btnTg.Location = new System.Drawing.Point(8, 40);
            this.btnTg.Name = "btnTg";
            this.btnTg.Size = new System.Drawing.Size(38, 20);
            this.btnTg.TabIndex = 44;
            this.btnTg.Text = "tg";
            this.toolTip1.SetToolTip(this.btnTg, "正切");
            this.btnTg.Click += new System.EventHandler(this.btnTg_Click);
            // 
            // btnSin
            // 
            this.btnSin.Location = new System.Drawing.Point(8, 16);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(38, 20);
            this.btnSin.TabIndex = 45;
            this.btnSin.Text = "sin";
            this.toolTip1.SetToolTip(this.btnSin, "正弦");
            this.btnSin.Click += new System.EventHandler(this.btnSin_Click);
            // 
            // btnCtg
            // 
            this.btnCtg.Location = new System.Drawing.Point(56, 40);
            this.btnCtg.Name = "btnCtg";
            this.btnCtg.Size = new System.Drawing.Size(38, 20);
            this.btnCtg.TabIndex = 46;
            this.btnCtg.Text = "ctg";
            this.toolTip1.SetToolTip(this.btnCtg, "余切");
            this.btnCtg.Click += new System.EventHandler(this.btnCtg_Click);
            // 
            // btnAtg
            // 
            this.btnAtg.Location = new System.Drawing.Point(8, 88);
            this.btnAtg.Name = "btnAtg";
            this.btnAtg.Size = new System.Drawing.Size(38, 20);
            this.btnAtg.TabIndex = 47;
            this.btnAtg.Text = "atg";
            this.toolTip1.SetToolTip(this.btnAtg, "反正切");
            this.btnAtg.Click += new System.EventHandler(this.btnAtg_Click);
            // 
            // btnAsin
            // 
            this.btnAsin.Location = new System.Drawing.Point(8, 64);
            this.btnAsin.Name = "btnAsin";
            this.btnAsin.Size = new System.Drawing.Size(38, 20);
            this.btnAsin.TabIndex = 48;
            this.btnAsin.Text = "asin";
            this.toolTip1.SetToolTip(this.btnAsin, "反正弦");
            this.btnAsin.Click += new System.EventHandler(this.btnAsin_Click);
            // 
            // btnAcos
            // 
            this.btnAcos.Location = new System.Drawing.Point(56, 64);
            this.btnAcos.Name = "btnAcos";
            this.btnAcos.Size = new System.Drawing.Size(38, 20);
            this.btnAcos.TabIndex = 49;
            this.btnAcos.Text = "acos";
            this.toolTip1.SetToolTip(this.btnAcos, "反余弦");
            this.btnAcos.Click += new System.EventHandler(this.btnAcos_Click);
            // 
            // btnActg
            // 
            this.btnActg.Location = new System.Drawing.Point(56, 88);
            this.btnActg.Name = "btnActg";
            this.btnActg.Size = new System.Drawing.Size(38, 20);
            this.btnActg.TabIndex = 50;
            this.btnActg.Text = "actg";
            this.toolTip1.SetToolTip(this.btnActg, "反余切");
            this.btnActg.Click += new System.EventHandler(this.btnActg_Click);
            // 
            // btnarcsh
            // 
            this.btnarcsh.Location = new System.Drawing.Point(48, 112);
            this.btnarcsh.Name = "btnarcsh";
            this.btnarcsh.Size = new System.Drawing.Size(47, 20);
            this.btnarcsh.TabIndex = 51;
            this.btnarcsh.Text = "arcsh";
            this.toolTip1.SetToolTip(this.btnarcsh, "反双曲正弦");
            this.btnarcsh.Click += new System.EventHandler(this.button8_Click);
            // 
            // btncosh
            // 
            this.btncosh.Location = new System.Drawing.Point(9, 136);
            this.btncosh.Name = "btncosh";
            this.btncosh.Size = new System.Drawing.Size(38, 20);
            this.btncosh.TabIndex = 52;
            this.btncosh.Text = "cosh";
            this.toolTip1.SetToolTip(this.btncosh, "双曲余弦");
            this.btncosh.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnSinh
            // 
            this.btnSinh.Location = new System.Drawing.Point(9, 112);
            this.btnSinh.Name = "btnSinh";
            this.btnSinh.Size = new System.Drawing.Size(38, 20);
            this.btnSinh.TabIndex = 53;
            this.btnSinh.Text = "sinh";
            this.toolTip1.SetToolTip(this.btnSinh, "双曲正弦");
            this.btnSinh.Click += new System.EventHandler(this.btnSinh_Click);
            // 
            // btnarcch
            // 
            this.btnarcch.Location = new System.Drawing.Point(48, 136);
            this.btnarcch.Name = "btnarcch";
            this.btnarcch.Size = new System.Drawing.Size(47, 20);
            this.btnarcch.TabIndex = 54;
            this.btnarcch.Text = "arcch";
            this.toolTip1.SetToolTip(this.btnarcch, "反双曲余弦");
            this.btnarcch.Click += new System.EventHandler(this.button5_Click);
            // 
            // btntanh
            // 
            this.btntanh.Location = new System.Drawing.Point(9, 160);
            this.btntanh.Name = "btntanh";
            this.btntanh.Size = new System.Drawing.Size(38, 20);
            this.btntanh.TabIndex = 55;
            this.btntanh.Text = "tanh";
            this.toolTip1.SetToolTip(this.btntanh, "双曲正切");
            this.btntanh.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // btnarcth
            // 
            this.btnarcth.Location = new System.Drawing.Point(48, 160);
            this.btnarcth.Name = "btnarcth";
            this.btnarcth.Size = new System.Drawing.Size(47, 20);
            this.btnarcth.TabIndex = 56;
            this.btnarcth.Text = "arcth";
            this.toolTip1.SetToolTip(this.btnarcth, "反双曲正切");
            this.btnarcth.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(103, 380);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(53, 20);
            this.button6.TabIndex = 57;
            this.button6.Text = "Gamma";
            this.toolTip1.SetToolTip(this.button6, "伽玛函数");
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnBackspace
            // 
            this.btnBackspace.Location = new System.Drawing.Point(8, 56);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(75, 23);
            this.btnBackspace.TabIndex = 63;
            this.btnBackspace.Text = "Backspace";
            this.btnBackspace.UseVisualStyleBackColor = true;
            this.btnBackspace.Click += new System.EventHandler(this.btnBackspace_Click);
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(16, 319);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(63, 23);
            this.btnConverter.TabIndex = 64;
            this.btnConverter.Text = "单位换算";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // btnDateCalculate
            // 
            this.btnDateCalculate.Location = new System.Drawing.Point(16, 348);
            this.btnDateCalculate.Name = "btnDateCalculate";
            this.btnDateCalculate.Size = new System.Drawing.Size(63, 23);
            this.btnDateCalculate.TabIndex = 65;
            this.btnDateCalculate.Text = "日期计算";
            this.btnDateCalculate.UseVisualStyleBackColor = true;
            this.btnDateCalculate.Click += new System.EventHandler(this.btnDateCalculate_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.radioButtonHuDu);
            this.groupBox6.Controls.Add(this.radioButtonJiaoDu);
            this.groupBox6.Location = new System.Drawing.Point(103, 315);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(77, 58);
            this.groupBox6.TabIndex = 66;
            this.groupBox6.TabStop = false;
            // 
            // radioButtonHuDu
            // 
            this.radioButtonHuDu.AutoSize = true;
            this.radioButtonHuDu.Checked = true;
            this.radioButtonHuDu.Location = new System.Drawing.Point(6, 33);
            this.radioButtonHuDu.Name = "radioButtonHuDu";
            this.radioButtonHuDu.Size = new System.Drawing.Size(47, 16);
            this.radioButtonHuDu.TabIndex = 1;
            this.radioButtonHuDu.TabStop = true;
            this.radioButtonHuDu.Text = "弧度";
            this.radioButtonHuDu.UseVisualStyleBackColor = true;
            // 
            // radioButtonJiaoDu
            // 
            this.radioButtonJiaoDu.AutoSize = true;
            this.radioButtonJiaoDu.Location = new System.Drawing.Point(6, 12);
            this.radioButtonJiaoDu.Name = "radioButtonJiaoDu";
            this.radioButtonJiaoDu.Size = new System.Drawing.Size(47, 16);
            this.radioButtonJiaoDu.TabIndex = 0;
            this.radioButtonJiaoDu.Text = "角度";
            this.radioButtonJiaoDu.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.ForeColor = System.Drawing.Color.PeachPuff;
            this.textBox1.Location = new System.Drawing.Point(350, -2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(40, 446);
            this.textBox1.TabIndex = 71;
            this.textBox1.Text = "如有企业需要开发软件，请联系我。\r\n";
            // 
            // txtExpression2
            // 
            this.txtExpression2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtExpression2.Location = new System.Drawing.Point(408, 8);
            this.txtExpression2.Multiline = true;
            this.txtExpression2.Name = "txtExpression2";
            this.txtExpression2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtExpression2.Size = new System.Drawing.Size(404, 327);
            this.txtExpression2.TabIndex = 73;
            this.txtExpression2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExpression2_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(353, 12);
            this.label2.TabIndex = 74;
            this.label2.Text = "上边的文本框可以手动输入算数表达式，按回车就计算最后一行。";
            // 
            // chkFront
            // 
            this.chkFront.AutoSize = true;
            this.chkFront.Location = new System.Drawing.Point(18, 380);
            this.chkFront.Name = "chkFront";
            this.chkFront.Size = new System.Drawing.Size(72, 16);
            this.chkFront.TabIndex = 75;
            this.chkFront.Text = "永远最前";
            this.chkFront.UseVisualStyleBackColor = true;
            this.chkFront.CheckedChanged += new System.EventHandler(this.chkFront_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 12);
            this.label3.TabIndex = 77;
            this.label3.Text = "这个会保存最后100行记录";
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button4.Location = new System.Drawing.Point(648, 353);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(164, 23);
            this.button4.TabIndex = 81;
            this.button4.Text = "kerwin.cn@gmail.com";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_2);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnarcth);
            this.groupBox4.Controls.Add(this.btntanh);
            this.groupBox4.Controls.Add(this.btnarcch);
            this.groupBox4.Controls.Add(this.btnSinh);
            this.groupBox4.Controls.Add(this.btncosh);
            this.groupBox4.Controls.Add(this.btnarcsh);
            this.groupBox4.Controls.Add(this.btnActg);
            this.groupBox4.Controls.Add(this.btnAcos);
            this.groupBox4.Controls.Add(this.btnAsin);
            this.groupBox4.Controls.Add(this.btnAtg);
            this.groupBox4.Controls.Add(this.btnCtg);
            this.groupBox4.Controls.Add(this.btnSin);
            this.groupBox4.Controls.Add(this.btnTg);
            this.groupBox4.Controls.Add(this.btnCos);
            this.groupBox4.Location = new System.Drawing.Point(186, 194);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(104, 189);
            this.groupBox4.TabIndex = 53;
            this.groupBox4.TabStop = false;
            // 
            // MyCal
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(824, 433);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAbs);
            this.Controls.Add(this.chkFront);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtExpression2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.btnDateCalculate);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.btnBackspace);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.txt_Expression);
            this.Controls.Add(this.tbTip);
            this.Controls.Add(this.btnClr);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnAC);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnPower);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCbrt);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnRightBracket);
            this.Controls.Add(this.btnLeftBracket);
            this.Controls.Add(this.btnLg);
            this.Controls.Add(this.btnLn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnTimes);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnSto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MyCal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "科学计算器  支持复数运算  作者 ： 徐恒晓";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MyCal_FormClosed);
            this.Load += new System.EventHandler(this.MyCal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
        /// 
        /**
		[STAThread]
		static void Main() 
		{
			Application.Run(new MyCal());
		}
         * */

		private void btnEqual_Click(object sender, System.EventArgs e)
		{
			tbTip.Text=String.Empty;
			//输入为空
			if(txt_Expression.Text==String.Empty)
				return;
            ArithmeticExpression a = new ArithmeticExpression();

            //显示结果

            if (radioButtonJiaoDu.Checked)
            {
                a.JiaoDuDanWei = enumJiaoDuDanWei.JiaoDu;
            }
            else if (radioButtonHuDu.Checked)
            {
                a.JiaoDuDanWei = enumJiaoDuDanWei.HuDu;
            }

			//显示结果
            try
            {
                tbResult.Text = a.Eval(txt_Expression.Text);
                txtExpression2.AppendText(txt_Expression.Text+"="+tbResult.Text+Environment.NewLine);
            }
            catch (System.Exception ex)
            {
                tbTip.Text = ex.Message;
            }
            
		}

		private void MyCal_Load(object sender, System.EventArgs e)
		{
		
		}

		private void btnPI_Click(object sender, System.EventArgs e)
		{
			txt_Expression.Text+="PI";
		}

		private void btnLeftBracket_Click(object sender, System.EventArgs e)
		{
			txt_Expression.Text+="(";
		}

		private void btnRightBracket_Click(object sender, System.EventArgs e)
		{
			txt_Expression.Text+=")";
		}

		private void btnPlus_Click(object sender, System.EventArgs e)
		{
			txt_Expression.Text+="+";
		}

		private void btnMinus_Click(object sender, System.EventArgs e)
		{
			txt_Expression.Text+="-";
		}

		private void btnTimes_Click(object sender, System.EventArgs e)
		{
			txt_Expression.Text+="*";
		}

		private void btnDivide_Click(object sender, System.EventArgs e)
		{
			txt_Expression.Text+="/";
		}

		private void btnMod_Click(object sender, System.EventArgs e)
		{
			txt_Expression.Text+="%";
		}

		private void btnPower_Click(object sender, System.EventArgs e)
		{
			txt_Expression.Text+="^";
		}

		private void btnNum1_Click(object sender, System.EventArgs e)
		{
			txt_Expression.Text+="1";
		}

		private void btnNum2_Click(object sender, System.EventArgs e)
		{
			txt_Expression.Text+="2";
		}

		private void btnNum3_Click(object sender, System.EventArgs e)
		{
			txt_Expression.Text+="3";
		}

		private void btnNum4_Click(object sender, System.EventArgs e)
		{
			txt_Expression.Text+="4";
		}

		private void btnNum5_Click(object sender, System.EventArgs e)
		{
			txt_Expression.Text+="5";
		}

		private void btnNum6_Click(object sender, System.EventArgs e)
		{
			txt_Expression.Text+="6";
		}

		private void btnNum7_Click(object sender, System.EventArgs e)
		{
			txt_Expression.Text+="7";
		}

		private void btnNum8_Click(object sender, System.EventArgs e)
		{
			txt_Expression.Text+="8";
		}

		private void btnNum9_Click(object sender, System.EventArgs e)
		{
			txt_Expression.Text+="9";
		}

		private void btnNum0_Click(object sender, System.EventArgs e)
		{
			txt_Expression.Text+="0";
		}

		private void btnDot_Click(object sender, System.EventArgs e)
		{
			txt_Expression.Text+=".";
		}

		private void btnExp_Click(object sender, System.EventArgs e)
		{
			txt_Expression.Text+="e^";
		}

		private void btnSin_Click(object sender, System.EventArgs e)
		{
			txt_Expression.Text+="sin";
		}

		private void btnCos_Click(object sender, System.EventArgs e)
		{
			txt_Expression.Text+="cos";
		}

		private void btnTg_Click(object sender, System.EventArgs e)
		{
			txt_Expression.Text+="tg";
		}

		private void btnCtg_Click(object sender, System.EventArgs e)
		{
			txt_Expression.Text+="ctg";
		}

		private void btnAsin_Click(object sender, System.EventArgs e)
		{
			txt_Expression.Text+="asin";
		}

		private void btnAcos_Click(object sender, System.EventArgs e)
		{
			txt_Expression.Text+="acos";
		}

		private void btnAtg_Click(object sender, System.EventArgs e)
		{
			txt_Expression.Text+="atg";
		}

		private void btnActg_Click(object sender, System.EventArgs e)
		{
			txt_Expression.Text+="actg";
		}

		private void btnsqrt_Click(object sender, System.EventArgs e)
		{
			txt_Expression.Text+="sqrt ( )";
		}

		private void btnCbrt_Click(object sender, System.EventArgs e)
		{
			txt_Expression.Text+="cbrt ( )";
		}

		private void btnLn_Click(object sender, System.EventArgs e)
		{
			txt_Expression.Text+="ln";
		}

		private void btnLog_Click(object sender, System.EventArgs e)
		{
			txt_Expression.Text+="log";
		}

		private void btnLg_Click(object sender, System.EventArgs e)
		{
			txt_Expression.Text+="lg";
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			txt_Expression.Text+="1/";
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			txt_Expression.Text+="^2";
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			txt_Expression.Text+="^3";
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			txt_Expression.Text+="!";
		}

		/// <summary>
		/// 设置控件是否被允许
		/// </summary>
		/// <param name="enable">允许或不允许</param>
		private void SetEnable(bool enable)
		{
			btnLeftBracket.Enabled=enable;
			btnRightBracket.Enabled=enable;
			btnNum1.Enabled=enable;
			btnNum2.Enabled=enable;
			btnNum3.Enabled=enable;
			btnNum4.Enabled=enable;
			btnNum5.Enabled=enable;
			btnNum6.Enabled=enable;
			btnNum7.Enabled=enable;
			btnNum8.Enabled=enable;
			btnNum9.Enabled=enable;
			btnNum0.Enabled=enable;
			btnDot.Enabled=enable;
			btnLn.Enabled=enable;
			btnLog.Enabled=enable;
			btnLg.Enabled=enable;
			btnX_1.Enabled=enable;
			btnX_2.Enabled=enable;
			btnX_3.Enabled=enable;
			btnFact.Enabled=enable;
			btnSqrt.Enabled=enable;
			btnCbrt.Enabled=enable;
			btnSin.Enabled=enable;
			btnCos.Enabled=enable;
			btnTg.Enabled=enable;
			btnCtg.Enabled=enable;
			btnAsin.Enabled=enable;
			btnAcos.Enabled=enable;
			btnAtg.Enabled=enable;
			btnActg.Enabled=enable;
			btnANS.Enabled=enable;
			btnPI.Enabled=enable;
			btnExp.Enabled=enable;
			btnPlus.Enabled=enable;
			btnMinus.Enabled=enable;
			btnTimes.Enabled=enable;
			btnDivide.Enabled=enable;
			btnMod.Enabled=enable;
			btnPower.Enabled=enable;
			btnEqual.Enabled=enable;
			btnSto.Enabled=enable;
            btnSinh.Enabled = enable;
            btncosh.Enabled = enable;
            btntanh.Enabled = enable;
            btnarcch.Enabled = enable;
            btnarcsh.Enabled = enable;
            btnarcth.Enabled = enable;
            btnNegative.Enabled = enable;
		}


		private bool isStoClicked=false;
		private void btnSto_Click(object sender, System.EventArgs e)
		{
			this.SetEnable(false);
			isStoClicked=true;
			//触发计算事件
			btnEqual_Click(btnEqual,null);	
		}

		private void btnANS_Click(object sender, System.EventArgs e)
		{
			txt_Expression.Text+="ANS";		
		}

		private void btnAx_Click(object sender, System.EventArgs e)
		{
			if(isStoClicked==true){
                
                ArithmeticExpression.SetVar("AX", ArithmeticExpression.getVarAndConst("ANS"));
                tbTip.Text = "AX = " + ArithmeticExpression.getVarAndConst("AX");
				this.SetEnable(true);
				isStoClicked=false;
			}else
				txt_Expression.Text+="AX";
		}

		private void btnBx_Click(object sender, System.EventArgs e)
		{
			if(isStoClicked==true)
			{
                ArithmeticExpression.SetVar("BX", ArithmeticExpression.getVarAndConst("ANS"));
                tbTip.Text = "BX = " + ArithmeticExpression.getVarAndConst("BX");
				this.SetEnable(true);		
				isStoClicked=false;
			}else
				txt_Expression.Text+="BX";
		}

		private void btnCx_Click(object sender, System.EventArgs e)
		{
			if(isStoClicked==true)
			{
                ArithmeticExpression.SetVar("CX", ArithmeticExpression.getVarAndConst("ANS"));
                tbTip.Text = "CX = " + ArithmeticExpression.getVarAndConst("CX");
				this.SetEnable(true);		
				isStoClicked=false;
			}
			else
				txt_Expression.Text+="CX";		
		}

		private void btnDx_Click(object sender, System.EventArgs e)
		{
			if(isStoClicked==true)
			{
                ArithmeticExpression.SetVar("DX", ArithmeticExpression.getVarAndConst("ANS"));
                tbTip.Text = "DX = " + ArithmeticExpression.getVarAndConst("DX");
				this.SetEnable(true);		
				isStoClicked=false;
			}
			else
				txt_Expression.Text+="DX";				
		}

		private void btnEx_Click(object sender, System.EventArgs e)
		{
			if(isStoClicked==true)
			{
                ArithmeticExpression.SetVar("EX", ArithmeticExpression.getVarAndConst("ANS"));
                tbTip.Text = "EX = " + ArithmeticExpression.getVarAndConst("EX");
				this.SetEnable(true);		
				isStoClicked=false;
			}
			else
				txt_Expression.Text+="EX";
		}

		private void btnAC_Click(object sender, System.EventArgs e)
		{
			txt_Expression.Text=String.Empty;
			tbTip.Text=String.Empty;
			tbResult.Text="0.0";
            ArithmeticExpression.SetVar("ANS", Complex.Zero);
		}

		private void btnClr_Click(object sender, System.EventArgs e)
		{
            ArithmeticExpression.SetVar("AX",Complex.Zero);
            ArithmeticExpression.SetVar("BX", Complex.Zero);
            ArithmeticExpression.SetVar("CX", Complex.Zero);
            ArithmeticExpression.SetVar("DX", Complex.Zero);
            ArithmeticExpression.SetVar("EX", Complex.Zero);
            ArithmeticExpression.SetVar("FX", Complex.Zero);
			tbTip.Text="所有变量已清除";
		}

		private void btnNegative_Click(object sender, System.EventArgs e)
		{
			txt_Expression.Text+="i";
		}

		private void tbExpression_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if(e.KeyChar==(char)Keys.Escape)
			{
				txt_Expression.Text="";
				e.Handled=true;
			}
			else if(e.KeyChar==(char)Keys.Enter)
			{
				//如果按下Enter，触发计算事件
				btnEqual_Click(btnEqual,null);			
				e.Handled=true;
			}
		}



        private void button1_Click_1(object sender, EventArgs e)
        {
            AboutForm frm_about = new AboutForm();
            frm_about.ShowDialog(this);
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (txt_Expression.Text.Length>0)//只有长度大于0才调用。
                txt_Expression.Text = txt_Expression.Text.Remove((txt_Expression.Text.Length - 1), 1);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            FrmUnitsConverterCalculator frm = new FrmUnitsConverterCalculator();
            frm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDateCalculate_Click(object sender, EventArgs e)
        {
            FrmDateCalculate frm = new FrmDateCalculate();
            frm.Show();
        }




        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            clsProcess.Start("http://www.xuhengxiao.com/?p=31");
        }







        private void btnSinh_Click(object sender, EventArgs e)
        {
            txt_Expression.Text += "sinh";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txt_Expression.Text += "sinh";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            txt_Expression.Text += "tanh";
        }



        private void button2_Click_2(object sender, EventArgs e)
        {
            frm_show_X myfrm = new frm_show_X();
            myfrm.ShowDialog(this);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txt_Expression.Text += "arcsh";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txt_Expression.Text += "arcch";
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            txt_Expression.Text += "arcth";
        }

        private void txtExpression2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                txt_Expression.Text = "";
                e.Handled = true;
            }
            else if ((e.KeyChar == (char)Keys.Enter))
            {
                tbTip.Text = "";
                //如果按下Enter，触发计算事件
                //获得最后一行的数据,至少是一行吧
                string strExpression = string.Empty;
                try
                {
                    strExpression = txtExpression2.Lines[txtExpression2.Lines.Length - 1];
                }
                catch (System.Exception ex)
                {
                    return;
                }
              
                if (strExpression == String.Empty)
                {
                    
                    return;
                }
                ArithmeticExpression a = new ArithmeticExpression();

                //显示结果

                if (radioButtonJiaoDu.Checked)
                {
                    a.JiaoDuDanWei = enumJiaoDuDanWei.JiaoDu;
                }
                else if (radioButtonHuDu.Checked)
                {
                    a.JiaoDuDanWei = enumJiaoDuDanWei.HuDu;
                }

                //显示结果
                try
                {
                    txtExpression2.AppendText("=" + a.Eval(strExpression) + Environment.NewLine);
                    //txtExpression2.Text += "="+a.Eval(strExpression) + Environment.NewLine;
                }
                catch (System.Exception ex)
                {
                    tbTip.Text = ex.Message;
                }

                e.Handled = true;
            }
        }

        private void chkFront_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = chkFront.Checked;
        }

        private void MyCal_FormClosed(object sender, FormClosedEventArgs e)
        {
            //保存历史记录
            try
            {
                //如果文件不存在就创建
                if (!File.Exists(strPathHostory))
                {
                    File.Create(strPathHostory);
                }
                
                using (System.IO.FileStream fs = File.OpenWrite(strPathHostory))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        int iBaocunJiLuShu = 100;

                        if (txtExpression2.Lines.Length > iBaocunJiLuShu)
                        {
                            for (int i = txtExpression2.Lines.Length - iBaocunJiLuShu-1; i < txtExpression2.Lines.Length; i++)
                            {
                                if (txtExpression2.Lines[i].Length>1)
                                {
                                    sw.WriteLine(txtExpression2.Lines[i]); 
                                }

                            }
                        }
                        else
                        {
                            sw.Write(txtExpression2.Text);
                        }

                    }
                }
            }
            catch (System.Exception ex)
            {

            }
        }

        private void btnAbs_Click(object sender, EventArgs e)
        {
            txt_Expression.Text += "abs";
        }





        private void button3_Click_3(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://xuhengxiao.taobao.com/");

        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            Process.Start("mailto:kerwin.cn@gmail.com");
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Process.Start("http://www.xuhengxiao.com/");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txt_Expression.Text += "gamma";
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Process.Start("http://www.xuhengxiao.com/?p=203");
        }


	}
}
