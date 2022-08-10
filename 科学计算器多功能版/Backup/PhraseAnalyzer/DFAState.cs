#region BluePrint.Calculator, Copyright 2005 BluePrint Work Group, Programmed by Tony Qu
/* ************************************************************
 项目名称：科学计算器
 实现语言：C#
 作者：Tony Qu
 作者博客：http://www.cnblogs.com/tonyqus
 模块名称：词法分析器
 模块命名空间：PhraseAnalyzer
 当前文件信息：PhraseAnalyzer.DFAState
 目前版本：1.0.0.1
 
 当前文件修订  
	Who			Date			Version			Comment
	Tony Qu		2005.4.14		1.0.0.0			完成DFA状态设定
	Tony Qu		2005.4.25		1.0.0.1			加入#对应状态S14
*************************************************************/
#endregion  
using System;

namespace PhraseAnalyzer
{
	/// <summary>
	/// 计算语句的有限自动机状态
	/// </summary>
	public enum DFAState:int
	{
		S0=0,	///初态
		S1=1,	///整数串，不带小数点
		S2=2,	///浮点数串
		S3=3,	///字母串
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
		SX=15,	/// 未知态
	}
}
