using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Numerics;

namespace io.github.kerwinxu.Math.LibMath
{
    internal partial class LibMathParser
    {
        public LibMathParser() : base(null) { }

        public void Parse(string s)
        {
            byte[] inputBuffer = System.Text.Encoding.Default.GetBytes(s);
            MemoryStream stream = new MemoryStream(inputBuffer);
            this.Scanner = new LibMathScanner(stream);
            this.Parse();
        }

        public  void yyerror(string format, params object[] args)
        {
            Console.WriteLine(format, args);
        }

        public Complex getResult()
        {
            return result;
        }
    }
}
