namespace QuoteEntry.PopUp
{
    partial class frmQuotePrint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuotePrint));
            this.rpt = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpt
            // 
            this.rpt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpt.Location = new System.Drawing.Point(20, 60);
            this.rpt.Name = "ReportViewer";
            this.rpt.ServerReport.BearerToken = null;
            this.rpt.ServerReport.DisplayName = "Cotización";
            this.rpt.ServerReport.ReportServerUrl = new System.Uri("http://toruk/Reports/Pages/Report.aspx?ItemPath=%2freports%2fCustomReports%2fQuot" +
        "eReports.rdl", System.UriKind.Absolute);
            this.rpt.Size = new System.Drawing.Size(760, 370);
            this.rpt.TabIndex = 0;
            // 
            // frmQuotePrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQuotePrint";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Cotización Nº: ";
            this.Load += new System.EventHandler(this.frmQuotePrint_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer rpt;
    }
}