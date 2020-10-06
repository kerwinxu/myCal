using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using PhraseAnalyzer;

namespace GrammerAnalyzer
{
	/// <summary>
	/// SemanticForm ��ժҪ˵����
	/// </summary>
	public class SemanticForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox tbExpression;
		private System.Windows.Forms.Button btnCheck;
		private PhraseAnalyzer.PhraseAnalyzer pa;
		private SemanticAnalyzer sa;
		private System.Windows.Forms.TextBox tbResult;
		private PhraseAnalyzer.PhraseStorage ps;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;

		public SemanticForm()
		{
			//
			// Windows ���������֧���������
			//
			InitializeComponent();

			//
			// TODO: �� InitializeComponent ���ú�����κι��캯������
			//
			ps=new PhraseStorage();
		}

		/// <summary>
		/// ������������ʹ�õ���Դ��
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows ������������ɵĴ���
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
		/// </summary>
		private void InitializeComponent()
		{
			this.tbExpression = new System.Windows.Forms.TextBox();
			this.tbResult = new System.Windows.Forms.TextBox();
			this.btnCheck = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// tbExpression
			// 
			this.tbExpression.Location = new System.Drawing.Point(8, 32);
			this.tbExpression.Multiline = true;
			this.tbExpression.Name = "tbExpression";
			this.tbExpression.Size = new System.Drawing.Size(400, 80);
			this.tbExpression.TabIndex = 0;
			this.tbExpression.Text = "";
			// 
			// tbResult
			// 
			this.tbResult.Location = new System.Drawing.Point(8, 192);
			this.tbResult.Multiline = true;
			this.tbResult.Name = "tbResult";
			this.tbResult.Size = new System.Drawing.Size(400, 64);
			this.tbResult.TabIndex = 1;
			this.tbResult.Text = "";
			// 
			// btnCheck
			// 
			this.btnCheck.Location = new System.Drawing.Point(8, 120);
			this.btnCheck.Name = "btnCheck";
			this.btnCheck.Size = new System.Drawing.Size(80, 24);
			this.btnCheck.TabIndex = 2;
			this.btnCheck.Text = "���";
			this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 160);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 24);
			this.label1.TabIndex = 3;
			this.label1.Text = "���";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "���ʽ";
			// 
			// SemanticForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(424, 266);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCheck);
			this.Controls.Add(this.tbResult);
			this.Controls.Add(this.tbExpression);
			this.Name = "SemanticForm";
			this.Text = "�ķ�������";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// Ӧ�ó��������ڵ㡣
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new SemanticForm());
		}

		private void btnCheck_Click(object sender, System.EventArgs e)
		{
			pa=new PhraseAnalyzer.PhraseAnalyzer(tbExpression.Text+"#=",ref ps);
			if(pa.Succeed==false)
			{
				tbResult.Text="�ķ�����ʧ�ܣ������Ƿ���ڲ�����ķ���";
				return;
			}
			sa=new SemanticAnalyzer(ref ps);
			if(sa.Check()==false)
				tbResult.Text=sa.ErrorTip;
			else
				tbResult.Text="��ȷ";
		}
	}
}
