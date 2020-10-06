#region BluePrint.Calculator, Copyright 2005 BluePrint Work Group, Programmed by Tony Qu
/* ************************************************************
 项目名称：科学计算器
 实现语言：C#
 作者：Tony Qu
 作者博客：http://www.cnblogs.com/tonyqus
 模块名称：词法分析器
 模块命名空间：PhraseAnalyzer
 当前文件信息：PhraseAnalyzer.OperatorPriority
 目前版本：1.0.0.0
 
 当前文件修订  
	Who			Date			Version			Comment
	Tony Qu		2005.4.15		1.0.0.0			完成优先级设定
*************************************************************/
#endregion  
using System;

namespace PhraseAnalyzer
{
	/// <summary>
	/// 优先级表
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
