#region BluePrint.Calculator, Copyright 2005 BluePrint Work Group, Programmed by Tony Qu
/* ************************************************************
 项目名称：科学计算器
 实现语言：C#
 作者：Tony Qu
 作者博客：http://www.cnblogs.com/tonyqus
 模块名称：运算单元
 模块命名空间：Calculator
 当前文件信息：Calculator.CalUnit，运算单元核心
 目前版本：1.0.1.2
 
 当前文件修订  
	Who			Date			Version			Comment
	Tony Qu		2005.5.5		1.0.0.0			创建该类
	Tony Qu		2005.5.10		1.0.1.0			调整算法和优先级表
	Tony Qu		2005.5.23		1.0.1.2			修正不能计算(3)-5的问题
												修正cbrt运算公式错误
*************************************************************/
#endregion  

using System;
using System.Collections;
using PhraseAnalyzer;
using GrammerAnalyzer;

namespace Calculator
{
	/// <summary>
	/// 计算单元
	/// </summary>
	public class CalUnit
	{
        /// <summary>
        /// 运算符栈
        /// </summary>
		private Stack _optr=null;	//
        /// <summary>
        /// 数栈
        /// </summary>
		private Stack _opnd=null;	//
		private PhraseStorage _ps=null;
        //设置角度的单位，是角度"JiaoDu"，还是弧度"HuDu",
        private string strJiaoDuDanWei="HuDu";

		public CalUnit(ref PhraseStorage ps)
		{
			_optr=new Stack();
			_opnd=new Stack();
			_ps=ps;
		}

        public string  JiaoDuDanWei
        {
            set { strJiaoDuDanWei = value; }
            get { return strJiaoDuDanWei; }
        }
		/// <summary>
		/// 阶乘
		/// </summary>
		/// <param name="i">阶数</param>
		/// <returns></returns>
		private double Factorial(double i) 
		{ 
			return((i <= 1) ? 1 : (i * Factorial(i-1))); 
		}
		/// <summary>
		/// 根据运算符类型进行运算
		/// </summary>
		/// <param name="a">操作数1</param>
		/// <param name="b">操作数2</param>
		/// <param name="pt">运算符类型</param>
		/// <returns>运算结果</returns>
		private double Calculate(PhraseType pt)
		{
			//获得操作数
			double a,b;
			a=b=0.0;
			OperandType ot=Operator.OperandCount(pt);
			switch(ot)
			{
				case OperandType.O2:	//双目运算
					b=(double)_opnd.Pop();
					a=(double)_opnd.Pop();
					break;
				case OperandType.O1:	//单目运算
					a=(double)_opnd.Pop();
					b=0.0;
					break;
				case OperandType.O0:	//零目运算
					return 0.0;
			}
			//计算
			switch(pt)
			{
				//四则运算
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
				//三角函数//这个考虑到有角度和弧度区别
				case PhraseType.sin:
                    if (strJiaoDuDanWei.ToUpper()=="JiaoDu".ToUpper())
                    {
                        return Math.Sin(a*Math.PI/180);   
                    }
					return Math.Sin(a);
				case PhraseType.cos:
                    if (strJiaoDuDanWei.ToUpper() == "JiaoDu".ToUpper())
                    {
                        return Math.Cos(a * Math.PI / 180);
                    }
					return Math.Cos(a);
				case PhraseType.tg:
                    if (strJiaoDuDanWei.ToUpper() == "JiaoDu".ToUpper())
                    {
                        return Math.Tan(a * Math.PI / 180);
                    }
					return Math.Tan(a);
				case PhraseType.ctg:
                    if (strJiaoDuDanWei.ToUpper() == "JiaoDu".ToUpper())
                    {
                        return 1.0/(Math.Tan(a * Math.PI / 180));
                    }
					return 1.0/Math.Tan(a);
                    //反三角
				case PhraseType.acos:
                    if (strJiaoDuDanWei.ToUpper() == "JiaoDu".ToUpper())
                    {
                        return Math.Acos(a) * 180 / Math.PI;
                    }
					return Math.Acos(a);
				case PhraseType.asin:
                    if (strJiaoDuDanWei.ToUpper() == "JiaoDu".ToUpper())
                    {
                        return Math.Asin(a)*180/Math.PI;
                    }
					return Math.Asin(a);
				case PhraseType.atg:
                    if (strJiaoDuDanWei.ToUpper() == "JiaoDu".ToUpper())
                    {
                        return Math.Atan(a) * 180 / Math.PI;
                    }
					return Math.Atan(a);
				case PhraseType.actg:
                    if (strJiaoDuDanWei.ToUpper() == "JiaoDu".ToUpper())
                    {
                        return 1.0 /(Math.Atan(a) * 180 / Math.PI);
                    }
					return 1.0/Math.Atan(a);
                //双曲函数
                case PhraseType.sinh:
                    if (strJiaoDuDanWei.ToUpper() == "JiaoDu".ToUpper())
                    {
                        return Math.Sinh(a * Math.PI / 180);
                    }
                    return Math.Sinh(a);
                case PhraseType.cosh:
                    if (strJiaoDuDanWei.ToUpper() == "JiaoDu".ToUpper())
                    {
                        return Math.Cosh(a * Math.PI / 180);
                    }
                    return Math.Cosh(a);
                case PhraseType.tanh:
                    if (strJiaoDuDanWei.ToUpper() == "JiaoDu".ToUpper())
                    {
                        return Math.Tanh(a * Math.PI / 180);
                    }
                    return Math.Tanh(a);

				//乘方
				case PhraseType.pow:
					return Math.Pow(a,b);
				case PhraseType.sqrt:
					return Math.Sqrt(a);
				case PhraseType.cbrt:
					return Math.Pow(a,1.0/3.0);
				//log系列
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
		/// 运算
		/// </summary>
		public void Run()
		{
			//把所有的词压入栈中
			int i=0;
			_optr.Clear();
			_optr.Push(PhraseType.sharp);	//将#作为栈操作结束标志
			
			_opnd.Clear();

			while(i<_ps.Length)
			{
				PhraseType temp_pt=_ps.PhraseTypeResult[i];
				if(temp_pt==PhraseType.number)		//是数
					_opnd.Push(_ps.GetNumberValue(i));
				else if(temp_pt==PhraseType.e)		//是e
					_opnd.Push(ConstantTable.EXP);
				else if(temp_pt==PhraseType.pi)		//是pi
					_opnd.Push(ConstantTable.PI);
				else if(temp_pt==PhraseType.ans)	//是ans
					_opnd.Push(ConstantTable.ANS);
				else if(temp_pt==PhraseType.ax||temp_pt==PhraseType.bx||temp_pt==PhraseType.cx
					||temp_pt==PhraseType.dx||temp_pt==PhraseType.ex||temp_pt==PhraseType.fx)
					_opnd.Push(ConstantTable.GetFrom(temp_pt.ToString()));
				else	//是运算符
				{
					//运算结束
					if((PhraseType)_optr.Peek()==PhraseType.sharp&&temp_pt==PhraseType.sharp)
						break;

					PriorityCmpType temp_pct=(PriorityCmpType)Operator.OperatorCmp2((PhraseType)_optr.Peek(),temp_pt);
					if(temp_pct==PriorityCmpType.Higher)
					{
						do
						{
							//对前一个运算符进行运算
							if(Operator.OperandCount((PhraseType)_optr.Peek())!=OperandType.O0)	//不是零目运算符
								_opnd.Push(Calculate((PhraseType)_optr.Pop()));

						}while((PriorityCmpType)Operator.OperatorCmp2((PhraseType)_optr.Peek(),temp_pt)==PriorityCmpType.Higher);
						//当相邻PhraseType优先级相等时
						if((PriorityCmpType)Operator.OperatorCmp2((PhraseType)_optr.Peek(),temp_pt)==PriorityCmpType.Equal)
						{
							_optr.Pop();	//抛出相等的prePhraseType
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
			//存储结果到ans
			ConstantTable.ANS=(double)_opnd.Peek();
		}
		/// <summary>
		/// 计算结果
		/// </summary>
		public string ANS
		{
			get{
				if(ConstantTable.ANS.CompareTo(double.NaN)==0		//非数字
					||ConstantTable.ANS.CompareTo(double.PositiveInfinity)==0	//正无穷大
					||ConstantTable.ANS.CompareTo(double.NegativeInfinity)==0)	//负无穷大
					return "结果超出表示范围";
				else
					return ConstantTable.ANS.ToString();
			}
		}
	}
}
