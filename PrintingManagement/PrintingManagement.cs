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
            ReloadPrinter();
        }

        private void btnCheckQueuePrinting_Click(object sender, EventArgs e)
        {
            if (namePrinters.Count <= 0) return;

            Process.Start(@"C:\Users\Administrator\source\repos\PrintingManagement\PrintingManagement\runQueue.bat", namePrinterSelected);
        }

        private void cboPrinterName_ValueMemberChanged(object sender, EventArgs e)
        {
            namePrinterSelected = cboPrinterName.Text;
        }

        private void cboPrinterName_TextChanged(object sender, EventArgs e)
        {
            namePrinterSelected = "\"" + cboPrinterName.Text + "\"";
        }

        private void btnReloadPrinter_Click(object sender, EventArgs e)
        {
            ReloadPrinter();
        }

        void ReloadPrinter()
        {
            try
            {
                foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
                {
                    namePrinters.Add(printer);
                }
                cboPrinterName.DataSource = namePrinters;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Khong tim thay may in, hoac kiem tra services may in da bat chua");
            }
        }
    }
}
