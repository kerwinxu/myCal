using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace io.github.kerwinxu.Math.LibMath
{
    internal partial class LibMathScanner
    {

        void GetNumber()
        {
            yylval.s = yytext;
            yylval.n = new Complex(int.Parse(yytext), 0);
            
                ;
        }

        /// <summary>
        /// ȡ��ʵ��
        /// </summary>
        void GetReal()
        {
            yylval.s = yytext;
            yylval.n = new Complex(double.Parse(yytext), 0);
        }

        /// <summary>
        /// ȡ������
        /// </summary>
        void GetImaginary()
        {
            yylval.s = yytext;
            yylval.n = new Complex(0,double.Parse(yytext));
        }
        /// <summary>
        /// ȡ��Բ����
        /// </summary>
        void GetPI()
        {
            yylval.s = yytext;
            yylval.n = new Complex(System.Math.PI, 0);
        }

        /// <summary>
        /// ȡ����Ȼ������
        /// </summary>
        void GetEXP()
        {
            yylval.s = yytext;
            yylval.n = new Complex(System.Math.Exp(1), 0);
        }


        public override void yyerror(string format, params object[] args)
		{
			base.yyerror(format, args);
			Console.WriteLine(format, args);
			Console.WriteLine();
		}
    }
}
