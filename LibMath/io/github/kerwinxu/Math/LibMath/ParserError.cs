using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io.github.kerwinxu.Math.LibMath
{
    /// <summary>
    /// 这个是解析器的异常。
    /// </summary>
    public class ParserError:Exception
    {
        public ParserError() :
            base("默认")
        {

        }

        public ParserError(string message) : base(message) { }
    }
}
