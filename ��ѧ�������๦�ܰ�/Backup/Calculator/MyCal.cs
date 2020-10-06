#region BluePrint.Calculator, Copyright 2005 BluePrint Work Group, Programmed by Tony Qu
/* ************************************************************
 项目名称：科学计算器
 实现语言：C#
 作者：Tony Qu
 作者博客：http://www.cnblogs.com/tonyqus
 模块名称：文法分析器
 模块命名空间：Calculator
 当前文件信息：Calculator.MyCal，计算器界面类
 目前版本：1.0.2.0
 
 当前文件修订  
	Who			Date			Version			Comment
	Tony Qu		2005.5.8		1.0.0.0			完成基本创建
	Tony Qu		2005.5.23		1.0.2.0			加入变量存储按钮
												修正结果的正无穷大、负无穷大、NaN显示问题
												加入一些按钮的Click事件处理
	Tony Qu		2005.12.26		1.0.3.0			增加TextBoxEx控件，替代原来的tbExpression
												增加ESC快捷键用于清除表达式输入框中的文本
												
*************************************************************/
#endregion

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using PhraseAnalyzer;
using GrammerAnalyzer;

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

		private PhraseAnalyzer.PhraseStorage ps;
		private GrammerAnalyzer.SemanticAnalyzer sa;
		private Calculator.CalUnit cunit;

		private PhraseAnalyzer.PhraseAnalyzer pa;
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
		private System.Windows.Forms.Button btnSbrt;
		private System.Windows.Forms.Button btnCbrt;
		public System.Windows.Forms.Button btnPower;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		public System.Windows.Forms.Button btnActg;
		public System.Windows.Forms.Button btnAcos;
		public System.Windows.Forms.Button btnAsin;
		public System.Windows.Forms.Button btnAtg;
		public System.Windows.Forms.Button btnCtg;
		public System.Windows.Forms.Button btnSin;
		public System.Windows.Forms.Button btnTg;
		public System.Windows.Forms.Button btnCos;
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
		private System.Windows.Forms.TextBox tbExpression;
		private System.Windows.Forms.Button btnEqual;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public MyCal()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
			ps=new PhraseStorage();
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
			this.btnSbrt = new System.Windows.Forms.Button();
			this.btnCbrt = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnPower = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btnFact = new System.Windows.Forms.Button();
			this.btnX_3 = new System.Windows.Forms.Button();
			this.btnX_2 = new System.Windows.Forms.Button();
			this.btnX_1 = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.btnActg = new System.Windows.Forms.Button();
			this.btnAcos = new System.Windows.Forms.Button();
			this.btnAsin = new System.Windows.Forms.Button();
			this.btnAtg = new System.Windows.Forms.Button();
			this.btnCtg = new System.Windows.Forms.Button();
			this.btnSin = new System.Windows.Forms.Button();
			this.btnTg = new System.Windows.Forms.Button();
			this.btnCos = new System.Windows.Forms.Button();
			this.btnSto = new System.Windows.Forms.Button();
			this.btnAC = new System.Windows.Forms.Button();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.btnFx = new System.Windows.Forms.Button();
			this.btnEx = new System.Windows.Forms.Button();
			this.btnDx = new System.Windows.Forms.Button();
			this.btnCx = new System.Windows.Forms.Button();
			this.btnBx = new System.Windows.Forms.Button();
			this.btnAx = new System.Windows.Forms.Button();
			this.btnClr = new System.Windows.Forms.Button();
			this.tbTip = new System.Windows.Forms.Label();
			this.tbExpression = new System.Windows.Forms.TextBox();
			this.btnEqual = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnPlus
			// 
			this.btnPlus.Location = new System.Drawing.Point(144, 120);
			this.btnPlus.Name = "btnPlus";
			this.btnPlus.Size = new System.Drawing.Size(30, 20);
			this.btnPlus.TabIndex = 2;
			this.btnPlus.Text = "+";
			this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
			// 
			// btnDivide
			// 
			this.btnDivide.Location = new System.Drawing.Point(144, 192);
			this.btnDivide.Name = "btnDivide";
			this.btnDivide.Size = new System.Drawing.Size(30, 20);
			this.btnDivide.TabIndex = 3;
			this.btnDivide.Text = "/";
			this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
			// 
			// btnTimes
			// 
			this.btnTimes.Location = new System.Drawing.Point(144, 168);
			this.btnTimes.Name = "btnTimes";
			this.btnTimes.Size = new System.Drawing.Size(30, 20);
			this.btnTimes.TabIndex = 5;
			this.btnTimes.Text = "*";
			this.btnTimes.Click += new System.EventHandler(this.btnTimes_Click);
			// 
			// btnMinus
			// 
			this.btnMinus.Location = new System.Drawing.Point(144, 144);
			this.btnMinus.Name = "btnMinus";
			this.btnMinus.Size = new System.Drawing.Size(30, 20);
			this.btnMinus.TabIndex = 6;
			this.btnMinus.Text = "-";
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
			this.groupBox1.Size = new System.Drawing.Size(128, 115);
			this.groupBox1.TabIndex = 15;
			this.groupBox1.TabStop = false;
			// 
			// btnNegative
			// 
			this.btnNegative.Location = new System.Drawing.Point(88, 88);
			this.btnNegative.Name = "btnNegative";
			this.btnNegative.Size = new System.Drawing.Size(28, 18);
			this.btnNegative.TabIndex = 26;
			this.btnNegative.Text = "@";
			this.btnNegative.Click += new System.EventHandler(this.btnNegative_Click);
			// 
			// btnDot
			// 
			this.btnDot.Location = new System.Drawing.Point(48, 88);
			this.btnDot.Name = "btnDot";
			this.btnDot.Size = new System.Drawing.Size(28, 18);
			this.btnDot.TabIndex = 25;
			this.btnDot.Text = ".";
			this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
			// 
			// btnNum0
			// 
			this.btnNum0.Location = new System.Drawing.Point(8, 88);
			this.btnNum0.Name = "btnNum0";
			this.btnNum0.Size = new System.Drawing.Size(28, 18);
			this.btnNum0.TabIndex = 24;
			this.btnNum0.Text = "0";
			this.btnNum0.Click += new System.EventHandler(this.btnNum0_Click);
			// 
			// btnNum2
			// 
			this.btnNum2.Location = new System.Drawing.Point(48, 16);
			this.btnNum2.Name = "btnNum2";
			this.btnNum2.Size = new System.Drawing.Size(28, 18);
			this.btnNum2.TabIndex = 23;
			this.btnNum2.Text = "2";
			this.btnNum2.Click += new System.EventHandler(this.btnNum2_Click);
			// 
			// btnNum5
			// 
			this.btnNum5.Location = new System.Drawing.Point(48, 40);
			this.btnNum5.Name = "btnNum5";
			this.btnNum5.Size = new System.Drawing.Size(28, 18);
			this.btnNum5.TabIndex = 22;
			this.btnNum5.Text = "5";
			this.btnNum5.Click += new System.EventHandler(this.btnNum5_Click);
			// 
			// btnNum8
			// 
			this.btnNum8.Location = new System.Drawing.Point(48, 64);
			this.btnNum8.Name = "btnNum8";
			this.btnNum8.Size = new System.Drawing.Size(28, 18);
			this.btnNum8.TabIndex = 21;
			this.btnNum8.Text = "8";
			this.btnNum8.Click += new System.EventHandler(this.btnNum8_Click);
			// 
			// btnNum3
			// 
			this.btnNum3.Location = new System.Drawing.Point(88, 16);
			this.btnNum3.Name = "btnNum3";
			this.btnNum3.Size = new System.Drawing.Size(28, 18);
			this.btnNum3.TabIndex = 20;
			this.btnNum3.Text = "3";
			this.btnNum3.Click += new System.EventHandler(this.btnNum3_Click);
			// 
			// btnNum6
			// 
			this.btnNum6.Location = new System.Drawing.Point(88, 40);
			this.btnNum6.Name = "btnNum6";
			this.btnNum6.Size = new System.Drawing.Size(28, 18);
			this.btnNum6.TabIndex = 19;
			this.btnNum6.Text = "6";
			this.btnNum6.Click += new System.EventHandler(this.btnNum6_Click);
			// 
			// btnNum9
			// 
			this.btnNum9.Location = new System.Drawing.Point(88, 64);
			this.btnNum9.Name = "btnNum9";
			this.btnNum9.Size = new System.Drawing.Size(28, 18);
			this.btnNum9.TabIndex = 18;
			this.btnNum9.Text = "9";
			this.btnNum9.Click += new System.EventHandler(this.btnNum9_Click);
			// 
			// btnNum7
			// 
			this.btnNum7.Location = new System.Drawing.Point(8, 64);
			this.btnNum7.Name = "btnNum7";
			this.btnNum7.Size = new System.Drawing.Size(28, 18);
			this.btnNum7.TabIndex = 17;
			this.btnNum7.Text = "7";
			this.btnNum7.Click += new System.EventHandler(this.btnNum7_Click);
			// 
			// btnNum4
			// 
			this.btnNum4.Location = new System.Drawing.Point(8, 40);
			this.btnNum4.Name = "btnNum4";
			this.btnNum4.Size = new System.Drawing.Size(28, 18);
			this.btnNum4.TabIndex = 16;
			this.btnNum4.Text = "4";
			this.btnNum4.Click += new System.EventHandler(this.btnNum4_Click);
			// 
			// btnNum1
			// 
			this.btnNum1.Location = new System.Drawing.Point(8, 16);
			this.btnNum1.Name = "btnNum1";
			this.btnNum1.Size = new System.Drawing.Size(28, 18);
			this.btnNum1.TabIndex = 15;
			this.btnNum1.Text = "1";
			this.btnNum1.Click += new System.EventHandler(this.btnNum1_Click);
			// 
			// tbResult
			// 
			this.tbResult.Location = new System.Drawing.Point(208, 88);
			this.tbResult.Name = "tbResult";
			this.tbResult.Size = new System.Drawing.Size(136, 21);
			this.tbResult.TabIndex = 16;
			this.tbResult.Text = "0.0";
			this.tbResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// btnMod
			// 
			this.btnMod.Location = new System.Drawing.Point(144, 216);
			this.btnMod.Name = "btnMod";
			this.btnMod.Size = new System.Drawing.Size(30, 20);
			this.btnMod.TabIndex = 27;
			this.btnMod.Text = "%";
			this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnPI);
			this.groupBox2.Controls.Add(this.btnANS);
			this.groupBox2.Controls.Add(this.btnExp);
			this.groupBox2.Location = new System.Drawing.Point(8, 224);
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
			this.btnPI.Click += new System.EventHandler(this.btnPI_Click);
			// 
			// btnANS
			// 
			this.btnANS.Location = new System.Drawing.Point(8, 13);
			this.btnANS.Name = "btnANS";
			this.btnANS.Size = new System.Drawing.Size(32, 20);
			this.btnANS.TabIndex = 27;
			this.btnANS.Text = "ANS";
			this.btnANS.Click += new System.EventHandler(this.btnANS_Click);
			// 
			// btnExp
			// 
			this.btnExp.Location = new System.Drawing.Point(88, 13);
			this.btnExp.Name = "btnExp";
			this.btnExp.Size = new System.Drawing.Size(32, 20);
			this.btnExp.TabIndex = 29;
			this.btnExp.Text = "EXP";
			this.btnExp.Click += new System.EventHandler(this.btnExp_Click);
			// 
			// btnLog
			// 
			this.btnLog.Location = new System.Drawing.Point(240, 144);
			this.btnLog.Name = "btnLog";
			this.btnLog.Size = new System.Drawing.Size(32, 20);
			this.btnLog.TabIndex = 30;
			this.btnLog.Text = "Log";
			this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
			// 
			// btnLn
			// 
			this.btnLn.Location = new System.Drawing.Point(240, 168);
			this.btnLn.Name = "btnLn";
			this.btnLn.Size = new System.Drawing.Size(32, 20);
			this.btnLn.TabIndex = 31;
			this.btnLn.Text = "Ln";
			this.btnLn.Click += new System.EventHandler(this.btnLn_Click);
			// 
			// btnLg
			// 
			this.btnLg.Location = new System.Drawing.Point(240, 120);
			this.btnLg.Name = "btnLg";
			this.btnLg.Size = new System.Drawing.Size(32, 20);
			this.btnLg.TabIndex = 32;
			this.btnLg.Text = "Lg";
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
			// btnSbrt
			// 
			this.btnSbrt.Location = new System.Drawing.Point(192, 144);
			this.btnSbrt.Name = "btnSbrt";
			this.btnSbrt.Size = new System.Drawing.Size(40, 20);
			this.btnSbrt.TabIndex = 43;
			this.btnSbrt.Text = "sbrt";
			this.btnSbrt.Click += new System.EventHandler(this.btnSbrt_Click);
			// 
			// btnCbrt
			// 
			this.btnCbrt.Location = new System.Drawing.Point(192, 168);
			this.btnCbrt.Name = "btnCbrt";
			this.btnCbrt.Size = new System.Drawing.Size(40, 20);
			this.btnCbrt.TabIndex = 44;
			this.btnCbrt.Text = "cbrt";
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
			this.btnPower.Location = new System.Drawing.Point(144, 240);
			this.btnPower.Name = "btnPower";
			this.btnPower.Size = new System.Drawing.Size(30, 20);
			this.btnPower.TabIndex = 46;
			this.btnPower.Text = "^";
			this.btnPower.Click += new System.EventHandler(this.btnPower_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btnFact);
			this.groupBox3.Controls.Add(this.btnX_3);
			this.groupBox3.Controls.Add(this.btnX_2);
			this.groupBox3.Controls.Add(this.btnX_1);
			this.groupBox3.Location = new System.Drawing.Point(8, 272);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(168, 36);
			this.groupBox3.TabIndex = 51;
			this.groupBox3.TabStop = false;
			// 
			// btnFact
			// 
			this.btnFact.Location = new System.Drawing.Point(129, 10);
			this.btnFact.Name = "btnFact";
			this.btnFact.Size = new System.Drawing.Size(30, 20);
			this.btnFact.TabIndex = 54;
			this.btnFact.Text = "x!";
			this.btnFact.Click += new System.EventHandler(this.button4_Click);
			// 
			// btnX_3
			// 
			this.btnX_3.Location = new System.Drawing.Point(89, 10);
			this.btnX_3.Name = "btnX_3";
			this.btnX_3.Size = new System.Drawing.Size(32, 20);
			this.btnX_3.TabIndex = 53;
			this.btnX_3.Text = "x^3";
			this.btnX_3.Click += new System.EventHandler(this.button3_Click);
			// 
			// btnX_2
			// 
			this.btnX_2.Location = new System.Drawing.Point(49, 10);
			this.btnX_2.Name = "btnX_2";
			this.btnX_2.Size = new System.Drawing.Size(32, 20);
			this.btnX_2.TabIndex = 52;
			this.btnX_2.Text = "x^2";
			this.btnX_2.Click += new System.EventHandler(this.button2_Click);
			// 
			// btnX_1
			// 
			this.btnX_1.Location = new System.Drawing.Point(9, 10);
			this.btnX_1.Name = "btnX_1";
			this.btnX_1.Size = new System.Drawing.Size(32, 20);
			this.btnX_1.TabIndex = 51;
			this.btnX_1.Text = "1/x";
			this.btnX_1.Click += new System.EventHandler(this.button1_Click);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.btnActg);
			this.groupBox4.Controls.Add(this.btnAcos);
			this.groupBox4.Controls.Add(this.btnAsin);
			this.groupBox4.Controls.Add(this.btnAtg);
			this.groupBox4.Controls.Add(this.btnCtg);
			this.groupBox4.Controls.Add(this.btnSin);
			this.groupBox4.Controls.Add(this.btnTg);
			this.groupBox4.Controls.Add(this.btnCos);
			this.groupBox4.Location = new System.Drawing.Point(184, 192);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(104, 120);
			this.groupBox4.TabIndex = 53;
			this.groupBox4.TabStop = false;
			// 
			// btnActg
			// 
			this.btnActg.Location = new System.Drawing.Point(56, 88);
			this.btnActg.Name = "btnActg";
			this.btnActg.Size = new System.Drawing.Size(38, 20);
			this.btnActg.TabIndex = 50;
			this.btnActg.Text = "actg";
			this.btnActg.Click += new System.EventHandler(this.btnActg_Click);
			// 
			// btnAcos
			// 
			this.btnAcos.Location = new System.Drawing.Point(56, 64);
			this.btnAcos.Name = "btnAcos";
			this.btnAcos.Size = new System.Drawing.Size(38, 20);
			this.btnAcos.TabIndex = 49;
			this.btnAcos.Text = "acos";
			this.btnAcos.Click += new System.EventHandler(this.btnAsin_Click);
			// 
			// btnAsin
			// 
			this.btnAsin.Location = new System.Drawing.Point(8, 64);
			this.btnAsin.Name = "btnAsin";
			this.btnAsin.Size = new System.Drawing.Size(38, 20);
			this.btnAsin.TabIndex = 48;
			this.btnAsin.Text = "asin";
			this.btnAsin.Click += new System.EventHandler(this.btnAsin_Click);
			// 
			// btnAtg
			// 
			this.btnAtg.Location = new System.Drawing.Point(8, 88);
			this.btnAtg.Name = "btnAtg";
			this.btnAtg.Size = new System.Drawing.Size(38, 20);
			this.btnAtg.TabIndex = 47;
			this.btnAtg.Text = "atg";
			this.btnAtg.Click += new System.EventHandler(this.btnAtg_Click);
			// 
			// btnCtg
			// 
			this.btnCtg.Location = new System.Drawing.Point(56, 40);
			this.btnCtg.Name = "btnCtg";
			this.btnCtg.Size = new System.Drawing.Size(38, 20);
			this.btnCtg.TabIndex = 46;
			this.btnCtg.Text = "ctg";
			this.btnCtg.Click += new System.EventHandler(this.btnCtg_Click);
			// 
			// btnSin
			// 
			this.btnSin.Location = new System.Drawing.Point(8, 16);
			this.btnSin.Name = "btnSin";
			this.btnSin.Size = new System.Drawing.Size(38, 20);
			this.btnSin.TabIndex = 45;
			this.btnSin.Text = "sin";
			this.btnSin.Click += new System.EventHandler(this.btnSin_Click);
			// 
			// btnTg
			// 
			this.btnTg.Location = new System.Drawing.Point(8, 40);
			this.btnTg.Name = "btnTg";
			this.btnTg.Size = new System.Drawing.Size(38, 20);
			this.btnTg.TabIndex = 44;
			this.btnTg.Text = "tg";
			this.btnTg.Click += new System.EventHandler(this.btnTg_Click);
			// 
			// btnCos
			// 
			this.btnCos.Location = new System.Drawing.Point(56, 16);
			this.btnCos.Name = "btnCos";
			this.btnCos.Size = new System.Drawing.Size(38, 20);
			this.btnCos.TabIndex = 43;
			this.btnCos.Text = "cos";
			this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
			// 
			// btnSto
			// 
			this.btnSto.Location = new System.Drawing.Point(298, 115);
			this.btnSto.Name = "btnSto";
			this.btnSto.Size = new System.Drawing.Size(40, 18);
			this.btnSto.TabIndex = 51;
			this.btnSto.Text = "STO";
			this.btnSto.Click += new System.EventHandler(this.btnSto_Click);
			// 
			// btnAC
			// 
			this.btnAC.Location = new System.Drawing.Point(96, 88);
			this.btnAC.Name = "btnAC";
			this.btnAC.Size = new System.Drawing.Size(38, 20);
			this.btnAC.TabIndex = 54;
			this.btnAC.Text = "AC";
			this.btnAC.Click += new System.EventHandler(this.btnAC_Click);
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.btnFx);
			this.groupBox5.Controls.Add(this.btnEx);
			this.groupBox5.Controls.Add(this.btnDx);
			this.groupBox5.Controls.Add(this.btnCx);
			this.groupBox5.Controls.Add(this.btnBx);
			this.groupBox5.Controls.Add(this.btnAx);
			this.groupBox5.Location = new System.Drawing.Point(296, 156);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(48, 160);
			this.groupBox5.TabIndex = 55;
			this.groupBox5.TabStop = false;
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
			this.btnClr.Location = new System.Drawing.Point(298, 136);
			this.btnClr.Name = "btnClr";
			this.btnClr.Size = new System.Drawing.Size(40, 18);
			this.btnClr.TabIndex = 56;
			this.btnClr.Text = "CLR";
			this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
			// 
			// tbTip
			// 
			this.tbTip.BackColor = System.Drawing.SystemColors.Info;
			this.tbTip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbTip.Location = new System.Drawing.Point(8, 56);
			this.tbTip.Name = "tbTip";
			this.tbTip.Size = new System.Drawing.Size(336, 23);
			this.tbTip.TabIndex = 57;
			// 
			// tbExpression
			// 
			this.tbExpression.Location = new System.Drawing.Point(8, 8);
			this.tbExpression.Multiline = true;
			this.tbExpression.Name = "tbExpression";
			this.tbExpression.Size = new System.Drawing.Size(336, 40);
			this.tbExpression.TabIndex = 58;
			this.tbExpression.Text = "";
			this.tbExpression.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbExpression_KeyPress);
			// 
			// btnEqual
			// 
			this.btnEqual.Location = new System.Drawing.Point(176, 88);
			this.btnEqual.Name = "btnEqual";
			this.btnEqual.Size = new System.Drawing.Size(24, 16);
			this.btnEqual.TabIndex = 59;
			this.btnEqual.Text = "=";
			this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
			// 
			// MyCal
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(352, 318);
			this.Controls.Add(this.btnEqual);
			this.Controls.Add(this.tbExpression);
			this.Controls.Add(this.tbTip);
			this.Controls.Add(this.btnClr);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.btnAC);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.btnPower);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCbrt);
			this.Controls.Add(this.btnSbrt);
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
			this.Name = "MyCal";
			this.Text = "科学计算器";
			this.Load += new System.EventHandler(this.MyCal_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new MyCal());
		}

		private void btnEqual_Click(object sender, System.EventArgs e)
		{
			tbTip.Text=String.Empty;
			//输入为空
			if(tbExpression.Text==String.Empty)
				return;

			//词法分析
			pa=new PhraseAnalyzer.PhraseAnalyzer(tbExpression.Text+"#=",ref ps);
			if(pa.Succeed==false)
			{
				tbTip.Text="运算表达式中存在非法符号";
				return;			
			}
			//文法分析
			sa=new GrammerAnalyzer.SemanticAnalyzer(ref ps);
			if(sa.Check()==false)
			{	//文法出错
				tbTip.Text=sa.ErrorTip;
				return;
			}
			//词法正确，计算
			cunit=new CalUnit(ref ps);
			cunit.Run();
			//显示结果
			tbResult.Text=cunit.ANS;
		}

		private void MyCal_Load(object sender, System.EventArgs e)
		{
		
		}

		private void btnPI_Click(object sender, System.EventArgs e)
		{
			tbExpression.Text+="PI";
		}

		private void btnLeftBracket_Click(object sender, System.EventArgs e)
		{
			tbExpression.Text+="(";
		}

		private void btnRightBracket_Click(object sender, System.EventArgs e)
		{
			tbExpression.Text+=")";
		}

		private void btnPlus_Click(object sender, System.EventArgs e)
		{
			tbExpression.Text+="+";
		}

		private void btnMinus_Click(object sender, System.EventArgs e)
		{
			tbExpression.Text+="-";
		}

		private void btnTimes_Click(object sender, System.EventArgs e)
		{
			tbExpression.Text+="*";
		}

		private void btnDivide_Click(object sender, System.EventArgs e)
		{
			tbExpression.Text+="/";
		}

		private void btnMod_Click(object sender, System.EventArgs e)
		{
			tbExpression.Text+="%";
		}

		private void btnPower_Click(object sender, System.EventArgs e)
		{
			tbExpression.Text+="^";
		}

		private void btnNum1_Click(object sender, System.EventArgs e)
		{
			tbExpression.Text+="1";
		}

		private void btnNum2_Click(object sender, System.EventArgs e)
		{
			tbExpression.Text+="2";
		}

		private void btnNum3_Click(object sender, System.EventArgs e)
		{
			tbExpression.Text+="3";
		}

		private void btnNum4_Click(object sender, System.EventArgs e)
		{
			tbExpression.Text+="4";
		}

		private void btnNum5_Click(object sender, System.EventArgs e)
		{
			tbExpression.Text+="5";
		}

		private void btnNum6_Click(object sender, System.EventArgs e)
		{
			tbExpression.Text+="6";
		}

		private void btnNum7_Click(object sender, System.EventArgs e)
		{
			tbExpression.Text+="7";
		}

		private void btnNum8_Click(object sender, System.EventArgs e)
		{
			tbExpression.Text+="8";
		}

		private void btnNum9_Click(object sender, System.EventArgs e)
		{
			tbExpression.Text+="9";
		}

		private void btnNum0_Click(object sender, System.EventArgs e)
		{
			tbExpression.Text+="0";
		}

		private void btnDot_Click(object sender, System.EventArgs e)
		{
			tbExpression.Text+=".";
		}

		private void btnExp_Click(object sender, System.EventArgs e)
		{
			tbExpression.Text+="e^";
		}

		private void btnSin_Click(object sender, System.EventArgs e)
		{
			tbExpression.Text+="sin";
		}

		private void btnCos_Click(object sender, System.EventArgs e)
		{
			tbExpression.Text+="cos";
		}

		private void btnTg_Click(object sender, System.EventArgs e)
		{
			tbExpression.Text+="tg";
		}

		private void btnCtg_Click(object sender, System.EventArgs e)
		{
			tbExpression.Text+="ctg";
		}

		private void btnAsin_Click(object sender, System.EventArgs e)
		{
			tbExpression.Text+="asin";
		}

		private void btnAcos_Click(object sender, System.EventArgs e)
		{
			tbExpression.Text+="acos";
		}

		private void btnAtg_Click(object sender, System.EventArgs e)
		{
			tbExpression.Text+="atg";
		}

		private void btnActg_Click(object sender, System.EventArgs e)
		{
			tbExpression.Text+="actg";
		}

		private void btnSbrt_Click(object sender, System.EventArgs e)
		{
			tbExpression.Text+="sbrt";
		}

		private void btnCbrt_Click(object sender, System.EventArgs e)
		{
			tbExpression.Text+="cbrt";
		}

		private void btnLn_Click(object sender, System.EventArgs e)
		{
			tbExpression.Text+="ln";
		}

		private void btnLog_Click(object sender, System.EventArgs e)
		{
			tbExpression.Text+="log";
		}

		private void btnLg_Click(object sender, System.EventArgs e)
		{
			tbExpression.Text+="lg";
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			tbExpression.Text+="1/x";
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			tbExpression.Text+="^2";
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			tbExpression.Text+="^3";
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			tbExpression.Text+="!";
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
			btnSbrt.Enabled=enable;
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
			tbExpression.Text+="ANS";		
		}

		private void btnAx_Click(object sender, System.EventArgs e)
		{
			if(isStoClicked==true){
				ConstantTable.AX=ConstantTable.ANS;
				tbTip.Text="AX = "+ConstantTable.ANS.ToString();
				this.SetEnable(true);
				isStoClicked=false;
			}else
				tbExpression.Text+="AX";
		}

		private void btnBx_Click(object sender, System.EventArgs e)
		{
			if(isStoClicked==true)
			{
				ConstantTable.BX=ConstantTable.ANS;
				tbTip.Text="BX = "+ConstantTable.ANS.ToString();
				this.SetEnable(true);		
				isStoClicked=false;
			}else
				tbExpression.Text+="BX";
		}

		private void btnCx_Click(object sender, System.EventArgs e)
		{
			if(isStoClicked==true)
			{
				ConstantTable.CX=ConstantTable.ANS;
				tbTip.Text="CX = "+ConstantTable.ANS.ToString();
				this.SetEnable(true);		
				isStoClicked=false;
			}
			else
				tbExpression.Text+="CX";		
		}

		private void btnDx_Click(object sender, System.EventArgs e)
		{
			if(isStoClicked==true)
			{
				ConstantTable.DX=ConstantTable.ANS;
				tbTip.Text="DX = "+ConstantTable.ANS.ToString();
				this.SetEnable(true);		
				isStoClicked=false;
			}
			else
				tbExpression.Text+="DX";				
		}

		private void btnEx_Click(object sender, System.EventArgs e)
		{
			if(isStoClicked==true)
			{
				ConstantTable.EX=ConstantTable.ANS;
				tbTip.Text="EX = "+ConstantTable.ANS.ToString();
				this.SetEnable(true);		
				isStoClicked=false;
			}
			else
				tbExpression.Text+="EX";
		}

		private void btnAC_Click(object sender, System.EventArgs e)
		{
			tbExpression.Text=String.Empty;
			tbTip.Text=String.Empty;
			tbResult.Text="0.0";
			ConstantTable.ANS=0;
		}

		private void btnClr_Click(object sender, System.EventArgs e)
		{
			ConstantTable.ClearAll();
			tbTip.Text="所有变量已清除";
		}

		private void btnNegative_Click(object sender, System.EventArgs e)
		{
			tbExpression.Text+="@";
		}

		private void tbExpression_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if(e.KeyChar==(char)Keys.Escape)
			{
				tbExpression.Text="";
				e.Handled=true;
			}
			else if(e.KeyChar==(char)Keys.Enter)
			{
				//如果按下Enter，触发计算事件
				btnEqual_Click(btnEqual,null);			
				e.Handled=true;
			}
		}
	}
}
