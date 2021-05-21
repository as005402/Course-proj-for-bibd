
namespace Inventory.reportForms
{
    partial class Form14
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
            this.reportonstockBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryDataSet = new Inventory.inventoryDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportonstockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.report_on_stockTableAdapter = new Inventory.inventoryDataSetTableAdapters.report_on_stockTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reportonstockBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportonstockBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportonstockBindingSource1
            // 
            this.reportonstockBindingSource1.DataMember = "report_on_stock";
            this.reportonstockBindingSource1.DataSource = this.inventoryDataSet;
            // 
            // inventoryDataSet
            // 
            this.inventoryDataSet.DataSetName = "inventoryDataSet";
            this.inventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.reportonstockBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Inventory.report.Report7.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, -1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(799, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportonstockBindingSource
            // 
            this.reportonstockBindingSource.DataMember = "report_on_stock";
            this.reportonstockBindingSource.DataSource = this.inventoryDataSet;
            // 
            // report_on_stockTableAdapter
            // 
            this.report_on_stockTableAdapter.ClearBeforeFill = true;
            // 
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form14";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Form14_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportonstockBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportonstockBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private inventoryDataSet inventoryDataSet;
        private System.Windows.Forms.BindingSource reportonstockBindingSource;
        private inventoryDataSetTableAdapters.report_on_stockTableAdapter report_on_stockTableAdapter;
        private System.Windows.Forms.BindingSource reportonstockBindingSource1;
    }
}