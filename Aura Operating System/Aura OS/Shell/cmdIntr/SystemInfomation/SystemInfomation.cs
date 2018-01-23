﻿/*
* PROJECT:          Aura Operating System Development
* CONTENT:          Command Interpreter - SystemInfomation
* PROGRAMMER(S):    John Welsh <djlw78@gmail.com>
*/

using L = Aura_OS.System.Translation;

namespace Aura_OS.Shell.cmdIntr.SystemInfomation
{
    class SystemInfomation
    {
        private static string HelpInfo = "";

        /// <summary>
        /// Getter and Setters for Help Info.
        /// </summary>
        public static string HI
        {
            get { return HelpInfo; }
            set { HelpInfo = value; /*PUSHED OUT VALUE (in)*/}
        }

        /// <summary>
        /// Empty constructor. (Good for debug)
        /// </summary>
        public SystemInfomation() { }

        /// <summary>
        /// c = command, c_SystemInfomation
        /// </summary>
        public static void c_SystemInfomation()
        {
            L.Text.Display("Computername");
            L.Text.Display("OSName");
            L.Text.Display("OSVersion");
            L.Text.Display("OSRevision");
            L.Text.Display("time");
            L.Text.Display("AmountRAM");
            L.Text.Display("safeismodeenabled");
        }
    }
}
