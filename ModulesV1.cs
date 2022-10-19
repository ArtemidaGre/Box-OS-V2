/*
 * main file for OS module
*/

using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Drawing;
using System.Net;
using Windows.System.UserProfile;
using System.Threading.Tasks;
using Windows.Storage;

namespace OS
{
    class System
    {
        public static void main()
        {
            Console.WriteLine("starting OS");
            Startup();
        }
        private static void Startup()
        {
            string command;
            bool OS_work = true;
            Console.WriteLine("Starting modules...");
            Thread.Sleep(3854);
            Console.WriteLine("Starting virus...");
            Thread.Sleep(1282);
            Console.Write("OS started without errors\nvirus was downloaded $)\nto get help print help\n");
            while (true & OS_work)
            {
                Console.Write(">>>");
                command = Console.ReadLine();
                if (command == "help") { Help(); }
                else if (command == "help help") { Help("help"); }
                else if (command == "help game") { Help("game"); }
                else if (command == "help delete") { Help("delete"); }
                else if (command == "help clear") { Help("help"); }
                else if (command == "help href") { Help("href"); }
                else if (command == "clear") { Console.Clear(); }
                else if (command == "end") { OS_work = false; }
                else if (command == "delete")
                {
                    string path;
                    Console.Write("print path to file\n>>>");
                    path = Console.ReadLine();
                    FileInfo fileInf = new FileInfo(path);
                    if (fileInf.Exists)
                    {
                        fileInf.Delete();
                        Console.WriteLine("delete succes");
                    }
                }
                else if (command == "game")
                {
                    Process mYproces = new Process();
                    mYproces.StartInfo.FileName = "g.exe";
                    mYproces.Start();
                    mYproces.WaitForExit();
                }
                else if (command == "href")
                {
                    Console.Write(">");
                    string href = Console.ReadLine();
                    Process.Start("cmd", "/C start" + " http://" + href);
                }
                else if (command == "git")
                {
                    Process.Start("cmd", "/C start https://github.com/ArtemidaGre");
                }
            }
        }
        private static void Help(string To_help = "main")
        {
            List<string> Commands = new List<string> { "help", "delete", "game", "clear", "end", "href" };
            if (To_help == "main")
            {
                Console.WriteLine("Command list:");
                foreach (string item in Commands)
                    Console.WriteLine(item);
                Console.WriteLine("example of help command >>> help <name of command>");
            }
            else if (To_help == "help") { Console.WriteLine("this command will help you understand commands in the command list :)"); }
            else if (To_help == "delete") { Console.WriteLine("this command will delete files on path, that you enter to console."); }
            else if (To_help == "game") { Console.WriteLine("this command will activate the game"); }
            else if (To_help == "clear") { Console.WriteLine("this command will clear the console"); }
            else if (To_help == "href") { Console.WriteLine("print the site ip or name, and it will start it :)"); }
        }
    }
}