#region BluePrint.Calculator, Copyright 2005 BluePrint Work Group, Programmed by Tony Qu
/* ************************************************************
 ��Ŀ���ƣ���ѧ������
 ʵ�����ԣ�C#
 ���ߣ�Tony Qu
 ���߲��ͣ�http://www.cnblogs.com/tonyqus
 ģ�����ƣ����㵥Ԫ
 ģ�������ռ䣺Calculator
 ��ǰ�ļ���Ϣ��Calculator.ConstantTable��������
 Ŀǰ�汾��1.0.0.5
 
 ��ǰ�ļ��޶�  
	Who			Date			Version			Comment
	Tony Qu		2005.5.5		1.0.0.0			��������
	Tony Qu		2005.5.23		1.0.0.5			����ClearAll()
												����SaveTo��GetFrom�е�ʶ������ΪNX
*************************************************************/
#endregion  

using System;

namespace Calculator
{
	/// <summary>
	/// ������������
	/// </summary>
	public class ConstantTable
	{
		public static double AX=0.0;	//���洢����A
		public static double BX=0.0;	//���洢����B
		public static double CX=0.0;	//���洢����C
		public static double DX=0.0;	//���洢����D
		public static double EX=0.0;	//���洢����E
		public static double FX=0.0;	//���洢����F
		public static double ANS=0.0;	//���ս���洢����

		public const double PI=Math.PI;	//����PI
		public readonly static double EXP=Math.Exp(1);	//����e
		/// <summary>
		/// ���渡������һ������
		/// </summary>
		/// <param name="x">������</param>
		/// <param name="Value">ֵ</param>
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
		/// ��һ��������ȡһ������ֵ
		/// </summary>
		/// <param name="x">������</param>
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
		/// ������д洢����
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
