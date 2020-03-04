using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace SwitchParsecConnection
{
    class RebootParsec
    {

        public static bool AfterConfigureKillParsec()
        {
            try
            {
                Process[] p = Process.GetProcessesByName("parsecd");
                foreach (Process parsec in p)
                {
                    if (parsec.ProcessName.ToLower().Contains("parsecd"))
                    {
                        parsec.Kill();
                        parsec.WaitForExit();
                    }
                }
                return true;
            }

            catch (Exception e)
            {
                return false;
            }
        }

        public static string BootupParsec()
        {
            try
            {
                if (AfterConfigureKillParsec())
                {
                    //wait for 3 seconds.
                    System.Threading.Thread.Sleep(3000);
                    System.Diagnostics.Process.Start(@""+Properties.Resources.ParsecInstallLocation+"");
                    return "Restart Parsec success with new settings.";
                }
                else
                {
                    return "Cannot end parsecd task, please check with Admin.";
                }
            }

            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
