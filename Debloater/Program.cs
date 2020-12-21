using System;
using System.Diagnostics;

namespace Debloater
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console Appearance
            Console.Title = "Debloater Console";
            Console.ForegroundColor = ConsoleColor.Green;


            // Warning String
            string warn = "WARNING This may destroy your windows install. Please do not use this if your a beginner with Powershell or VM's" ;
            Console.WriteLine("Welcome to the Windows Debloater Console!");
            Console.WriteLine("This will debloat Windows 10 on your PC or VM");
            Console.WriteLine("This can Destroy your install if you are not careful");
            // Confirmation
            Console.WriteLine(warn);
            Console.Write("Are You Sure You want to do this Destructive Action THIS CANNOT BE UNDONE. Type true or false to confirm or deny:");
            bool yorn = Convert.ToBoolean (Console.ReadLine());

            if (yorn == true);
            {

                Process.Start(@"powershell.exe", @"/c " + "");

            }


        }
    }
}
