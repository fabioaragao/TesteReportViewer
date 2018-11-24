namespace TesteReportViewer
{
    partial class frmRelatorio
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.AdventureWorks2008R2DataSet = new TesteReportViewer.AdventureWorks2008R2DataSet();
            this.ContactTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ContactTypeTableAdapter = new TesteReportViewer.AdventureWorks2008R2DataSetTableAdapters.ContactTypeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.AdventureWorks2008R2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.ContactTypeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TesteReportViewer.Relatorio.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(772, 397);
            this.reportViewer1.TabIndex = 0;
            // 
            // AdventureWorks2008R2DataSet
            // 
            this.AdventureWorks2008R2DataSet.DataSetName = "AdventureWorks2008R2DataSet";
            this.AdventureWorks2008R2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ContactTypeBindingSource
            // 
            this.ContactTypeBindingSource.DataMember = "ContactType";
            this.ContactTypeBindingSource.DataSource = this.AdventureWorks2008R2DataSet;
            // 
            // ContactTypeTableAdapter
            // 
            this.ContactTypeTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 397);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRelatorio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AdventureWorks2008R2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactTypeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ContactTypeBindingSource;
        private AdventureWorks2008R2DataSet AdventureWorks2008R2DataSet;
        private AdventureWorks2008R2DataSetTableAdapters.ContactTypeTableAdapter ContactTypeTableAdapter;
    }
}