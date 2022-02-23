using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome to the first setup, sorry to intrude we'll complete the setup for the client momentarily! \n");
            System.Threading.Thread.Sleep(5000);
            Console.Write("Getting the registry to be able to launch the client through the website..");
            Process regeditProcess = Process.Start("regedit.exe", "/s authentication.reg");
            regeditProcess.WaitForExit();
            System.Threading.Thread.Sleep(100);
            Console.Write("We were able to load a additional process after, assuming the registry was complete." +
                "If there was an error we should see it later on");

            //Process.Start("notepad", "readme.txt");

            string winpath = Environment.GetEnvironmentVariable("windir");
            string path = System.IO.Path.GetDirectoryName(
                          System.Windows.Forms.Application.ExecutablePath);

            /*
            Process.Start(winpath + @"\Microsoft.NET\Framework\v1.0.3705\Installutil.exe",
            path + "\\client.exe");
            */
            Process.Start("C:\.exe")

            /*
            string directory = @"C:\Program Files (x86)\key.reg";
            Process regeditProcess = Process.Start("regedit.exe", "/s \"" + directory + "\"");
            regeditProcess.WaitForExit();
            */

            // youre not going anywhere you bastard!
        }
    }
}
