using System;
using System.Diagnostics;
using System.IO;
namespace Debloater
{
    class Program
    {
        static void Main(string[] args)
        {
            


            string execscript = @".\pack.ps1";




            //Console Appearance
            Console.Title = "Debloater Console";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WindowHeight = 40;

            
            // Warning String
            string warn = "WARNING This may destroy your windows install. Please do not use this if your a beginner with Powershell or VM's" ;
            Console.WriteLine("Welcome to the Windows Debloater Console!");
            Console.WriteLine("This will debloat Windows 10 on your PC or VM");
            Console.WriteLine("This can Destroy your install if you are not careful");
            Console.WriteLine(" This will also set your Execution Policy to Unrestricted");
            // Confirmation
            Console.WriteLine(warn);
            Console.Write("Are You Sure You want to do this Destructive Action THIS CANNOT BE UNDONE. Type true or false to confirm or deny:");
            bool yorn = Convert.ToBoolean (Console.ReadLine());

            // Main Script Exec
            if (yorn == true);
            {
                // Create and start the Script
                Process.Start(@"powershell.exe", @"/c " + "Set-ExecutionPolicy -Scope CurrentUser Unrestricted");

                Process proc = new Process();
                ProcessStartInfo info =
                new ProcessStartInfo(@"powershell.exe", @"/c " + execscript);
                info.UseShellExecute = true;
                info.Verb = "runas";
                proc.StartInfo = info;
                proc.Start();

            }


        }
    }
}
