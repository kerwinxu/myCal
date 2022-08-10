#region BluePrint.Calculator, Copyright 2005 BluePrint Work Group, Programmed by Tony Qu
/* ************************************************************
 ��Ŀ���ƣ���ѧ������
 ʵ�����ԣ�C#
 ���ߣ�Tony Qu
 ���߲��ͣ�http://www.cnblogs.com/tonyqus
 ģ�����ƣ��ʷ�������
 ģ�������ռ䣺PhraseAnalyzer
 ��ǰ�ļ���Ϣ��PhraseAnalyzer.OperatorPriority
 Ŀǰ�汾��1.0.0.0
 
 ��ǰ�ļ��޶�  
	Who			Date			Version			Comment
	Tony Qu		2005.4.15		1.0.0.0			������ȼ��趨
*************************************************************/
#endregion  
using System;

namespace PhraseAnalyzer
{
	/// <summary>
	/// ���ȼ���
	/// </summary>
	public enum OperatorPriority:int
	{
		P0,
		P1,
		P2,
		P3,
		P4,
		P5,
		P6,
		P7,
		Unknown
	}
}
