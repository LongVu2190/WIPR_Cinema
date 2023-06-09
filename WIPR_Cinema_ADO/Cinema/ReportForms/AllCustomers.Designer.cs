﻿namespace Cinema.ReportForms
{
    partial class AllCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllCustomers));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.viewAllCustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cinemaDataSet = new Cinema.CinemaDataSet();
            this.view_AllCustomersTableAdapter = new Cinema.CinemaDataSetTableAdapters.View_AllCustomersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.viewAllCustomersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "AllCustomers";
            reportDataSource1.Value = this.viewAllCustomersBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Cinema.Reports.AllCustomers.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1155, 426);
            this.reportViewer1.TabIndex = 0;
            // 
            // viewAllCustomersBindingSource
            // 
            this.viewAllCustomersBindingSource.DataMember = "View_AllCustomers";
            this.viewAllCustomersBindingSource.DataSource = this.cinemaDataSet;
            // 
            // cinemaDataSet
            // 
            this.cinemaDataSet.DataSetName = "CinemaDataSet";
            this.cinemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_AllCustomersTableAdapter
            // 
            this.view_AllCustomersTableAdapter.ClearBeforeFill = true;
            // 
            // AllCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AllCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All Customers";
            this.Load += new System.EventHandler(this.AllCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewAllCustomersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private CinemaDataSet cinemaDataSet;
        private System.Windows.Forms.BindingSource viewAllCustomersBindingSource;
        private CinemaDataSetTableAdapters.View_AllCustomersTableAdapter view_AllCustomersTableAdapter;
    }
}