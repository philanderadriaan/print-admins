using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Admins
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (String printer_name in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                ProcessStartInfo info = new ProcessStartInfo();
                info.UseShellExecute = false;
                info.FileName = "SetACL.exe";
                info.Arguments = "-on \""+printer_name+"\" -ot prn -actn list";
                //info.Arguments = "-on \"\\\\dofp\\DO 309 LJ 1320n (Rosson)\" -ot prn -actn ace -ace \"n:NKSD PrintAdmins;p:full\"";
                Process.Start(info);
                //Console.WriteLine(printer_name);
            }
            Console.ReadLine();
        }
    }
}