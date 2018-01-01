﻿using System;

namespace dotNet_Core_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dotNet Core Test");
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

        static void EnvironmentRun()
        {
            Console.WriteLine("[Environment]");
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
            Console.WriteLine("[Environment.SpecialFolder]");
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
            Console.WriteLine("[Environment.GetLogicalDrives()]");
            string drives = string.Empty;
            foreach (string s in Environment.GetLogicalDrives())
                drives += s + " ";
            ColorPrintln("Drive", drives);
        }

        
    }
}
