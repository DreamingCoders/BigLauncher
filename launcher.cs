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

        }
    }
}

/* og bryckie launcher */
using System.Diagnostics;
class Program
{
    static void Main()
    {
/*
Process.Start("bryckie", "readmbryckie.exe");

string winpath = Environment.GetEnvironmentVariable("windir");
string path = System.IO.Path.GetDirectoryName(
              System.Windows.Forms.Application.ExecutablePath);

Process.Start(winpath + @"\Microsoft.NET\Framework\v1.0.3705\Installutil.exe",
path + "\\MyService.exe");
*/


// Display loader
/*
You are now launching Bryckie. Please wait while we load in your player data
*/

System.Diagnostics.Process.Start( @"C:\Program Files (x86)\Bryckie\bryckie.exe" );
// We dont need to use System.Diagnostics since it's using the scope directly
      //Process.Start("C:\\process.exe");
arguments = "-u", "-csrf";
      
      start.Arguments = arguments;

    }
}
