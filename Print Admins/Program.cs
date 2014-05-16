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
    class Program : System.Windows.Forms.Form
    {
        static void Main()
        {
            Application.EnableVisualStyles();

            foreach (string printer_name in PrinterSettings.InstalledPrinters)
            {
                ProcessStartInfo info = new ProcessStartInfo();
                info.UseShellExecute = false;
                info.FileName = "SetACL.exe";
                info.Arguments = "-on \"" + printer_name + "\" -ot prn -actn ace -ace \"n:NKSD PrintAdmins;p:full\"";
                Process.Start(info);
            }

            Application.Run(new Program());
        }
    }
}