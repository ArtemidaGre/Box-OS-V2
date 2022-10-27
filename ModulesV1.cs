/*
 * main file for OS module
*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace OS
{
    public class System
    {
        public static void Bios(string TestCom = null, bool IsTested = false)
        {
            Console.WriteLine("Hi, OS is started!\nCommands in <BIOS>:\n1.login\n2.Off\n3.test funk");
            string command;
            while (IsTested != true)
            {
                Console.Write(">BS>>");
                command = Console.ReadLine();
                if (command == "login" | command == "1") { Log_in(); }
                else if (command == "off" | command == "Off" | command == "2") { break; }
                else if (command == "test funk" | command == "test" | command == "3") { Console.WriteLine("none"); }
            }
            Console.Write("Finish :)\nPress any key to close BoxOS\n>/>");
        }
        public static void Startup()
        {
            Console.WriteLine("Starting modules...");
            Thread.Sleep(1150);
            Console.WriteLine("Starting virus...");
            Thread.Sleep(240);
            Console.Clear();
            SysConsole();
        }
        private static void SysConsole(bool IsTest = false)
        {
            string command;
            bool OS_work = true;
            Console.Write("OS started without errors\nvirus was downloaded $)\nto get help print help\n");
            while (IsTest != true & OS_work)
            {
                Console.Write(">c>");
                command = Console.ReadLine();
                if (command == "help") { Help(); }
                else if (command == "help help") { Help("help"); }
                else if (command == "help game") { Help("game"); }
                else if (command == "help delete") { Help("delete"); }
                else if (command == "help clear") { Help("help"); }
                else if (command == "help href") { Help("href"); }
                else if (command == "clear") { Console.Clear(); }
                else if (command == "end") { OS_work = false; }
                else if (command == "delete") { string path; Console.Write("print path to file\n>>>"); path = Console.ReadLine(); FileInfo fileInf = new FileInfo(path); if (fileInf.Exists) { fileInf.Delete(); Console.WriteLine("delete succes"); } }
                else if (command == "game") { Process mYproces = new Process(); mYproces.StartInfo.FileName = "g.exe"; mYproces.Start(); mYproces.WaitForExit(); }
                else if (command == "href") { Console.Write(">"); string href = Console.ReadLine(); Process.Start("cmd", "/C start" + " http://" + href); }
                else if (command == "git") { Process.Start("cmd", "/C start https://github.com/ArtemidaGre"); }
                else if (command == "cmd") { string cmd_command; Console.Write(">cmd>"); cmd_command = Console.ReadLine(); ; Process.Start("cmd", "/C " + cmd_command); }
                else if (command == "open") { try { Process mYproces = new Process(); Console.Write(">"); mYproces.StartInfo.FileName = Console.ReadLine(); mYproces.Start(); mYproces.WaitForExit(); } catch { Console.WriteLine("CMD open ERROR"); } }
                else if (command == "Thread") { AnotherFunk.ThreadTest.twoliner(); }
                else if (command == "color 2") { color("2"); } else if (command == "color 3") { color("3"); } else if (command == "color 4") { color("4"); } else if (command == "color 5") { color("5"); } else if (command == "color 1" | command == "Color 0") { color("1"); }
            }
        }
        public static void Help(string To_help = "main")
        {
            List<string> Commands = new List<string> { "help", "delete", "game", "clear", "end", "href", "cmd", "open", "color {from 1 to 5}" };
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
        private static void color(string ColorForConsole = "1")
        {
            if (ColorForConsole == "2") { Console.ForegroundColor = ConsoleColor.Green; }
            else if (ColorForConsole == "3") { Console.ForegroundColor = ConsoleColor.Yellow; }
            else if (ColorForConsole == "4") { Console.ForegroundColor = ConsoleColor.Red; }
            else if (ColorForConsole == "5") { Console.ForegroundColor = ConsoleColor.Blue; }
            else if (ColorForConsole == "1") { Console.ResetColor(); }
        }
        static void Log_in()
        {
            string login, password;
            bool whilet, wand = true;
            while (wand)
            {
                Console.Write("enter login\n>");
                login = Console.ReadLine();
                if (login == "OS") { OS.System.Bios(); wand = false; };
                Console.Write("enter password\n>");
                password = Console.ReadLine();
                if (login == "box" & password == "8246")
                {
                    users.Box();
                    wand = false;
                }
                else if (login == "guest" & password == "guest")
                {
                    Console.WriteLine("Hi, guest, now you can start only Box OS :)\nNow I start Box OS");
                    OS.System.Bios();
                    Thread.Sleep(1000);
                    wand = false;
                }
            }
        }
    }
    class users
    {
        public static void Box() { bool whilet = true; Console.Write("Hi, ArtaWWod!\nCommands:\n1) OS\n2) restart\n3) test funk\n4) clear\n5) end\n>>>"); string command; while (whilet) { command = Console.ReadLine(); if (command == "OS" | command == "os" | command == "1") { System.Startup(); whilet = false; } else if (command == "restart" | command == "2") { whilet = false; } else if (command == "test funk" | command == "3") { Console.WriteLine("none"); whilet = false; } else if (command == "clear" | command == "4") { Console.Clear(); } else if (command == "end" | command == "5") { whilet = false; } else { Console.Write("Commands:\n1) OS\n2) restart\n3) test funk\n4) clear\n5) end\n>>>"); } } }
    }
    class IsTested
    {
        bool WorkingMain(string command, bool OS_work)
        {
            try{
                Console.Write(">c>");
                if (command == "help") { System.Help(); }
                else if (command == "help help") { System.Help("help"); }
                else if (command == "help game") { System.Help("game"); }
                else if (command == "help delete") { System.Help("delete"); }
                else if (command == "help clear") { System.Help("help"); }
                else if (command == "help href") { System.Help("href"); }
                else if (command == "clear") { Console.Clear(); }
                else if (command == "end") { OS_work = false; }
                else if (command == "href") { Console.Write(">"); string href = Console.ReadLine(); Process.Start("cmd", "/C start" + " http://" + href); }
                else if (command == "git") { Process.Start("cmd", "/C start https://github.com/ArtemidaGre"); }
                else if (command == "cmd") { string cmd_command; Console.Write(">cmd>"); cmd_command = Console.ReadLine(); ; Process.Start("cmd", "/C " + cmd_command); }
                else if (command == "open") { try { Process mYproces = new Process(); Console.Write(">"); mYproces.StartInfo.FileName = Console.ReadLine(); mYproces.Start(); mYproces.WaitForExit(); return true; } catch { Console.WriteLine("CMD open ERROR"); return false; } }
                else if (command == "Thread") { try { AnotherFunk.ThreadTest.twoliner(); return true; } catch { return false; } }
                return true;
            }
            catch { return false; }
        }
    }
}
namespace AnotherFunk
{
    class Internet
    {
        public static void GScom() { Process.Start("cmd", "/C start https://gay-porevo.top/hardcore"); }

    }
    class ThreadTest
    {
        public static void twoliner()
        {
            int Rounds = 0;
            Thread t = new Thread(WriteY);
            t.Start();            // Выполнить WriteY в новом потоке
            while (true)
            {
                Console.Write("x"); // Все время печатать 'x'
                Thread.Sleep(1);
                Rounds++;
                if (Rounds >= 100) { break; }
            }
            Console.WriteLine("\nTread one finished\n");

        }

        static void WriteY()
        {
            int Rounds = 0;
            while (true)
            {
                Console.Write("y"); // Все время печатать 'y'
                Thread.Sleep(1);
                Rounds++;
                if (Rounds >= 100) { break; }
            }
            Console.WriteLine("\nThread 2 finished\n");

        }
    }
}
