#region BluePrint.Calculator, Copyright 2005 BluePrint Work Group, Programmed by Tony Qu
/* ************************************************************
 ��Ŀ���ƣ���ѧ������
 ʵ�����ԣ�C#
 ���ߣ�Tony Qu
 ���߲��ͣ�http://www.cnblogs.com/tonyqus
 ģ�����ƣ��ʷ�������
 ģ�������ռ䣺PhraseAnalyzer
 ��ǰ�ļ���Ϣ��PhraseAnalyzer.OperandType
 Ŀǰ�汾��1.0.0.0
 
 ��ǰ�ļ��޶�  
	Who			Date			Version			Comment
	Tony Qu		2005.4.14		1.0.0.0			��������趨
*************************************************************/
#endregion  
using System;

namespace PhraseAnalyzer
{
	/// <summary>
	/// ����Ŀ��
	/// </summary>
	public enum OperandType:int
	{
		O0,		//0Ŀ����
		O1,		//1Ŀ����
		O2,		//2Ŀ����
		Unknown	//δ֪
	}
}
