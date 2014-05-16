using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace Print_Admins
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string printer_name in PrinterSettings.InstalledPrinters)
            {
                ProcessStartInfo info = new ProcessStartInfo();
                info.UseShellExecute = false;
                info.FileName = "SetACL.exe";
                info.Arguments = "-on \"" + printer_name + "\" -ot prn -actn ace -ace \"n:NKSD PrintAdmins;p:full\"";
                Process.Start(info);
            }
        }
    }
}