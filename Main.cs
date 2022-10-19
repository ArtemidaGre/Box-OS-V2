using System;
using System.Threading;

class OnStart
{
    static void Main()
    {
        Log_in();
        Console.WriteLine("to finish program print any key");
        Console.ReadKey();
    }
    static void Log_in()
    {
        string login, password;
        bool whilet, wand = true;
        while (true & wand)
        {
            Console.Write("enter login\n>");
            login = Console.ReadLine();
            if (login == "OS") { OS.System.main(); };
            Console.Write("enter password\n>");
            password = Console.ReadLine();
            if (login == "box" & password == "8246")
            {
               Console.Write("Hi, ArtaWWod!\nCommands:\n1) OS\n2) restart\n3) test funk\n4) clear\n5) end\n>>>");
                string command;
                whilet = true;
                while (whilet)
                {
                    command = Console.ReadLine();
                    if (command == "OS" | command == "os" | command == "1") { OS.System.main(); whilet = false; }
                    else if (command == "restart" | command == "2") { whilet = false; }
                    else if (command == "test funk" | command == "3") { Console.WriteLine("none"); whilet = false; }
                    else if (command == "clear" | command == "4") { Console.Clear(); }
                    else if (command == "end" | command == "5") { whilet = false; wand = false; }
                    else { Console.Write("Commands:\n1) OS\n2) restart\n3) test funk\n4) clear\n5) end\n>>>"); }

                }
            }
            else if (login == "guest" & password == "guest")
            {
                Console.WriteLine("Hi, guest, now you can start only Box OS :)\nNow I start Box OS");
                OS.System.main();
                Thread.Sleep(1000);
            }
        }
    }
}