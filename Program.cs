using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xps2pdf.Properties;

namespace Xps2pdf
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                HelpYa();
                return;
            }
            PdfSharp.Xps.XpsConverter.Convert(args[0], args[1], 0);
        }

        private static void HelpYa()
        {
            Console.Error.Write(Resources.Usage);
            Environment.ExitCode = 1;
        }
    }
}
