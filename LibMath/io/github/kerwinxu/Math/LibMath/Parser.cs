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
        public Complex Parse(string s)
        {
            libMathParser.Parse(s+"\n");
            return libMathParser.getResult();
        }




        /// <summary>
        /// 是否是角度，true：角度，false：弧度。
        /// </summary>
        public bool isAngle { get { return libMathParser.isAngle; } set { libMathParser.isAngle = value; } }

        /// <summary>
        /// 寄存器。
        /// </summary>
        public Dictionary<string, Complex> REG { get { return libMathParser.REG; } set { libMathParser.REG = value; } }

    }
}
