using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintingManagement
{
    public partial class PrintingManagement : Form
    {
        string namePrinterSelected = "";
        List<String> namePrinters = new List<string>();
        public PrintingManagement()
        {
            InitializeComponent();
        }

        private void PrintingManagement_Load(object sender, EventArgs e)
        {
            this.Hide();
            ExecuteCommand("sc config spooler start= auto");
            ExecuteCommand("net stop spooler");
            ExecuteCommand("del %systemroot%\\System32\\spool\\printers\\* /Q");
            ExecuteCommand("net start spooler");
            DialogResult result = MessageBox.Show("Reset máy in thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.OK)
                Application.Exit();
        }

        public static void ExecuteCommand(string command)
        {
            string cmdLine = $"/C {command}";
            Process p = new Process();
            p.StartInfo.FileName = "CMD.exe";
            p.StartInfo.Arguments = cmdLine;
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.Start();

        }
    }
}
