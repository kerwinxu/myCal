#region BluePrint.Calculator, Copyright 2005 BluePrint Work Group, Programmed by Tony Qu
/* ************************************************************
 项目名称：科学计算器
 实现语言：C#
 作者：Tony Qu
 作者博客：http://www.cnblogs.com/tonyqus
 模块名称：运算单元
 模块命名空间：Calculator
 当前文件信息：Calculator.ConstantTable，常数表
 目前版本：1.0.0.5
 
 当前文件修订  
	Who			Date			Version			Comment
	Tony Qu		2005.5.5		1.0.0.0			创建该类
	Tony Qu		2005.5.23		1.0.0.5			加入ClearAll()
												调整SaveTo与GetFrom中的识别名称为NX
*************************************************************/
#endregion  

using System;

namespace Calculator
{
	/// <summary>
	/// 常数及变量表
	/// </summary>
	public class ConstantTable
	{
		public static double AX=0.0;	//数存储变量A
		public static double BX=0.0;	//数存储变量B
		public static double CX=0.0;	//数存储变量C
		public static double DX=0.0;	//数存储变量D
		public static double EX=0.0;	//数存储变量E
		public static double FX=0.0;	//数存储变量F
		public static double ANS=0.0;	//最终结果存储变量

		public const double PI=Math.PI;	//常数PI
		public readonly static double EXP=Math.Exp(1);	//常数e
		/// <summary>
		/// 保存浮点数到一个变量
		/// </summary>
		/// <param name="x">变量名</param>
		/// <param name="Value">值</param>
		public static void SaveTo(string x,double Value)
		{
			switch(x.ToUpper())
			{
				case "AX":
					ConstantTable.AX=Value;
					break;
				case "BX":
					ConstantTable.BX=Value;
					break;
				case "CX":
					ConstantTable.CX=Value;
					break;
				case "DX":
					ConstantTable.DX=Value;
					break;
				case "EX":
					ConstantTable.EX=Value;
					break;
				case "FX":
					ConstantTable.FX=Value;
					break;
				default:
					ConstantTable.ANS=Value;
					break;
			}
		}
		/// <summary>
		/// 从一个变量读取一个浮点值
		/// </summary>
		/// <param name="x">变量名</param>
		/// <returns></returns>
		public static double GetFrom(string x)
		{
			switch(x.ToUpper())
			{
				case "AX":
					return ConstantTable.AX;
				case "BX":
					return ConstantTable.BX;
				case "CX":
					return ConstantTable.CX;
				case "DX":
					return ConstantTable.DX;
				case "EX":
					return ConstantTable.EX;
				case "FX":
					return ConstantTable.FX;
				default:
					return ConstantTable.ANS;
			}		
		}
		/// <summary>
		/// 清除所有存储变量
		/// </summary>
		public static void ClearAll()
		{
			ConstantTable.AX=0;
			ConstantTable.BX=0;
			ConstantTable.CX=0;
			ConstantTable.DX=0;
			ConstantTable.EX=0;
			ConstantTable.FX=0;
		}
	}
}
