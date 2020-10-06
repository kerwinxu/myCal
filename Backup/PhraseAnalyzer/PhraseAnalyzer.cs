#region BluePrint.Calculator, Copyright 2005 BluePrint Work Group, Programmed by Tony Qu
/* ************************************************************
 项目名称：科学计算器
 实现语言：C#
 作者：Tony Qu
 作者博客：http://www.cnblogs.com/tonyqus
 模块名称：词法分析器
 模块命名空间：PhraseAnalyzer
 当前文件信息：PhraseAnalyzer.PhraseAnalyzer，词法分析核心类
 目前版本：1.0.1.2
 
 当前文件修订  
	Who			Date			Version			Comment
	Tony Qu		2005.4.15		1.0.0.0			完成基本词法分析
	Tony Qu		2005.5.13		1.0.1.0			完成字符串类型限定，只允许指定范围内的字符串通过
	Tony Qu		2005.5.23		1.0.1.2			修正识别pi,e为PhraseType.number的问题
												调整了变量x的字符串命名规则，该A为AX
												修正对ln,lg,log的识别支持
												修正空格出现后，无法识别的问题
*************************************************************/
#endregion  

using System;
using System.Collections;
using System.Collections.Specialized;
using System.Globalization;

namespace PhraseAnalyzer
{
	/// <summary>
	/// 词法分析类
	/// </summary>
	public class PhraseAnalyzer
	{
		private DFAState _prestate;			//DFA的前一个状态
		private char[] _chArray=null;		//句子变量的字符串形式
		private string _sentence=null;		//句子变量
		private PhraseStorage _ps=null;
		private bool _succeed=true;

		public PhraseAnalyzer(string sentence,ref PhraseStorage ps)
		{
			//清除前一次的词法分析结果
			_ps=ps;
			_ps.ClearResult();
			//保存句子
			_sentence=sentence;
			_succeed=true;
			//小写化句子中的所有字母
			_chArray=sentence.ToLower().ToCharArray();
			if(Analyze()==false)	//出错
				_ps.AddPhraseResult("出错",PhraseType.unknown);
		}
		/// <summary>
		/// 是否成功
		/// </summary>
		public bool Succeed
		{
			get{
				return _succeed;
			}
		}
		/// <summary>
		/// 保存词
		/// </summary>
		/// <param name="startpos">开始位置</param>
		/// <param name="endpos">结束位置</param>
		private void SavePhrase(int startpos,int endpos)
		{
			string temp=null;			

			if(endpos>=0 && startpos>=0 && endpos>=startpos)
			{
				//trim()，以防止在startpos到endpos头尾出现空格
				temp=_sentence.Substring(startpos,endpos-startpos+1).Trim().ToLower();
				_ps.AddPhraseResult(temp,PhraseAnalyzer.StrToType(temp));
			}
		}
		/// <summary>
		/// 转换字符串为所对应的词类
		/// </summary>
		/// <param name="str">词字符串</param>
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
		/// 字符串类型检查
		/// </summary>
		/// <param name="startpos">字符串开始位置</param>
		/// <param name="endpos">字符串结束位置</param>
		/// <returns>字符串是否匹配规定范围内容的类型</returns>
		private bool CheckString(int startpos,int endpos)
		{
			//trim()，以防止在startpos到endpos头尾出现空格
			string temp=this._sentence.Substring(startpos,endpos-startpos+1).Trim().ToLower();
			int len=temp.Length;	//这里的temp.length不一定等于endpos-startpos+1
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
		/// 词法分析
		/// </summary>
		/// <returns>是否成功</returns>
		private bool Analyze()
		{
			int i=0;
			int startpos=0,endpos=0;
			//设置初态
			_prestate=DFAState.S0;
			while(i<_chArray.Length){
				//未知态处理，出错返回
				if(_prestate==DFAState.SX)
				{
					_succeed=false;
					return false;
				}

				if(Char.IsLetter(_chArray[i]))
				{
					//字母
					if(_prestate==DFAState.S0)
					{	
						//初态变字母串
						_prestate=DFAState.S3;
					}
					else if(_prestate!=DFAState.S3)
					{
						//处理前一个词
						endpos=i-1;	//保存结束位置
						SavePhrase(startpos,endpos);
						//非字母串转换为字母串
						_prestate=DFAState.S3;
						//保存开始位置
						startpos=i;
					}
					else	//之前的状态为字母串DFAState.S3
					{
						
						endpos=i-1;	//保存结束位置

						//检查字母串的匹配类型
						if(CheckString(startpos,endpos)==true)
						{
							SavePhrase(startpos,endpos);
							startpos=i;
						}
					}
				}
				else if(Char.IsDigit(_chArray[i]))
				{
					//数字
					if(_prestate==DFAState.S0)	
					{
						//初态
						_prestate=DFAState.S1;
						startpos=i;	//保存开始位置
					}
					else if(_prestate==DFAState.S1)
					{
						//整数串，状态不变
					}
					else if(_prestate==DFAState.S2)	//浮点数串
						_prestate=DFAState.S2;
					else
					{	
						//处理前一个词
						endpos=i-1;	//保存结束位置
						//字符串类型检查
						if(_prestate==DFAState.S3&&CheckString(startpos,endpos)==false)
							return false;	//如果前一个状态为字符串态，且字符串匹配失败，则退出
						else
							SavePhrase(startpos,endpos);

						//从非数字串转换为整数串
						_prestate=DFAState.S1;
						//保存开始位置
						startpos=i;
					}
				}
				else if(_chArray[i]=='.')
				{
					//小数点
					if(_prestate==DFAState.S1||_prestate==DFAState.S0)		
						_prestate=DFAState.S2;	//由整数串或初态变为浮点数串
					else
					{	//未知态
						// 需要讨论: 是否保存前一个词
						_prestate=DFAState.SX;
					}
				}
				else if(Char.IsWhiteSpace(_chArray[i]))
				{
					//空格，跳过
				}
				/*	重复，暂时删除
				else if(Char.GetUnicodeCategory(_chArray[i])==UnicodeCategory.ClosePunctuation)
				{
					if(_prestate!=DFAState.S0)
					{
						//处理前一个词
						endpos=i-1;
						SavePhrase(startpos,endpos);
					}
					if(_chArray[i]=='(')		//左括号
						_prestate=DFAState.S12;
					else if(_chArray[i]==')')	 //右括号
						_prestate=DFAState.S13;

					//保存开始位置
					startpos=i;
				}*/
				else if(_chArray[i]=='@')
				{
					//负数标志
					if(_prestate==DFAState.S0)	//初态
					{
						_prestate=DFAState.S1;	//整数串
					}else if(_prestate==DFAState.S1||_prestate==DFAState.S2)	//整数串或浮点数串
						_prestate=DFAState.SX;	//未知态
					else{
						//处理前一个词
						endpos=i-1;
						//字符串类型检查
						if(_prestate==DFAState.S3&&CheckString(startpos,endpos)==false)
							return false;	//如果前一个状态为字符串态，且字符串匹配失败，则退出
						else
							SavePhrase(startpos,endpos);
						//整数串
						_prestate=DFAState.S1;
						//保存开始位置
						startpos=i;
					}

				}
				else if(_chArray[i]=='+'||_chArray[i]=='-'||_chArray[i]=='*'||_chArray[i]=='/'||_chArray[i]=='^'||_chArray[i]=='%'||_chArray[i]=='='||_chArray[i]=='('||_chArray[i]==')'||_chArray[i]=='!'||_chArray[i]=='#')
				{
					if(_prestate!=DFAState.S0)
					{
						//处理前一个词
						endpos=i-1;
						//字符串类型检查
						if(_prestate==DFAState.S3&&CheckString(startpos,endpos)==false)
							return false;	//如果前一个状态为字符串态，且字符串匹配失败，则退出
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

					//保存开始位置
					startpos=i;
				}
				else
				{
					// 需要讨论: 是否保存前一个词
					//未知字符，进入未知态
					_prestate=DFAState.SX;
				}
				i++;
			}
			return true;
		}
	}
}
