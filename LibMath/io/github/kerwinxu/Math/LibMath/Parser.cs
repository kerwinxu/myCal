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
        public Complex Parse(string s)
        {
            LibMathParser libMathParser = new LibMathParser();
            libMathParser.Parse(s);
            return libMathParser.getResult();
        }
    }
}
