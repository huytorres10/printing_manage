
namespace PrintingManagement
{
    partial class PrintingManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboPrinterName = new System.Windows.Forms.ComboBox();
            this.btnCheckQueuePrinting = new System.Windows.Forms.Button();
            this.btnReloadPrinter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboPrinterName
            // 
            this.cboPrinterName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPrinterName.FormattingEnabled = true;
            this.cboPrinterName.Location = new System.Drawing.Point(31, 31);
            this.cboPrinterName.Name = "cboPrinterName";
            this.cboPrinterName.Size = new System.Drawing.Size(229, 21);
            this.cboPrinterName.TabIndex = 0;
            this.cboPrinterName.ValueMemberChanged += new System.EventHandler(this.cboPrinterName_ValueMemberChanged);
            this.cboPrinterName.TextChanged += new System.EventHandler(this.cboPrinterName_TextChanged);
            // 
            // btnCheckQueuePrinting
            // 
            this.btnCheckQueuePrinting.Location = new System.Drawing.Point(31, 74);
            this.btnCheckQueuePrinting.Name = "btnCheckQueuePrinting";
            this.btnCheckQueuePrinting.Size = new System.Drawing.Size(275, 47);
            this.btnCheckQueuePrinting.TabIndex = 1;
            this.btnCheckQueuePrinting.Text = "Check Queue Printing";
            this.btnCheckQueuePrinting.UseVisualStyleBackColor = true;
            this.btnCheckQueuePrinting.Click += new System.EventHandler(this.btnCheckQueuePrinting_Click);
            // 
            // btnReloadPrinter
            // 
            this.btnReloadPrinter.BackgroundImage = global::PrintingManagement.Properties.Resources.reload;
            this.btnReloadPrinter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReloadPrinter.ImageKey = "(none)";
            this.btnReloadPrinter.Location = new System.Drawing.Point(268, 22);
            this.btnReloadPrinter.Name = "btnReloadPrinter";
            this.btnReloadPrinter.Size = new System.Drawing.Size(38, 40);
            this.btnReloadPrinter.TabIndex = 2;
            this.btnReloadPrinter.UseVisualStyleBackColor = true;
            this.btnReloadPrinter.Click += new System.EventHandler(this.btnReloadPrinter_Click);
            // 
            // PrintingManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 183);
            this.Controls.Add(this.btnReloadPrinter);
            this.Controls.Add(this.btnCheckQueuePrinting);
            this.Controls.Add(this.cboPrinterName);
            this.Name = "PrintingManagement";
            this.Text = "Printing Management";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.PrintingManagement_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboPrinterName;
        private System.Windows.Forms.Button btnCheckQueuePrinting;
        private System.Windows.Forms.Button btnReloadPrinter;
    }
}

