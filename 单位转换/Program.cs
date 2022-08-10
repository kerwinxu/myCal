using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Xuhengxiao.MyDataStructure;

namespace Calculator
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FrmUnitsConverterCalculator());
            }
            catch (Exception ex)
            {
                ClsErrorFile.WriteLine(ex);

            }

        }
    }
}
