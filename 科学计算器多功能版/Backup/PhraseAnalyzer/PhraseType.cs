#region BluePrint.Calculator, Copyright 2005 BluePrint Work Group, Programmed by Tony Qu
/* ************************************************************
 项目名称：科学计算器
 实现语言：C#
 作者：Tony Qu
 作者博客：http://www.cnblogs.com/tonyqus
 模块名称：词法分析器
 模块命名空间：PhraseAnalyzer
 当前文件信息：PhraseAnalyzer.PhraseType
 目前版本：1.0.0.0
 
 当前文件修订  
	Who			Date			Version			Comment
	Tony Qu		2005.4.14		1.0.0.0			完成类型设定
*************************************************************/
#endregion  

using System;

namespace PhraseAnalyzer
{
	/// <summary>
	/// 词类型
	/// </summary>
	public enum PhraseType:int
	{
		unknown=0,
		ln=1,
		lg=2,
		log=3,
		pow=4,		//a^b
		cbrt=6,		//a^-0.5
		sbrt=7,		//a^-1/3
		fact=8,
		sin=10,
		cos=11,
		asin=12,
		acos=13,
		tg=14,
		ctg=15,
		atg=16,
		actg=17,
		plus=18,
		minus=19,
		mutiple=20,
		divide=21,
		mod=23,
		leftbracket=24,		//(
		rightbracket=25,	//)
		ans=26,		//variable ans
		sto=27,		//save to var
		clr=28,		//clear vars
		ax=29,		//variable a
		bx=30,		//variable b
		cx=31,		//variable c
		dx=32,		//variable d
		ex=33,		//variable e
		fx=34,		//variable f
		e=35,
		pi=36,
		number=37,
		sharp=38
	}
}
