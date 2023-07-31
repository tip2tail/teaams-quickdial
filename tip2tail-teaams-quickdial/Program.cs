using System.Diagnostics;
using tip2tail_teaams_quickdial.Classes;

namespace tip2tail_teaams_quickdial
{
    internal static class Program
    {

        public static string AppPath { get; private set; }
        public static string AppExe { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            AppExe = Application.ExecutablePath;
            AppPath = Path.GetDirectoryName(AppExe);

            AppSettings.Init();

            // Make the call!
            if (args.Length == 2)
            {
                // Time to make a call
                if (args[0] == "--make-call")
                {
                    Process.Start(new ProcessStartInfo()
                    {
                        UseShellExecute = true,
                        FileName = $"msteams:/l/call/0/0?users={args[1]}&withVideo=true&suppressPrompt=true"
                    });
                    Thread.Sleep(500);
                    Application.Exit();
                }
            }
            else
            {
                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
                ApplicationConfiguration.Initialize();
                Application.Run(new MainForm());
            }
        }
    }
}