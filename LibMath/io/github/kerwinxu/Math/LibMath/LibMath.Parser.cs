using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Numerics;

namespace io.github.kerwinxu.Math.LibMath
{
    internal partial class LibMathParser
    {
        /// <summary>
        /// ���յĽ����������ߣ�
        /// </summary>
        Complex _result;


        /// <summary>
        /// �Ƿ��ǽǶȣ�true���Ƕȣ�false�����ȡ�
        /// </summary>
        public bool isAngle { get; set; }

        /// <summary>
        /// ����Ĵ����ġ�
        /// </summary>
        public Dictionary<string, Complex> REG { get; set; }

        /// <summary>
        /// ��һ��ִ�еĽ��
        /// </summary>
        public Complex ANS { get; set; }

        public LibMathParser() : base(null) {
            // ���ﴴ������Ĭ�ϵļĴ���
            string[] regs = { "AX", "BX", "CX", "DX", "EX", "FX" };
            REG = new Dictionary<string, Complex>();
            foreach (var item in regs)
            {
                REG[item] = Complex.Zero;
            }
        }

        public void Parse(string s)
        {
            byte[] inputBuffer = System.Text.Encoding.Default.GetBytes(s);
            MemoryStream stream = new MemoryStream(inputBuffer);
            this.Scanner = new LibMathScanner(stream);
            this.Parse();
        }

        public  void yyerror(string format, params object[] args)
        {
            throw new ScannerError(string.Format(format, args));
            //Console.WriteLine(format, args);
        }

        /// <summary>
        /// ���㺯���ģ�����������߱༭��һ�㣬���Զ���ȫ��
        /// </summary>
        /// <param name="funName"></param>
        /// <param name="funarg"></param>
        /// <returns></returns>
        public Complex fun(string funName, Complex funarg)
        {
            Complex tmp;
            switch (funName)
            {
                case "sin": return Complex.Sin(isAngle ? funarg * System.Math.PI / 180 : funarg);
                case "cos": return Complex.Cos(isAngle ? funarg * System.Math.PI / 180 : funarg);
                case "tan": return Complex.Tan(isAngle ? funarg * System.Math.PI / 180 : funarg);
                case "cot": return Complex.One/Complex.Tan(isAngle ? funarg * System.Math.PI / 180 : funarg);
                case "asin": tmp = Complex.Asin(funarg);return isAngle ? tmp * 180 / System.Math.PI : tmp;
                case "acos": tmp = Complex.Acos(funarg); return isAngle ? tmp * 180 / System.Math.PI : tmp;
                case "atan": tmp = Complex.Atan(funarg); return isAngle ? tmp * 180 / System.Math.PI : tmp;
                case "acot": tmp = Complex.Atan(Complex.One/funarg); return isAngle ? tmp * 180 / System.Math.PI : tmp;
                //
                case "sinh": return Complex.Sinh(isAngle ? funarg * System.Math.PI / 180 : funarg);
                case "cosh": return Complex.Cosh(isAngle ? funarg * System.Math.PI / 180 : funarg);
                case "tanh": return Complex.Tanh(isAngle ? funarg * System.Math.PI / 180 : funarg);
                //
                case "arcsh": return Complex.Log(funarg + Complex.Sqrt(Complex.Pow(funarg, 2) + 1));
                case "arcch": return Complex.Log(funarg + Complex.Sqrt(Complex.Pow(funarg, 2) - 1));
                case "arcth": return Complex.Log(Complex.Sqrt((1+funarg)/(1-funarg)));
                case "abs": return Complex.Abs(funarg);
                case "lg": return Complex.Log10(funarg);
                case "sqrt": return Complex.Sqrt(funarg);
                case "ln": return Complex.Log(funarg);
                case "cbrt": return Complex.Pow(funarg,1.0/3.0);


                default:
                    break;
            }
            // ����Ҫ�׳��쳣
            throw new ScannerError(string.Format("û��ʶ��ĺ���:{0}", funName));
            //return Complex.Zero;
        }

        public Complex fun2(string funName, Complex funarg1, Complex funarg2)
        {
            Complex tmp;
            switch (funName)
            {
                case "log":return Complex.Log(funarg1) / Complex.Log(funarg2); // ���׹�ʽ��
                default:
                    break;
            }
            // ����Ҫ�׳��쳣
            throw new ScannerError(string.Format("û��ʶ��ĺ���:{0}", funName));
            //return Complex.Zero;
        }

        public void setReg(string regname, Complex value)
        {
            REG[regname] = value;
        }

        public Complex getReg(string regname)
        {
            if (REG.ContainsKey(regname))
            {
                return REG[regname];
            }
            // TODO ����Ҫ�׳��쳣
            return Complex.Zero;
        }

        public Complex getResult()
        {
            return _result;
        }
    }
}
