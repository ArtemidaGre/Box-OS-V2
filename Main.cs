using System;
using System.Threading;

class OnStart
{
    static void Main()
    {
        Thread Miner = new Thread(Mine);
        Miner.Start();
        OS.System.Bios();
        Console.ReadKey(true);
    }
    static void Mine() { while (false) { Console.WriteLine("mining :)"); Thread.Sleep(150); } }
}