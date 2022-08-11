using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using io.github.kerwinxu.Math.LibMath;

namespace ConsoleAppLibMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Parser parser = new Parser();
            parser.isAngle = true;
            var result = parser.Parse("sin(30)");
            Console.WriteLine(result);
            Console.WriteLine(string.Format("9**0.5:{0}", parser.Parse("9**0.5")));
            Console.WriteLine(string.Format("sin(10+20):{0}", parser.Parse("sin(10+20)")));
            Console.WriteLine(string.Format("asin(0.5):{0}", parser.Parse("asin(0.5)")));
            // 这里用麻烦一点的
            Console.WriteLine(string.Format("log(100,10):{0}", parser.Parse("log(10,100)")));
            // 这里看看寄存器
            parser.REG["AX"] = System.Numerics.Complex.One + System.Numerics.Complex.One;
            Console.WriteLine(string.Format("AX:{0}", parser.Parse("AX")));
            // 看看等号
            Console.WriteLine(string.Format("-2+3={0}", parser.Parse("-2+3=")));
            Console.WriteLine(string.Format("cbrt(27)={0}", parser.Parse("cbrt(27)=")));
            Console.WriteLine(string.Format("EXP={0}", parser.Parse("EXP=")));
            Console.WriteLine(string.Format("ln(EXP)={0}", parser.Parse("ln(EXP)=")));
            Console.Read();
        }
    }
}
