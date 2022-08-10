#region BluePrint.Calculator, Copyright 2005 BluePrint Work Group, Programmed by Tony Qu
/* ************************************************************
 项目名称：科学计算器
 实现语言：C#
 作者：Tony Qu
 作者博客：http://www.cnblogs.com/tonyqus
 模块名称：文法分析器
 模块命名空间：GrammerAnalyzer
 当前文件信息：GrammerAnalyzer.PriorityCmpType，优先级比较类别
 目前版本：1.0.0.0
 
 当前文件修订  
	Who			Date			Version			Comment
	Tony Qu		2005.5.2		1.0.0.0			创建该枚举
*************************************************************/
#endregion  

using System;

namespace GrammerAnalyzer
{
	/// <summary>
	/// 优先级比较类型
	/// </summary>
	public enum PriorityCmpType
	{
		Unknown=0,	//无法比较
		Higher=1,	//高于
		Lower=2,	//低于
		Equal=3		//等于
	}
}
