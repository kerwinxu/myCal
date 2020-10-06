#region BluePrint.Calculator, Copyright 2005 BluePrint Work Group, Programmed by Tony Qu
/* ************************************************************
 ��Ŀ���ƣ���ѧ������
 ʵ�����ԣ�C#
 ���ߣ�Tony Qu
 ���߲��ͣ�http://www.cnblogs.com/tonyqus
 ģ�����ƣ��ʷ�������
 ģ�������ռ䣺PhraseAnalyzer
 ��ǰ�ļ���Ϣ��PhraseAnalyzer.PhraseAnalyzer���ʷ�����������
 Ŀǰ�汾��1.0.1.2
 
 ��ǰ�ļ��޶�  
	Who			Date			Version			Comment
	Tony Qu		2005.4.15		1.0.0.0			��ɻ����ʷ�����
	Tony Qu		2005.5.13		1.0.1.0			����ַ��������޶���ֻ����ָ����Χ�ڵ��ַ���ͨ��
	Tony Qu		2005.5.23		1.0.1.2			����ʶ��pi,eΪPhraseType.number������
												�����˱���x���ַ����������򣬸�AΪAX
												������ln,lg,log��ʶ��֧��
												�����ո���ֺ��޷�ʶ�������
*************************************************************/
#endregion  

using System;
using System.Collections;
using System.Collections.Specialized;
using System.Globalization;

namespace PhraseAnalyzer
{
	/// <summary>
	/// �ʷ�������
	/// </summary>
	public class PhraseAnalyzer
	{
		private DFAState _prestate;			//DFA��ǰһ��״̬
		private char[] _chArray=null;		//���ӱ������ַ�����ʽ
		private string _sentence=null;		//���ӱ���
		private PhraseStorage _ps=null;
		private bool _succeed=true;

		public PhraseAnalyzer(string sentence,ref PhraseStorage ps)
		{
			//���ǰһ�εĴʷ��������
			_ps=ps;
			_ps.ClearResult();
			//�������
			_sentence=sentence;
			_succeed=true;
			//Сд�������е�������ĸ
			_chArray=sentence.ToLower().ToCharArray();
			if(Analyze()==false)	//����
				_ps.AddPhraseResult("����",PhraseType.unknown);
		}
		/// <summary>
		/// �Ƿ�ɹ�
		/// </summary>
		public bool Succeed
		{
			get{
				return _succeed;
			}
		}
		/// <summary>
		/// �����
		/// </summary>
		/// <param name="startpos">��ʼλ��</param>
		/// <param name="endpos">����λ��</param>
		private void SavePhrase(int startpos,int endpos)
		{
			string temp=null;			

			if(endpos>=0 && startpos>=0 && endpos>=startpos)
			{
				//trim()���Է�ֹ��startpos��endposͷβ���ֿո�
				temp=_sentence.Substring(startpos,endpos-startpos+1).Trim().ToLower();
				_ps.AddPhraseResult(temp,PhraseAnalyzer.StrToType(temp));
			}
		}
		/// <summary>
		/// ת���ַ���Ϊ����Ӧ�Ĵ���
		/// </summary>
		/// <param name="str">���ַ���</param>
		/// <returns></returns>
		public static PhraseType StrToType(string str)
		{
			switch(str)
			{
				case "sin": return PhraseType.sin;
				case "cos": return PhraseType.cos;
				case "ln": return PhraseType.ln;
				case "lg": return PhraseType.lg;
				case "log": return PhraseType.log;
				case "^": return PhraseType.pow;
				case "cbrt": return PhraseType.cbrt;
				case "sbrt": return PhraseType.sbrt;
				case "asin": return PhraseType.asin;
				case "acos": return PhraseType.acos;
				case "!": return PhraseType.fact;
				case "tg": return PhraseType.tg;
				case "ctg": return PhraseType.ctg;
				case "atg":return PhraseType.atg;
				case "actg":return PhraseType.actg;
				case "+":return PhraseType.plus;
				case "-":return PhraseType.minus;
				case "*":return PhraseType.mutiple;
				case "/":return PhraseType.divide;
				case "%":return PhraseType.mod;
				case "(":return PhraseType.leftbracket;
				case ")":return PhraseType.rightbracket;
				case "#":return PhraseType.sharp;
				case "ans":return PhraseType.ans;
				case "sto":return PhraseType.sto;
				case "clr":return PhraseType.clr;
				case "ax": return PhraseType.ax;
				case "bx": return PhraseType.bx;
				case "cx": return PhraseType.cx;
				case "dx": return PhraseType.dx;
				case "ex": return PhraseType.ex;
				case "fx": return PhraseType.fx;
				case "e": return PhraseType.e;
				case "pi": return PhraseType.pi;
				default: return PhraseType.number;
			}
		}
		/// <summary>
		/// �ַ������ͼ��
		/// </summary>
		/// <param name="startpos">�ַ�����ʼλ��</param>
		/// <param name="endpos">�ַ�������λ��</param>
		/// <returns>�ַ����Ƿ�ƥ��涨��Χ���ݵ�����</returns>
		private bool CheckString(int startpos,int endpos)
		{
			//trim()���Է�ֹ��startpos��endposͷβ���ֿո�
			string temp=this._sentence.Substring(startpos,endpos-startpos+1).Trim().ToLower();
			int len=temp.Length;	//�����temp.length��һ������endpos-startpos+1
			if(len==1)
			{
				switch(temp)
				{
					case "e":
						return true;
				}
			}
			else if(len==2)
			{
				switch(temp)
				{
					case "ln":
					case "lg":
					case "tg":
					case "ax":
					case "bx":
					case "cx":
					case "dx":
					case "ex":
					case "fx":
					case "pi":
						return true;
				}
			}
			else if(len==3)
			{
				switch(temp)
				{
					case "cos":
					case "sin":
					case "ctg":
					case "atg":
					case "ans":
					case "clr":
					case "sto":
					case "log":
						return true;
				}
			}
			else if(len==4)
			{
				switch(temp)
				{
					case "acos":
					case "asin":
					case "actg":
					case "sbrt":
					case "cbrt":
						return true;
				}
			}
			return false;
		}
		/// <summary>
		/// �ʷ�����
		/// </summary>
		/// <returns>�Ƿ�ɹ�</returns>
		private bool Analyze()
		{
			int i=0;
			int startpos=0,endpos=0;
			//���ó�̬
			_prestate=DFAState.S0;
			while(i<_chArray.Length){
				//δ֪̬����������
				if(_prestate==DFAState.SX)
				{
					_succeed=false;
					return false;
				}

				if(Char.IsLetter(_chArray[i]))
				{
					//��ĸ
					if(_prestate==DFAState.S0)
					{	
						//��̬����ĸ��
						_prestate=DFAState.S3;
					}
					else if(_prestate!=DFAState.S3)
					{
						//����ǰһ����
						endpos=i-1;	//�������λ��
						SavePhrase(startpos,endpos);
						//����ĸ��ת��Ϊ��ĸ��
						_prestate=DFAState.S3;
						//���濪ʼλ��
						startpos=i;
					}
					else	//֮ǰ��״̬Ϊ��ĸ��DFAState.S3
					{
						
						endpos=i-1;	//�������λ��

						//�����ĸ����ƥ������
						if(CheckString(startpos,endpos)==true)
						{
							SavePhrase(startpos,endpos);
							startpos=i;
						}
					}
				}
				else if(Char.IsDigit(_chArray[i]))
				{
					//����
					if(_prestate==DFAState.S0)	
					{
						//��̬
						_prestate=DFAState.S1;
						startpos=i;	//���濪ʼλ��
					}
					else if(_prestate==DFAState.S1)
					{
						//��������״̬����
					}
					else if(_prestate==DFAState.S2)	//��������
						_prestate=DFAState.S2;
					else
					{	
						//����ǰһ����
						endpos=i-1;	//�������λ��
						//�ַ������ͼ��
						if(_prestate==DFAState.S3&&CheckString(startpos,endpos)==false)
							return false;	//���ǰһ��״̬Ϊ�ַ���̬�����ַ���ƥ��ʧ�ܣ����˳�
						else
							SavePhrase(startpos,endpos);

						//�ӷ����ִ�ת��Ϊ������
						_prestate=DFAState.S1;
						//���濪ʼλ��
						startpos=i;
					}
				}
				else if(_chArray[i]=='.')
				{
					//С����
					if(_prestate==DFAState.S1||_prestate==DFAState.S0)		
						_prestate=DFAState.S2;	//�����������̬��Ϊ��������
					else
					{	//δ֪̬
						// ��Ҫ����: �Ƿ񱣴�ǰһ����
						_prestate=DFAState.SX;
					}
				}
				else if(Char.IsWhiteSpace(_chArray[i]))
				{
					//�ո�����
				}
				/*	�ظ�����ʱɾ��
				else if(Char.GetUnicodeCategory(_chArray[i])==UnicodeCategory.ClosePunctuation)
				{
					if(_prestate!=DFAState.S0)
					{
						//����ǰһ����
						endpos=i-1;
						SavePhrase(startpos,endpos);
					}
					if(_chArray[i]=='(')		//������
						_prestate=DFAState.S12;
					else if(_chArray[i]==')')	 //������
						_prestate=DFAState.S13;

					//���濪ʼλ��
					startpos=i;
				}*/
				else if(_chArray[i]=='@')
				{
					//������־
					if(_prestate==DFAState.S0)	//��̬
					{
						_prestate=DFAState.S1;	//������
					}else if(_prestate==DFAState.S1||_prestate==DFAState.S2)	//�������򸡵�����
						_prestate=DFAState.SX;	//δ֪̬
					else{
						//����ǰһ����
						endpos=i-1;
						//�ַ������ͼ��
						if(_prestate==DFAState.S3&&CheckString(startpos,endpos)==false)
							return false;	//���ǰһ��״̬Ϊ�ַ���̬�����ַ���ƥ��ʧ�ܣ����˳�
						else
							SavePhrase(startpos,endpos);
						//������
						_prestate=DFAState.S1;
						//���濪ʼλ��
						startpos=i;
					}

				}
				else if(_chArray[i]=='+'||_chArray[i]=='-'||_chArray[i]=='*'||_chArray[i]=='/'||_chArray[i]=='^'||_chArray[i]=='%'||_chArray[i]=='='||_chArray[i]=='('||_chArray[i]==')'||_chArray[i]=='!'||_chArray[i]=='#')
				{
					if(_prestate!=DFAState.S0)
					{
						//����ǰһ����
						endpos=i-1;
						//�ַ������ͼ��
						if(_prestate==DFAState.S3&&CheckString(startpos,endpos)==false)
							return false;	//���ǰһ��״̬Ϊ�ַ���̬�����ַ���ƥ��ʧ�ܣ����˳�
						else
							SavePhrase(startpos,endpos);
					}

					if(_chArray[i]=='+')
						_prestate=DFAState.S4;
					else if(_chArray[i]=='-')
						_prestate=DFAState.S5;
					else if(_chArray[i]=='*')
						_prestate=DFAState.S6;
					else if(_chArray[i]=='/')
						_prestate=DFAState.S7;
					else if(_chArray[i]=='=')
						_prestate=DFAState.S11;
					else if(_chArray[i]=='%')
						_prestate=DFAState.S8;
					else if(_chArray[i]=='^')
						_prestate=DFAState.S10;
					else if(_chArray[i]=='(')
						_prestate=DFAState.S12;
					else if(_chArray[i]==')')
						_prestate=DFAState.S13;
					else if(_chArray[i]=='!')
						_prestate=DFAState.S9;
					else if(_chArray[i]=='#')
						_prestate=DFAState.S14;

					//���濪ʼλ��
					startpos=i;
				}
				else
				{
					// ��Ҫ����: �Ƿ񱣴�ǰһ����
					//δ֪�ַ�������δ֪̬
					_prestate=DFAState.SX;
				}
				i++;
			}
			return true;
		}
	}
}
