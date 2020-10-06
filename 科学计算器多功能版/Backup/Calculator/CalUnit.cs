#region BluePrint.Calculator, Copyright 2005 BluePrint Work Group, Programmed by Tony Qu
/* ************************************************************
 ��Ŀ���ƣ���ѧ������
 ʵ�����ԣ�C#
 ���ߣ�Tony Qu
 ���߲��ͣ�http://www.cnblogs.com/tonyqus
 ģ�����ƣ����㵥Ԫ
 ģ�������ռ䣺Calculator
 ��ǰ�ļ���Ϣ��Calculator.CalUnit�����㵥Ԫ����
 Ŀǰ�汾��1.0.1.2
 
 ��ǰ�ļ��޶�  
	Who			Date			Version			Comment
	Tony Qu		2005.5.5		1.0.0.0			��������
	Tony Qu		2005.5.10		1.0.1.0			�����㷨�����ȼ���
	Tony Qu		2005.5.23		1.0.1.2			�������ܼ���(3)-5������
												����cbrt���㹫ʽ����
*************************************************************/
#endregion  

using System;
using System.Collections;
using PhraseAnalyzer;
using GrammerAnalyzer;

namespace Calculator
{
	/// <summary>
	/// ���㵥Ԫ
	/// </summary>
	public class CalUnit
	{
		private Stack _optr=null;	//�����ջ
		private Stack _opnd=null;	//��ջ
		private PhraseStorage _ps=null;

		public CalUnit(ref PhraseStorage ps)
		{
			_optr=new Stack();
			_opnd=new Stack();
			_ps=ps;
		}
		/// <summary>
		/// �׳�
		/// </summary>
		/// <param name="i">����</param>
		/// <returns></returns>
		private double Factorial(double i) 
		{ 
			return((i <= 1) ? 1 : (i * Factorial(i-1))); 
		}
		/// <summary>
		/// ������������ͽ�������
		/// </summary>
		/// <param name="a">������1</param>
		/// <param name="b">������2</param>
		/// <param name="pt">���������</param>
		/// <returns>������</returns>
		private double Calculate(PhraseType pt)
		{
			//��ò�����
			double a,b;
			a=b=0.0;
			OperandType ot=Operator.OperandCount(pt);
			switch(ot)
			{
				case OperandType.O2:	//˫Ŀ����
					b=(double)_opnd.Pop();
					a=(double)_opnd.Pop();
					break;
				case OperandType.O1:	//��Ŀ����
					a=(double)_opnd.Pop();
					b=0.0;
					break;
				case OperandType.O0:	//��Ŀ����
					return 0.0;
			}
			//����
			switch(pt)
			{
				//��������
				case PhraseType.plus:
					return a+b;
				case PhraseType.minus:
					return a-b;
				case PhraseType.mutiple:
					return a*b;
				case PhraseType.divide:
					return a/b;
				case PhraseType.mod:
					return a%b;
				case PhraseType.fact:
					return Factorial(a);
				//���Ǻ���
				case PhraseType.sin:
					return Math.Sin(a);
				case PhraseType.cos:
					return Math.Cos(a);
				case PhraseType.tg:
					return Math.Tan(a);
				case PhraseType.ctg:
					return 1.0/Math.Tan(a);
				case PhraseType.acos:
					return Math.Acos(a);
				case PhraseType.asin:
					return Math.Asin(a);
				case PhraseType.atg:
					return Math.Atan(a);
				case PhraseType.actg:
					return 1.0/Math.Atan(a);
				//�˷�
				case PhraseType.pow:
					return Math.Pow(a,b);
				case PhraseType.sbrt:
					return Math.Sqrt(a);
				case PhraseType.cbrt:
					return Math.Pow(a,1.0/3.0);
				//logϵ��
				case PhraseType.ln:
					return Math.Log(a,ConstantTable.EXP);
				case PhraseType.log:
					return Math.Log(b,a);		//a log b
				case PhraseType.lg:
					return Math.Log10(a);
				default:
					return 0.0;
			}
		}
		/// <summary>
		/// ����
		/// </summary>
		public void Run()
		{
			//�����еĴ�ѹ��ջ��
			int i=0;
			_optr.Clear();
			_optr.Push(PhraseType.sharp);	//��#��Ϊջ����������־
			
			_opnd.Clear();

			while(i<_ps.Length)
			{
				PhraseType temp_pt=_ps.PhraseTypeResult[i];
				if(temp_pt==PhraseType.number)		//����
					_opnd.Push(_ps.GetNumberValue(i));
				else if(temp_pt==PhraseType.e)		//��e
					_opnd.Push(ConstantTable.EXP);
				else if(temp_pt==PhraseType.pi)		//��pi
					_opnd.Push(ConstantTable.PI);
				else if(temp_pt==PhraseType.ans)	//��ans
					_opnd.Push(ConstantTable.ANS);
				else if(temp_pt==PhraseType.ax||temp_pt==PhraseType.bx||temp_pt==PhraseType.cx
					||temp_pt==PhraseType.dx||temp_pt==PhraseType.ex||temp_pt==PhraseType.fx)
					_opnd.Push(ConstantTable.GetFrom(temp_pt.ToString()));
				else	//�������
				{
					//�������
					if((PhraseType)_optr.Peek()==PhraseType.sharp&&temp_pt==PhraseType.sharp)
						break;

					PriorityCmpType temp_pct=(PriorityCmpType)Operator.OperatorCmp2((PhraseType)_optr.Peek(),temp_pt);
					if(temp_pct==PriorityCmpType.Higher)
					{
						do
						{
							//��ǰһ���������������
							if(Operator.OperandCount((PhraseType)_optr.Peek())!=OperandType.O0)	//������Ŀ�����
								_opnd.Push(Calculate((PhraseType)_optr.Pop()));

						}while((PriorityCmpType)Operator.OperatorCmp2((PhraseType)_optr.Peek(),temp_pt)==PriorityCmpType.Higher);
						//������PhraseType���ȼ����ʱ
						if((PriorityCmpType)Operator.OperatorCmp2((PhraseType)_optr.Peek(),temp_pt)==PriorityCmpType.Equal)
						{
							_optr.Pop();	//�׳���ȵ�prePhraseType
						}
						else
						{
							_optr.Push(temp_pt);
						}
					}
					else if(temp_pct==PriorityCmpType.Lower)
					{
						_optr.Push(temp_pt);
					}
					else if(temp_pct==PriorityCmpType.Equal)
					{
						_optr.Pop();
					}
				}
				i++;
			}
			//�洢�����ans
			ConstantTable.ANS=(double)_opnd.Peek();
		}
		/// <summary>
		/// ������
		/// </summary>
		public string ANS
		{
			get{
				if(ConstantTable.ANS.CompareTo(double.NaN)==0		//������
					||ConstantTable.ANS.CompareTo(double.PositiveInfinity)==0	//�������
					||ConstantTable.ANS.CompareTo(double.NegativeInfinity)==0)	//�������
					return "���������ʾ��Χ";
				else
					return ConstantTable.ANS.ToString();
			}
		}
	}
}
