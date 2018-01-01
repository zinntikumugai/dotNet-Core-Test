using System;

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

        static void EnvironmentRun()
        {
            Console.WriteLine("[Environment]");
            Console.WriteLine("CommandLine: {0}", Environment.CommandLine);
            Console.WriteLine("CurrentDirectory: {0}", Environment.CurrentDirectory);
            Console.WriteLine("CurrentManagedThreadId: {0}", Environment.CurrentManagedThreadId);
            Console.WriteLine("ExitCode: {0}", Environment.ExitCode);
            Console.WriteLine("HasShutdownStarted: {0}", Environment.HasShutdownStarted);
            Console.WriteLine("Is64BitOperatingSystem: {0}", Environment.Is64BitOperatingSystem);
            Console.WriteLine("Is64BitProcess: {0}", Environment.Is64BitProcess);
            Console.WriteLine("MachineName: {0}", Environment.MachineName);
            Console.WriteLine("NewLine: {0}", Environment.NewLine);
            Console.WriteLine("OSVersion: {0}", Environment.OSVersion);
            Console.WriteLine("ProcessorCount: {0}", Environment.ProcessorCount);
            Console.WriteLine("StackTrace: {0}", Environment.StackTrace);
            Console.WriteLine("SystemDirectory: {0}", Environment.SystemDirectory);
            Console.WriteLine("SystemPageSize: {0}", Environment.SystemPageSize);
            Console.WriteLine("TickCount: {0}", Environment.TickCount);
            Console.WriteLine("UserDomainName: {0}", Environment.UserDomainName);
            Console.WriteLine("UserInteractive: {0}", Environment.UserInteractive);
            Console.WriteLine("UserName: {0}", Environment.UserName);
            Console.WriteLine("Version: {0}", Environment.Version);
            Console.WriteLine("WorkingSet: {0}", Environment.WorkingSet);
            Console.WriteLine("[Environment.SpecialFolder]");
            foreach (Environment.SpecialFolder v in Enum.GetValues(typeof(Environment.SpecialFolder))) {
                Console.WriteLine("Environment.SpecialFolder.{0}: {1}", v.ToString(),Environment.GetFolderPath(v));
            }
            Console.Write("Drive: ");
            foreach (string s in Environment.GetLogicalDrives())
                Console.Write("{0} ,", s);
            Console.WriteLine();
        }

        
    }
}
