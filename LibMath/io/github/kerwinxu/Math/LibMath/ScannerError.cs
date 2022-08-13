using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io.github.kerwinxu.Math.LibMath
{
    /// <summary>
    /// 扫描器的异常
    /// </summary>
    public class ScannerError:Exception
    {
        public ScannerError():
            base("默认")
        {

        }

        public ScannerError(string message) : base(message) { }
    }
}
