
namespace Inventory
{
    partial class Form11
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
            this.suppliesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryDataSet = new Inventory.inventoryDataSet();
            this.report_on_stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.realizationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.stockTableAdapter = new Inventory.inventoryDataSetTableAdapters.stockTableAdapter();
            this.realizationTableAdapter = new Inventory.inventoryDataSetTableAdapters.realizationTableAdapter();
            this.report_on_stockTableAdapter = new Inventory.inventoryDataSetTableAdapters.report_on_stockTableAdapter();
            this.suppliesTableAdapter = new Inventory.inventoryDataSetTableAdapters.suppliesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.suppliesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.report_on_stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realizationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // suppliesBindingSource
            // 
            this.suppliesBindingSource.DataMember = "supplies";
            this.suppliesBindingSource.DataSource = this.inventoryDataSet;
            // 
            // inventoryDataSet
            // 
            this.inventoryDataSet.DataSetName = "inventoryDataSet";
            this.inventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // report_on_stockBindingSource
            // 
            this.report_on_stockBindingSource.DataMember = "report_on_stock";
            this.report_on_stockBindingSource.DataSource = this.inventoryDataSet;
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "stock";
            this.stockBindingSource.DataSource = this.inventoryDataSet;
            // 
            // realizationBindingSource
            // 
            this.realizationBindingSource.DataMember = "realization";
            this.realizationBindingSource.DataSource = this.inventoryDataSet;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.suppliesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Inventory.report.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, -1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(799, 451);
            this.reportViewer1.TabIndex = 0;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // realizationTableAdapter
            // 
            this.realizationTableAdapter.ClearBeforeFill = true;
            // 
            // report_on_stockTableAdapter
            // 
            this.report_on_stockTableAdapter.ClearBeforeFill = true;
            // 
            // suppliesTableAdapter
            // 
            this.suppliesTableAdapter.ClearBeforeFill = true;
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form11";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.suppliesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.report_on_stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realizationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private inventoryDataSet inventoryDataSet;
        private inventoryDataSetTableAdapters.stockTableAdapter stockTableAdapter;
        private System.Windows.Forms.BindingSource realizationBindingSource;
        private inventoryDataSetTableAdapters.realizationTableAdapter realizationTableAdapter;
        private System.Windows.Forms.BindingSource report_on_stockBindingSource;
        private inventoryDataSetTableAdapters.report_on_stockTableAdapter report_on_stockTableAdapter;
        private System.Windows.Forms.BindingSource suppliesBindingSource;
        private inventoryDataSetTableAdapters.suppliesTableAdapter suppliesTableAdapter;
    }
}