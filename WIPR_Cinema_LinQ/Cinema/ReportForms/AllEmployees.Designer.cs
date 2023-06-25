namespace Cinema.ReportForms
{
    partial class AllEmployees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllEmployees));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cinemaDataSet = new Cinema.CinemaDataSet();
            this.viewAllEmployeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_AllEmployeesTableAdapter = new Cinema.CinemaDataSetTableAdapters.View_AllEmployeesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewAllEmployeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "AllEmployees";
            reportDataSource1.Value = this.viewAllEmployeesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Cinema.Reports.AllEmployees.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1130, 426);
            this.reportViewer1.TabIndex = 0;
            // 
            // cinemaDataSet
            // 
            this.cinemaDataSet.DataSetName = "CinemaDataSet";
            this.cinemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewAllEmployeesBindingSource
            // 
            this.viewAllEmployeesBindingSource.DataMember = "View_AllEmployees";
            this.viewAllEmployeesBindingSource.DataSource = this.cinemaDataSet;
            // 
            // view_AllEmployeesTableAdapter
            // 
            this.view_AllEmployeesTableAdapter.ClearBeforeFill = true;
            // 
            // AllEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AllEmployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All Employees";
            this.Load += new System.EventHandler(this.AllEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewAllEmployeesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private CinemaDataSet cinemaDataSet;
        private System.Windows.Forms.BindingSource viewAllEmployeesBindingSource;
        private CinemaDataSetTableAdapters.View_AllEmployeesTableAdapter view_AllEmployeesTableAdapter;
    }
}