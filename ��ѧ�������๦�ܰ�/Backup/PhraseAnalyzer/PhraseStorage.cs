#region BluePrint.Calculator, Copyright 2005 BluePrint Work Group, Programmed by Tony Qu
/* ************************************************************
 ��Ŀ���ƣ���ѧ������
 ʵ�����ԣ�C#
 ���ߣ�Tony Qu
 ���߲��ͣ�http://www.cnblogs.com/tonyqus
 ģ�����ƣ��ʷ�������
 ģ�������ռ䣺PhraseAnalyzer
 ��ǰ�ļ���Ϣ��PhraseAnalyzer.PhraseStorage
 Ŀǰ�汾��1.0.0.0
 
 ��ǰ�ļ��޶�  
	Who			Date			Version			Comment
	Tony Qu		2005.4.15		1.0.0.0			��ɻ������
*************************************************************/
#endregion  

using System;
using System.Collections;
using System.Collections.Specialized;

namespace PhraseAnalyzer
{
	/// <summary>
	/// �ʴ洢��Ԫ
	/// </summary>
	public class PhraseStorage
	{
		private StringCollection _scOutput=null;	//�ִʽ���������
		private ArrayList _stcOutput=null;		//�ִ����ͽ���������
		
		public PhraseStorage()
		{
			_scOutput=new StringCollection();
			_stcOutput=new ArrayList();
		}
		/// <summary>
		/// �ʵ�����
		/// </summary>
		public int Length
		{
			get{return _scOutput.Count;}
		}
		/// <summary>
		/// ����洢�Ľ��
		/// </summary>
		public void ClearResult()
		{
			_scOutput.Clear();
			_stcOutput.Clear();
		}
		/// <summary>
		/// ���һ����
		/// </summary>
		/// <param name="phrase">��</param>
		public void AddPhrase(string phrase)
		{
			_scOutput.Add(phrase);
		}
		/// <summary>
		/// ���һ������
		/// </summary>
		/// <param name="pt">����</param>
		public void AddPhraseType(PhraseType pt)
		{
			_stcOutput.Add(pt);
		}
		/// <summary>
		/// ���һ���ʺ�����Ӧ�Ĵ���
		/// </summary>
		/// <param name="phrase">��</param>
		/// <param name="pt">����</param>
		public void AddPhraseResult(string phrase,PhraseType pt)
		{
			_scOutput.Add(phrase);			
			_stcOutput.Add(pt);
		}
		/// <summary>
		/// ������ֵĸ���ֵ
		/// </summary>
		/// <param name="index">����</param>
		/// <returns></returns>
		public double GetNumberValue(int index)
		{
			string temp_str=_scOutput[index];
			if(_scOutput[index][0]=='@')	
				temp_str=temp_str.Replace('@','-');	//��'@'ת��Ϊ����

				return Convert.ToDouble(temp_str);
		}
		/// <summary>
		/// ����ִʽ��
		/// </summary>
		public StringCollection PhraseResult
		{
			get{
				return _scOutput;
			}
		}
		/// <summary>
		/// ����ִ����ͽ��
		/// </summary>
		public PhraseType[] PhraseTypeResult
		{
			get
			{
				return (PhraseType[])_stcOutput.ToArray(System.Type.GetType("PhraseAnalyzer.PhraseType"));
			}
		}
		/// <summary>
		/// �ʷ����ͱ��ʽ�ַ���
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
