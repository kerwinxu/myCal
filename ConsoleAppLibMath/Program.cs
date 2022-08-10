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
            var result = parser.Parse("1+2\n");
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
