#region BluePrint.Calculator, Copyright 2005 BluePrint Work Group, Programmed by Tony Qu
/* ************************************************************
 ��Ŀ���ƣ���ѧ������
 ʵ�����ԣ�C#
 ���ߣ�Tony Qu
 ���߲��ͣ�http://www.cnblogs.com/tonyqus
 ģ�����ƣ��ʷ�������
 ģ�������ռ䣺PhraseAnalyzer
 ��ǰ�ļ���Ϣ��PhraseAnalyzer.PhraseType
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
	/// ������
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
