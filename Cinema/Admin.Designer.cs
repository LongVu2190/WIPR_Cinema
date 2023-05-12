namespace Cinema
{
    partial class Admin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataView = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Views = new System.Windows.Forms.ToolStripDropDownButton();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showingTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.ADDBUTT = new System.Windows.Forms.Button();
            this.DELETE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataView
            // 
            this.DataView.AllowUserToDeleteRows = false;
            this.DataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataView.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataView.Location = new System.Drawing.Point(9, 28);
            this.DataView.Margin = new System.Windows.Forms.Padding(2);
            this.DataView.Name = "DataView";
            this.DataView.RowHeadersWidth = 51;
            this.DataView.RowTemplate.Height = 24;
            this.DataView.Size = new System.Drawing.Size(942, 503);
            this.DataView.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Views,
            this.toolStripComboBox1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(960, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Views
            // 
            this.Views.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Views.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customersToolStripMenuItem,
            this.showingTimeToolStripMenuItem,
            this.moviesToolStripMenuItem,
            this.reservationsToolStripMenuItem,
            this.employeesToolStripMenuItem});
            this.Views.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Views.Name = "Views";
            this.Views.Size = new System.Drawing.Size(60, 24);
            this.Views.Text = "Views";
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.customersToolStripMenuItem.Text = "Customers";
            this.customersToolStripMenuItem.Click += new System.EventHandler(this.customersToolStripMenuItem_Click);
            // 
            // showingTimeToolStripMenuItem
            // 
            this.showingTimeToolStripMenuItem.Name = "showingTimeToolStripMenuItem";
            this.showingTimeToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.showingTimeToolStripMenuItem.Text = "Showing Time";
            this.showingTimeToolStripMenuItem.Click += new System.EventHandler(this.showingTimeToolStripMenuItem_Click);
            // 
            // moviesToolStripMenuItem
            // 
            this.moviesToolStripMenuItem.Name = "moviesToolStripMenuItem";
            this.moviesToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.moviesToolStripMenuItem.Text = "Movies";
            this.moviesToolStripMenuItem.Click += new System.EventHandler(this.moviesToolStripMenuItem_Click);
            // 
            // reservationsToolStripMenuItem
            // 
            this.reservationsToolStripMenuItem.Name = "reservationsToolStripMenuItem";
            this.reservationsToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.reservationsToolStripMenuItem.Text = "Reservations";
            this.reservationsToolStripMenuItem.Click += new System.EventHandler(this.reservationsToolStripMenuItem_Click);
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.employeesToolStripMenuItem.Text = "Employees";
            this.employeesToolStripMenuItem.Click += new System.EventHandler(this.employeesToolStripMenuItem_Click);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.DropDownWidth = 121;
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(174, 27);
            this.toolStripComboBox1.Text = "None";
            this.toolStripComboBox1.TextUpdate += new System.EventHandler(this.toolStripComboBox1_TextUpdate);
            this.toolStripComboBox1.TextChanged += new System.EventHandler(this.toolStripComboBox1_TextChanged);
            // 
            // ADDBUTT
            // 
            this.ADDBUTT.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ADDBUTT.Location = new System.Drawing.Point(376, 537);
            this.ADDBUTT.Margin = new System.Windows.Forms.Padding(2);
            this.ADDBUTT.Name = "ADDBUTT";
            this.ADDBUTT.Size = new System.Drawing.Size(94, 38);
            this.ADDBUTT.TabIndex = 2;
            this.ADDBUTT.Text = "ADD";
            this.ADDBUTT.UseVisualStyleBackColor = true;
            this.ADDBUTT.Click += new System.EventHandler(this.ADDBUTT_Click);
            // 
            // DELETE
            // 
            this.DELETE.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DELETE.Location = new System.Drawing.Point(563, 537);
            this.DELETE.Margin = new System.Windows.Forms.Padding(2);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(94, 38);
            this.DELETE.TabIndex = 3;
            this.DELETE.Text = "DELETE";
            this.DELETE.UseVisualStyleBackColor = true;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 585);
            this.Controls.Add(this.DELETE);
            this.Controls.Add(this.ADDBUTT);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.DataView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataView;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton Views;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showingTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.Button ADDBUTT;
        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
    }
}

