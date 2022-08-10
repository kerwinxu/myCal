#region BluePrint.Calculator, Copyright 2005 BluePrint Work Group, Programmed by Tony Qu
/* ************************************************************
 ��Ŀ���ƣ���ѧ������
 ʵ�����ԣ�C#
 ���ߣ�Tony Qu
 ���߲��ͣ�http://www.cnblogs.com/tonyqus
 ģ�����ƣ��ʷ�������
 ģ�������ռ䣺PhraseAnalyzer
 ��ǰ�ļ���Ϣ��PhraseAnalyzer.DFAState
 Ŀǰ�汾��1.0.0.1
 
 ��ǰ�ļ��޶�  
	Who			Date			Version			Comment
	Tony Qu		2005.4.14		1.0.0.0			���DFA״̬�趨
	Tony Qu		2005.4.25		1.0.0.1			����#��Ӧ״̬S14
*************************************************************/
#endregion  
using System;

namespace PhraseAnalyzer
{
	/// <summary>
	/// �������������Զ���״̬
	/// </summary>
	public enum DFAState:int
	{
		S0=0,	///��̬
		S1=1,	///������������С����
		S2=2,	///��������
		S3=3,	///��ĸ��
		S4=4,	/// +
		S5=5,	/// -
		S6=6,	/// *
		S7=7,	/// /
		S8=8,	/// %
		S9=9,	/// !
		S10=10,	/// ^
		S11=11,	/// =
		S12=12,	/// (
		S13=13,	/// )
		S14=14, /// #
		SX=15,	/// δ֪̬
	}
}
