using System;

namespace dotNet_Core_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("dotNet Core Test");
            init();
            EnvironmentRun();
            Console.ReadKey(true);
        }

        static void ColorPrintln(string name, string data)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("{0}: ", name);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("{0}", data);
            Console.ResetColor();
            Console.WriteLine();
        }

        static void TitlePrintln(string title)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(title);
            Console.ResetColor();
        }

        static void EnvironmentRun()
        {
            TitlePrintln("[Environment]");
            ColorPrintln("Environment.CommandLine", Environment.CommandLine);
            ColorPrintln("Environment.CurrentDirectory", Environment.CurrentDirectory);
            ColorPrintln("Environment.CurrentManagedThreadId", Environment.CurrentManagedThreadId.ToString());
            ColorPrintln("Environment.ExitCode", Environment.ExitCode.ToString());
            ColorPrintln("Environment.HasShutdownStarted", Environment.HasShutdownStarted.ToString());
            ColorPrintln("Environment.Is64BitOperatingSystem", Environment.Is64BitOperatingSystem.ToString());
            ColorPrintln("Environment.Is64BitProcess", Environment.Is64BitProcess.ToString());
            ColorPrintln("Environment.MachineName", Environment.MachineName);
            ColorPrintln("Environment.NewLine", Environment.NewLine);
            ColorPrintln("Environment.OSVersion", Environment.OSVersion.ToString());
            ColorPrintln("Environment.ProcessorCount", Environment.ProcessorCount.ToString());
            //ColorPrintln("Environment.StackTrace", Environment.StackTrace);
            ColorPrintln("Environment.SystemDirectory", Environment.SystemDirectory);
            ColorPrintln("Environment.SystemPageSize", Environment.SystemPageSize.ToString());
            ColorPrintln("Environment.TickCount", Environment.TickCount.ToString());
            ColorPrintln("Environment.UserDomainName", Environment.UserDomainName);
            ColorPrintln("Environment.UserInteractive", Environment.UserInteractive.ToString());
            ColorPrintln("Environment.UserName", Environment.UserName.ToString());
            ColorPrintln("Environment.Version", Environment.Version.ToString());
            ColorPrintln("Environment.WorkingSet", Environment.WorkingSet.ToString());
            TitlePrintln("[Environment.SpecialFolder]");
            // https://zenmai.wordpress.com/2009/11/11/enum%E3%81%AE%E3%82%A2%E3%82%A4%E3%83%86%E3%83%A0%E3%82%92foreach%E3%81%A7%E4%BD%BF%E3%81%86%E3%80%8Cc/
            foreach (Environment.SpecialFolder v in Enum.GetValues(typeof(Environment.SpecialFolder))) {
                ColorPrintln("Environment.SpecialFolder." + v.ToString(), Environment.GetFolderPath(v));
                /*
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Environment.SpecialFolder.{0}: ", v.ToString());
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("{0}", Environment.GetFolderPath(v));
                Console.ResetColor();
                Console.WriteLine();
                */
            }
            TitlePrintln("[Environment.GetLogicalDrives()]");
            string drives = string.Empty;
            foreach (string s in Environment.GetLogicalDrives())
                drives += s + " ";
            ColorPrintln("Drive", drives);
        }

        static void init()
        {
            // http://www.patorjk.com/software/taag/#p=display&f=Doom&t=.NET%20Core%20Test
            string[] title = {
                @"   _   _  _____ _____   _____                  _____         _   ",
                @"  | \ | ||  ___|_   _| /  __ \                |_   _|       | |  ",
                @"  |  \| || |__   | |   | /  \/ ___  _ __ ___    | | ___  ___| |_ ",
                @"  | . ` ||  __|  | |   | |    / _ \| '__/ _ \   | |/ _ \/ __| __|",
                @" _| |\  || |___  | |   | \__/\ (_) | | |  __/   | |  __/\__ \ |_ ",
                @"(_)_| \_/\____/  \_/    \____/\___/|_|  \___|   \_/\___||___/\__|",
                @"                                                                 "
            };

            Console.ForegroundColor = ConsoleColor.White;
            foreach (string s in title)
                Console.WriteLine(s);
            Console.ResetColor();
        }
    }
}
