#region BluePrint.Calculator, Copyright 2005 BluePrint Work Group, Programmed by Tony Qu
/* ************************************************************
 ��Ŀ���ƣ���ѧ������
 ʵ�����ԣ�C#
 ���ߣ�Tony Qu
 ���߲��ͣ�http://www.cnblogs.com/tonyqus
 ģ�����ƣ��ķ�������
 ģ�������ռ䣺GrammerAnalyzer
 ��ǰ�ļ���Ϣ��GrammerAnalyzer.PriorityCmpType�����ȼ��Ƚ����
 Ŀǰ�汾��1.0.0.0
 
 ��ǰ�ļ��޶�  
	Who			Date			Version			Comment
	Tony Qu		2005.5.2		1.0.0.0			������ö��
*************************************************************/
#endregion  

using System;

namespace GrammerAnalyzer
{
	/// <summary>
	/// ���ȼ��Ƚ�����
	/// </summary>
	public enum PriorityCmpType
	{
		Unknown=0,	//�޷��Ƚ�
		Higher=1,	//����
		Lower=2,	//����
		Equal=3		//����
	}
}
