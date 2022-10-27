using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;


class MainThread
{
    public static void ThreadOne()
    {
        Thread Main = new(ThreadTwo);
    }
    public static void ThreadTwo()
    {
        
    }
}