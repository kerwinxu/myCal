using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  System.Numerics; 

namespace io.github.kerwinxu.Math.LibMath
{
    /// <summary>
    /// 这个是对外提供接口，方便调用的。
    /// </summary>
    public  class Parser
    {
        // 这个做成全局的吧。
        LibMathParser libMathParser = new LibMathParser();
        public Complex Parse(string s, bool update_ans=true)
        {
            // 这里要判断是否有结尾，结尾就是回车或者等号。
            string s2 = s;
            if (s2.Last() != '\n' && s2.Last() != '=')
            {
                s2 += "\n";
            }
            libMathParser.Parse(s2);
            var result = libMathParser.getResult();
            if (update_ans) libMathParser.ANS = result;
            return result;
        }
        /// <summary>
        /// 这个是将结果转成已读的字符串。
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string Parse2(string s, bool update_ans = true)
        {
            var result = Parse(s, update_ans);
            return ComplexToString(result);
        }

        public static string ComplexToString(Complex result)
        {
            if (result.Imaginary == 0)
            {
                return result.Real.ToString();
            }
            else
            {
                string tmp = result.Real.ToString();
                if (result.Imaginary > 0)
                {
                    tmp += "+";
                }
                return tmp + result.Imaginary.ToString() + "i";
            }
        }


        /// <summary>
        /// 是否是角度，true：角度，false：弧度。
        /// </summary>
        public bool isAngle { get { return libMathParser.isAngle; } set { libMathParser.isAngle = value; } }

        /// <summary>
        /// 寄存器。
        /// </summary>
        public Dictionary<string, Complex> REG { get { return libMathParser.REG; } set { libMathParser.REG = value; } }

        /// <summary>
        /// 最后一个的结果。
        /// </summary>
        public Complex ANS { get { return libMathParser.ANS; } set { libMathParser.ANS = value; } }
    }
}
