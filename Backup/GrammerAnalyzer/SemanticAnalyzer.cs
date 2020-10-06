#region BluePrint.Calculator, Copyright 2005 BluePrint Work Group, Programmed by Tony Qu
/* ************************************************************
 ��Ŀ���ƣ���ѧ������
 ʵ�����ԣ�C#
 ���ߣ�Tony Qu
 ���߲��ͣ�http://www.cnblogs.com/tonyqus
 ģ�����ƣ��ķ�������
 ģ�������ռ䣺GrammerAnalyzer
 ��ǰ�ļ���Ϣ��GrammerAnalyzer.SemanticAnalyzer���ķ�����������
 Ŀǰ�汾��1.0.2.0
 
 ��ǰ�ļ��޶�  
	Who			Date			Version			Comment
	Tony Qu		2005.4.20		1.0.0.0			��ɻ����ķ�����
	Tony Qu		2005.5.10		1.0.1.0			�����㷨�����ȼ�ģ��
	Tony Qu		2005.5.15		1.0.2.0			���alpha�汾
*************************************************************/
#endregion  


using System;
using System.Collections;
using PhraseAnalyzer;

namespace GrammerAnalyzer
{
	/// <summary>
	/// �ķ�������
	/// </summary>
	public class SemanticAnalyzer
	{
		private Stack _optr;		//�����ջ
		private Stack _opnd;		//����ջ
		private Stack _op;			//����ջ�������������������ջ��
		private PhraseStorage _ps=null;
		private PhraseType _lastOpForError;	//�������������Ǹ������

		public SemanticAnalyzer(ref PhraseStorage ps)
		{
			_optr=new Stack();
			_opnd=new Stack();
			_op=new Stack();
			_ps=ps;
		}
		public string ErrorTip
		{
			get{
				//������Ϣ����UI������ʾ�Ż���
				if(_lastOpForError==PhraseType.unknown)
					return "������ʽ����δ֪����";
				else if(_lastOpForError==PhraseType.sharp)
					return "������ʽ����";
				else if(_lastOpForError==PhraseType.plus)
					return "��\'+\'�������ڴ���";
				else if(_lastOpForError==PhraseType.minus)
					return "��\'-\'�������ڴ���";
				else if(_lastOpForError==PhraseType.mutiple)
					return "��\'*\'�������ڴ���";
				else if(_lastOpForError==PhraseType.divide)
					return "��\'/\'�������ڴ���";
				else if(_lastOpForError==PhraseType.rightbracket)
					return "��\')\'�������ڴ���";
				else if(_lastOpForError==PhraseType.leftbracket)
					return "��\'(\'�������ڴ���";
				else if(_lastOpForError==PhraseType.pow)
					return "��\'^\'�������ڴ���";
				else if(_lastOpForError==PhraseType.fact)
					return "��\'!\'�������ڴ���";
				else if(_lastOpForError==PhraseType.mod)
					return "��\'%\'�������ڴ���";
				else if(_lastOpForError==PhraseType.number)
					return "��ĳ�����ָ������ڴ���";
				else
					return "��\'"+_lastOpForError.ToString()+"\'�������ܴ��ڴ���";
			}
		}
		/// <summary>
		/// �������㣨��������ʵ�ļ��㣩
		/// </summary>
		/// <returns>�Ƿ��д�����</returns>
		private bool FakeCalculate()
		{
			PhraseType pt=(PhraseType)_optr.Pop();
			OperandType oc=Operator.OperandCount(pt);	//ջ�������Ŀ��

			PhraseType temp_pt;	//�洢_op��pop����һ������

			switch(oc)
			{
				case OperandType.O0:	//0Ŀ�������������
					_lastOpForError=pt;
					return false;
					//_op.Pop();
					//break;
				case OperandType.O1:	//1Ŀ�����
					if(_opnd.Count>=1)
					{
						_opnd.Pop();
						_op.Pop();	//�׳�����
					}
					else
					{	//û���㹻����������ƥ�������������
						_lastOpForError=pt;
						return false;
					}
					temp_pt=(PhraseType)_op.Pop();
					//�׳���������ڽ����ż��
					if(Operator.OperatorCmp((PhraseType)_op.Peek(),temp_pt)==PriorityCmpType.Unknown)
					{
						_lastOpForError=pt;
						return false;
					}
					_opnd.Push(PhraseType.number);
					_op.Push(PhraseType.number);
					break;
				case OperandType.O2:	//2Ŀ�����
					if(_opnd.Count>=2)
					{
						_opnd.Pop();
						_opnd.Pop();
						_op.Pop();	//�׳�����
					}
					else
					{
						_lastOpForError=pt;
						return false;
					}
					temp_pt=(PhraseType)_op.Pop();
					//�׳��������ڽ����ż��
					if(Operator.OperatorCmp((PhraseType)_op.Peek(),temp_pt)==PriorityCmpType.Unknown)
					{
						_lastOpForError=pt;
						return false;
					}
					temp_pt=(PhraseType)_op.Pop();
					//�׳���������ڽ����ż��
					if(Operator.OperatorCmp((PhraseType)_op.Peek(),temp_pt)==PriorityCmpType.Unknown)
					{
						_lastOpForError=pt;
						return false;
					}

					_opnd.Push(PhraseType.number);
					_op.Push(PhraseType.number);
					break;
			}
			return true;
		}
		/// <summary>
		/// ����ķ�
		/// </summary>
		/// <returns>�Ƿ���ȷ</returns>
		public bool Check()
		{
			_optr.Clear();
			_optr.Push(PhraseType.sharp);	//��#��Ϊջ����������־
			_opnd.Clear();
			_op.Clear();
			_op.Push(PhraseType.sharp);		//��#��Ϊջ����������־
			
			int i=0;
			while(i<_ps.Length)
			{
				PhraseType temp_pt=_ps.PhraseTypeResult[i];
				//����ǰ������ڼ��
				PriorityCmpType temp_pct=(PriorityCmpType)Operator.OperatorCmp((PhraseType)_op.Peek(),temp_pt);
				if(temp_pct==PriorityCmpType.Unknown)
				{
					_lastOpForError=temp_pt;
					return false;
				}
				//�����㴦��
				if(temp_pt==PhraseType.number||temp_pt==PhraseType.e||temp_pt==PhraseType.pi||temp_pt==PhraseType.ans
					||temp_pt==PhraseType.ax||temp_pt==PhraseType.bx||temp_pt==PhraseType.cx||temp_pt==PhraseType.dx
					||temp_pt==PhraseType.ex||temp_pt==PhraseType.fx)
				{	//����
					_opnd.Push(PhraseType.number);
					_op.Push(PhraseType.number);
				}
				else	//�������
				{
					//�������
					if((PhraseType)_optr.Peek()==PhraseType.sharp&&temp_pt==PhraseType.sharp)
						break;

					temp_pct=(PriorityCmpType)Operator.OperatorCmp2((PhraseType)_optr.Peek(),temp_pt);
					if(temp_pct==PriorityCmpType.Higher)
					{
						do
						{
							if(this.FakeCalculate()==false)	//��������
								return false;
						}while((PriorityCmpType)Operator.OperatorCmp2((PhraseType)_optr.Peek(),temp_pt)==PriorityCmpType.Higher);
						//������PhraseType���ȼ����ʱ
						if((PriorityCmpType)Operator.OperatorCmp2((PhraseType)_optr.Peek(),temp_pt)==PriorityCmpType.Equal)
						{
							_optr.Pop();	//�׳���ȵ�prePhraseType
							//��������(number)�����������
							PhraseType pt1=(PhraseType)_op.Pop();
							_op.Pop();
							_op.Push(pt1);
						}
						else
						{
							_optr.Push(temp_pt);
							_op.Push(temp_pt);
						}
					}
					else if(temp_pct==PriorityCmpType.Lower)
					{
						_optr.Push(temp_pt);
						_op.Push(temp_pt);
					}
					else if(temp_pct==PriorityCmpType.Equal)
					{
						_optr.Pop();
						PhraseType pt1=(PhraseType)_op.Pop();
						_op.Pop();
						_op.Push(pt1);
					}
					else
					{		//�����˲��������ڵķ���
						_lastOpForError=(PhraseType)_optr.Peek();
						return false;
					}
				}
				i++;
			}
			//��ջ��飬�������ֻʣһ��Ԫ�ر���
			if(_opnd.Count!=1)
			{
				_lastOpForError=PhraseType.unknown;
				return false;
			}
			return true;
		}
	}
}
