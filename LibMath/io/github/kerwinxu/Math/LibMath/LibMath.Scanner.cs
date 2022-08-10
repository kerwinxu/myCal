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
        /// 取得实数
        /// </summary>
        void GetReal()
        {
            yylval.s = yytext;
            yylval.n = new Complex(double.Parse(yytext), 0);
        }

        /// <summary>
        /// 取得虚数
        /// </summary>
        void GetImaginary()
        {
            yylval.s = yytext;
            yylval.n = new Complex(0,double.Parse(yytext));
        }



        public override void yyerror(string format, params object[] args)
		{
			base.yyerror(format, args);
			Console.WriteLine(format, args);
			Console.WriteLine();
		}
    }
}
