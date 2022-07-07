
namespace gorselfinali
{
    partial class report
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gorselfinalDataSet = new gorselfinali.gorselfinalDataSet();
            this.ZimmetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ZimmetTableAdapter = new gorselfinali.gorselfinalDataSetTableAdapters.ZimmetTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gorselfinalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZimmetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ZimmetBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "gorselfinali.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1311, 590);
            this.reportViewer1.TabIndex = 0;
            // 
            // gorselfinalDataSet
            // 
            this.gorselfinalDataSet.DataSetName = "gorselfinalDataSet";
            this.gorselfinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ZimmetBindingSource
            // 
            this.ZimmetBindingSource.DataMember = "Zimmet";
            this.ZimmetBindingSource.DataSource = this.gorselfinalDataSet;
            // 
            // ZimmetTableAdapter
            // 
            this.ZimmetTableAdapter.ClearBeforeFill = true;
            // 
            // report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 593);
            this.Controls.Add(this.reportViewer1);
            this.Name = "report";
            this.Text = "report";
            this.Load += new System.EventHandler(this.report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gorselfinalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZimmetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ZimmetBindingSource;
        private gorselfinalDataSet gorselfinalDataSet;
        private gorselfinalDataSetTableAdapters.ZimmetTableAdapter ZimmetTableAdapter;
    }
}