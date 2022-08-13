#region BluePrint.Calculator, Copyright 2005 BluePrint Work Group, Programmed by Tony Qu
/* ************************************************************
 项目名称：科学计算器
 实现语言：C#
 作者：Tony Qu
 作者博客：http://www.cnblogs.com/tonyqus
 模块名称：词法分析器
 模块命名空间：PhraseAnalyzer
 当前文件信息：PhraseAnalyzer.PhraseStorage
 目前版本：1.0.0.0
 
 当前文件修订  
	Who			Date			Version			Comment
	Tony Qu		2005.4.15		1.0.0.0			完成基本设计
*************************************************************/
#endregion  

using System;
using System.Collections;
using System.Collections.Specialized;

namespace PhraseAnalyzer
{
	/// <summary>
	/// 词存储单元
	/// </summary>
	public class PhraseStorage
	{
		private StringCollection _scOutput=null;	//分词结果保存变量
		private ArrayList _stcOutput=null;		//分词类型结果保存变量
		
		public PhraseStorage()
		{
			_scOutput=new StringCollection();
			_stcOutput=new ArrayList();
		}
		/// <summary>
		/// 词的数量
		/// </summary>
		public int Length
		{
			get{return _scOutput.Count;}
		}
		/// <summary>
		/// 清除存储的结果
		/// </summary>
		public void ClearResult()
		{
			_scOutput.Clear();
			_stcOutput.Clear();
		}
		/// <summary>
		/// 添加一个词
		/// </summary>
		/// <param name="phrase">词</param>
		public void AddPhrase(string phrase)
		{
			_scOutput.Add(phrase);
		}
		/// <summary>
		/// 添加一个词类
		/// </summary>
		/// <param name="pt">词类</param>
		public void AddPhraseType(PhraseType pt)
		{
			_stcOutput.Add(pt);
		}
		/// <summary>
		/// 添加一个词和它对应的词类
		/// </summary>
		/// <param name="phrase">词</param>
		/// <param name="pt">词类</param>
		public void AddPhraseResult(string phrase,PhraseType pt)
		{
			_scOutput.Add(phrase);			
			_stcOutput.Add(pt);
		}
		/// <summary>
		/// 获得数字的浮点值
		/// </summary>
		/// <param name="index">索引</param>
		/// <returns></returns>
		public double GetNumberValue(int index)
		{
			string temp_str=_scOutput[index];
			if(_scOutput[index][0]=='@')	
				temp_str=temp_str.Replace('@','-');	//把'@'转换为负号

				return Convert.ToDouble(temp_str);
		}
		/// <summary>
		/// 输出分词结果
		/// </summary>
		public StringCollection PhraseResult
		{
			get{
				return _scOutput;
			}
		}
		/// <summary>
		/// 输出分词类型结果
		/// </summary>
		public PhraseType[] PhraseTypeResult
		{
			get
			{
				return (PhraseType[])_stcOutput.ToArray(System.Type.GetType("PhraseAnalyzer.PhraseType"));
			}
		}
		/// <summary>
		/// 词法类型表达式字符串
		/// </summary>
		public string ExpressionOutput
		{
			get
			{
				string temp="|";
				foreach(PhraseType item in _stcOutput.ToArray(System.Type.GetType("PhraseAnalyzer.PhraseType")))
				{
					temp+=((int)item).ToString()+"|";
				}
				return temp;
			}
		}
	}
}
