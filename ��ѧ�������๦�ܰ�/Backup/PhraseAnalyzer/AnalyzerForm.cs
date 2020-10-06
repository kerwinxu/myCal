using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace PhraseAnalyzer
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class AnalyzerForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox tbExpression;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbOutput;
		private System.Windows.Forms.ListView lvPhrase;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnAnalyze;
		private PhraseStorage ps;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public AnalyzerForm()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

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
			this.tbExpression = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnAnalyze = new System.Windows.Forms.Button();
			this.tbOutput = new System.Windows.Forms.TextBox();
			this.lvPhrase = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// tbExpression
			// 
			this.tbExpression.Location = new System.Drawing.Point(8, 24);
			this.tbExpression.Multiline = true;
			this.tbExpression.Name = "tbExpression";
			this.tbExpression.Size = new System.Drawing.Size(552, 56);
			this.tbExpression.TabIndex = 0;
			this.tbExpression.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "表达式";
			// 
			// btnAnalyze
			// 
			this.btnAnalyze.Location = new System.Drawing.Point(16, 88);
			this.btnAnalyze.Name = "btnAnalyze";
			this.btnAnalyze.Size = new System.Drawing.Size(64, 23);
			this.btnAnalyze.TabIndex = 2;
			this.btnAnalyze.Text = "分析";
			this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
			// 
			// tbOutput
			// 
			this.tbOutput.Location = new System.Drawing.Point(8, 144);
			this.tbOutput.Multiline = true;
			this.tbOutput.Name = "tbOutput";
			this.tbOutput.Size = new System.Drawing.Size(312, 64);
			this.tbOutput.TabIndex = 3;
			this.tbOutput.Text = "";
			// 
			// lvPhrase
			// 
			this.lvPhrase.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																					   this.columnHeader1,
																					   this.columnHeader2});
			this.lvPhrase.Location = new System.Drawing.Point(328, 88);
			this.lvPhrase.Name = "lvPhrase";
			this.lvPhrase.Size = new System.Drawing.Size(232, 168);
			this.lvPhrase.TabIndex = 4;
			this.lvPhrase.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "词";
			this.columnHeader1.Width = 129;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "词类";
			this.columnHeader2.Width = 74;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 120);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 16);
			this.label2.TabIndex = 5;
			this.label2.Text = "结果";
			// 
			// AnalyzerForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(568, 266);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lvPhrase);
			this.Controls.Add(this.tbOutput);
			this.Controls.Add(this.tbExpression);
			this.Controls.Add(this.btnAnalyze);
			this.Controls.Add(this.label1);
			this.Name = "AnalyzerForm";
			this.Text = "词法分析器";
			this.Load += new System.EventHandler(this.AnalyzerForm_Load);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new AnalyzerForm());
		}

		private void btnAnalyze_Click(object sender, System.EventArgs e)
		{
			lvPhrase.Items.Clear();
			if(tbExpression.Text.Length!=0)
			{
				PhraseAnalyzer pa=new PhraseAnalyzer(tbExpression.Text.Trim(),ref ps);
				System.Collections.Specialized.StringCollection sc=ps.PhraseResult;
				PhraseType[] pt=ps.PhraseTypeResult;
				for(int i=0;i<sc.Count;i++)
				{
					AddPhrase(sc[i],pt[i].ToString());
				}
				tbOutput.Text=ps.ExpressionOutput;
			}
		}

		private void AddPhrase(string phrase,string phraseType)
		{
			ListViewItem lvi=new ListViewItem(phrase);
			lvi.SubItems.Add(phraseType);
			lvPhrase.Items.Add(lvi);
		}

		private void AnalyzerForm_Load(object sender, System.EventArgs e)
		{
		
		}
	}
}
