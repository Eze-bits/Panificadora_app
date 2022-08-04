
namespace Presentacion
{
    partial class ReporteFRM
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TP2DataSet2 = new Presentacion.TP2DataSet2();
            this.HAMBURGUESASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HAMBURGUESASTableAdapter = new Presentacion.TP2DataSet2TableAdapters.HAMBURGUESASTableAdapter();
            this.TP2DataSet3 = new Presentacion.TP2DataSet3();
            this.LACTALBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LACTALTableAdapter = new Presentacion.TP2DataSet3TableAdapters.LACTALTableAdapter();
            this.TP2DataSet4 = new Presentacion.TP2DataSet4();
            this.PANCHOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PANCHOSTableAdapter = new Presentacion.TP2DataSet4TableAdapters.PANCHOSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TP2DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HAMBURGUESASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TP2DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LACTALBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TP2DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PANCHOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.HAMBURGUESASBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.LACTALBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.PANCHOSBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(801, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // TP2DataSet2
            // 
            this.TP2DataSet2.DataSetName = "TP2DataSet2";
            this.TP2DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // HAMBURGUESASBindingSource
            // 
            this.HAMBURGUESASBindingSource.DataMember = "HAMBURGUESAS";
            this.HAMBURGUESASBindingSource.DataSource = this.TP2DataSet2;
            // 
            // HAMBURGUESASTableAdapter
            // 
            this.HAMBURGUESASTableAdapter.ClearBeforeFill = true;
            // 
            // TP2DataSet3
            // 
            this.TP2DataSet3.DataSetName = "TP2DataSet3";
            this.TP2DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LACTALBindingSource
            // 
            this.LACTALBindingSource.DataMember = "LACTAL";
            this.LACTALBindingSource.DataSource = this.TP2DataSet3;
            // 
            // LACTALTableAdapter
            // 
            this.LACTALTableAdapter.ClearBeforeFill = true;
            // 
            // TP2DataSet4
            // 
            this.TP2DataSet4.DataSetName = "TP2DataSet4";
            this.TP2DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PANCHOSBindingSource
            // 
            this.PANCHOSBindingSource.DataMember = "PANCHOS";
            this.PANCHOSBindingSource.DataSource = this.TP2DataSet4;
            // 
            // PANCHOSTableAdapter
            // 
            this.PANCHOSTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteFRM";
            this.Text = "Reporte de stock";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TP2DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HAMBURGUESASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TP2DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LACTALBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TP2DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PANCHOSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource HAMBURGUESASBindingSource;
        private TP2DataSet2 TP2DataSet2;
        private System.Windows.Forms.BindingSource LACTALBindingSource;
        private TP2DataSet3 TP2DataSet3;
        private System.Windows.Forms.BindingSource PANCHOSBindingSource;
        private TP2DataSet4 TP2DataSet4;
        private TP2DataSet2TableAdapters.HAMBURGUESASTableAdapter HAMBURGUESASTableAdapter;
        private TP2DataSet3TableAdapters.LACTALTableAdapter LACTALTableAdapter;
        private TP2DataSet4TableAdapters.PANCHOSTableAdapter PANCHOSTableAdapter;
    }
}