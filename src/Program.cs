using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PdfFieldNameStamper
{
    static class Program
    {
        [DllImport("kernel32.dll")]
        private static extern bool AttachConsole(int pid);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool FreeConsole();

        [STAThread]
        static void Main()
        {
            var args = Environment.GetCommandLineArgs().ToList();
            if (args.Count > 1)
            {
                AttachConsole(-1);
                ConsoleRunner.Run(args);
                FreeConsole();
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
