namespace Cinema
{
    partial class Booking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Booking));
            this.Movies_Data = new System.Windows.Forms.DataGridView();
            this.Book_btn = new System.Windows.Forms.Button();
            this.InDay_btn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ID_lb = new System.Windows.Forms.Label();
            this.Name_lb = new System.Windows.Forms.Label();
            this.Balance_lb = new System.Windows.Forms.Label();
            this.Point_lb = new System.Windows.Forms.Label();
            this.VIP_lb = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Booked_btn = new System.Windows.Forms.Button();
            this.Coming_btn = new System.Windows.Forms.Button();
            this.Comment_btn = new System.Windows.Forms.Button();
            this.Expense_lb = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Commented_btn = new System.Windows.Forms.Button();
            this.AllComment_btn = new System.Windows.Forms.Button();
            this.Reservation_ID_tb = new System.Windows.Forms.TextBox();
            this.Statement = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Movies_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // Movies_Data
            // 
            this.Movies_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Movies_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Movies_Data.Location = new System.Drawing.Point(529, 50);
            this.Movies_Data.Name = "Movies_Data";
            this.Movies_Data.ReadOnly = true;
            this.Movies_Data.Size = new System.Drawing.Size(727, 324);
            this.Movies_Data.TabIndex = 14;
            this.Movies_Data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Movies_Data_CellClick);
            // 
            // Book_btn
            // 
            this.Book_btn.BackColor = System.Drawing.Color.RoyalBlue;
            this.Book_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book_btn.ForeColor = System.Drawing.Color.White;
            this.Book_btn.Location = new System.Drawing.Point(219, 300);
            this.Book_btn.Name = "Book_btn";
            this.Book_btn.Size = new System.Drawing.Size(90, 29);
            this.Book_btn.TabIndex = 15;
            this.Book_btn.Tag = "NoDel";
            this.Book_btn.Text = "Book";
            this.Book_btn.UseVisualStyleBackColor = false;
            this.Book_btn.Click += new System.EventHandler(this.Book_btn_Click);
            // 
            // InDay_btn
            // 
            this.InDay_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InDay_btn.Location = new System.Drawing.Point(529, 9);
            this.InDay_btn.Name = "InDay_btn";
            this.InDay_btn.Size = new System.Drawing.Size(84, 29);
            this.InDay_btn.TabIndex = 22;
            this.InDay_btn.Tag = "NoDel";
            this.InDay_btn.Text = "In Day";
            this.InDay_btn.UseVisualStyleBackColor = true;
            this.InDay_btn.Click += new System.EventHandler(this.Finder_click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(15, 354);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 20);
            this.label12.TabIndex = 26;
            this.label12.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Balance:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(261, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Point:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(261, 383);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "VIP (-20%):";
            // 
            // ID_lb
            // 
            this.ID_lb.AutoSize = true;
            this.ID_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_lb.Location = new System.Drawing.Point(51, 354);
            this.ID_lb.Name = "ID_lb";
            this.ID_lb.Size = new System.Drawing.Size(26, 20);
            this.ID_lb.TabIndex = 31;
            this.ID_lb.Text = "ID";
            // 
            // Name_lb
            // 
            this.Name_lb.AutoSize = true;
            this.Name_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_lb.Location = new System.Drawing.Point(76, 383);
            this.Name_lb.Name = "Name_lb";
            this.Name_lb.Size = new System.Drawing.Size(51, 20);
            this.Name_lb.TabIndex = 32;
            this.Name_lb.Text = "Name";
            // 
            // Balance_lb
            // 
            this.Balance_lb.AutoSize = true;
            this.Balance_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Balance_lb.Location = new System.Drawing.Point(92, 412);
            this.Balance_lb.Name = "Balance_lb";
            this.Balance_lb.Size = new System.Drawing.Size(67, 20);
            this.Balance_lb.TabIndex = 33;
            this.Balance_lb.Text = "Balance";
            // 
            // Point_lb
            // 
            this.Point_lb.AutoSize = true;
            this.Point_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Point_lb.Location = new System.Drawing.Point(313, 354);
            this.Point_lb.Name = "Point_lb";
            this.Point_lb.Size = new System.Drawing.Size(45, 20);
            this.Point_lb.TabIndex = 34;
            this.Point_lb.Text = "Point";
            // 
            // VIP_lb
            // 
            this.VIP_lb.AutoSize = true;
            this.VIP_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VIP_lb.Location = new System.Drawing.Point(351, 383);
            this.VIP_lb.Name = "VIP_lb";
            this.VIP_lb.Size = new System.Drawing.Size(35, 20);
            this.VIP_lb.TabIndex = 35;
            this.VIP_lb.Text = "VIP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(202, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 20);
            this.label8.TabIndex = 36;
            this.label8.Text = "------Screen-------";
            // 
            // Booked_btn
            // 
            this.Booked_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Booked_btn.Location = new System.Drawing.Point(910, 401);
            this.Booked_btn.Name = "Booked_btn";
            this.Booked_btn.Size = new System.Drawing.Size(140, 29);
            this.Booked_btn.TabIndex = 37;
            this.Booked_btn.Tag = "NoDel";
            this.Booked_btn.Text = "Booked";
            this.Booked_btn.UseVisualStyleBackColor = true;
            this.Booked_btn.Click += new System.EventHandler(this.Finder_click);
            // 
            // Coming_btn
            // 
            this.Coming_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Coming_btn.Location = new System.Drawing.Point(619, 9);
            this.Coming_btn.Name = "Coming_btn";
            this.Coming_btn.Size = new System.Drawing.Size(84, 29);
            this.Coming_btn.TabIndex = 38;
            this.Coming_btn.Tag = "NoDel";
            this.Coming_btn.Text = "Coming";
            this.Coming_btn.UseVisualStyleBackColor = true;
            this.Coming_btn.Click += new System.EventHandler(this.Finder_click);
            // 
            // Comment_btn
            // 
            this.Comment_btn.Enabled = false;
            this.Comment_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comment_btn.Location = new System.Drawing.Point(1106, 401);
            this.Comment_btn.Name = "Comment_btn";
            this.Comment_btn.Size = new System.Drawing.Size(100, 29);
            this.Comment_btn.TabIndex = 43;
            this.Comment_btn.Tag = "NoDel";
            this.Comment_btn.Text = "Comment";
            this.Comment_btn.UseVisualStyleBackColor = true;
            this.Comment_btn.Click += new System.EventHandler(this.Comment_btn_Click);
            // 
            // Expense_lb
            // 
            this.Expense_lb.AutoSize = true;
            this.Expense_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expense_lb.Location = new System.Drawing.Point(342, 412);
            this.Expense_lb.Name = "Expense_lb";
            this.Expense_lb.Size = new System.Drawing.Size(71, 20);
            this.Expense_lb.TabIndex = 46;
            this.Expense_lb.Text = "Expense";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(261, 412);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 20);
            this.label10.TabIndex = 45;
            this.label10.Text = "Expense:";
            // 
            // Commented_btn
            // 
            this.Commented_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Commented_btn.Location = new System.Drawing.Point(764, 401);
            this.Commented_btn.Name = "Commented_btn";
            this.Commented_btn.Size = new System.Drawing.Size(140, 29);
            this.Commented_btn.TabIndex = 47;
            this.Commented_btn.Tag = "NoDel";
            this.Commented_btn.Text = "Commented";
            this.Commented_btn.UseVisualStyleBackColor = true;
            this.Commented_btn.Click += new System.EventHandler(this.Finder_click);
            // 
            // AllComment_btn
            // 
            this.AllComment_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllComment_btn.Location = new System.Drawing.Point(529, 401);
            this.AllComment_btn.Name = "AllComment_btn";
            this.AllComment_btn.Size = new System.Drawing.Size(140, 29);
            this.AllComment_btn.TabIndex = 48;
            this.AllComment_btn.Tag = "NoDel";
            this.AllComment_btn.Text = "All Comments";
            this.AllComment_btn.UseVisualStyleBackColor = true;
            this.AllComment_btn.Click += new System.EventHandler(this.Finder_click);
            // 
            // Reservation_ID_tb
            // 
            this.Reservation_ID_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reservation_ID_tb.Location = new System.Drawing.Point(1212, 401);
            this.Reservation_ID_tb.Name = "Reservation_ID_tb";
            this.Reservation_ID_tb.ReadOnly = true;
            this.Reservation_ID_tb.Size = new System.Drawing.Size(44, 29);
            this.Reservation_ID_tb.TabIndex = 51;
            // 
            // Statement
            // 
            this.Statement.BackColor = System.Drawing.Color.RoyalBlue;
            this.Statement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Statement.ForeColor = System.Drawing.Color.White;
            this.Statement.Location = new System.Drawing.Point(19, 301);
            this.Statement.Name = "Statement";
            this.Statement.Size = new System.Drawing.Size(108, 29);
            this.Statement.TabIndex = 52;
            this.Statement.Tag = "NoDel";
            this.Statement.Text = "Statement";
            this.Statement.UseVisualStyleBackColor = false;
            this.Statement.Click += new System.EventHandler(this.Statement_Click);
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1285, 452);
            this.Controls.Add(this.Statement);
            this.Controls.Add(this.Reservation_ID_tb);
            this.Controls.Add(this.AllComment_btn);
            this.Controls.Add(this.Commented_btn);
            this.Controls.Add(this.Expense_lb);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Comment_btn);
            this.Controls.Add(this.Coming_btn);
            this.Controls.Add(this.Booked_btn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.VIP_lb);
            this.Controls.Add(this.Point_lb);
            this.Controls.Add(this.Balance_lb);
            this.Controls.Add(this.Name_lb);
            this.Controls.Add(this.ID_lb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.InDay_btn);
            this.Controls.Add(this.Book_btn);
            this.Controls.Add(this.Movies_Data);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Booking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cinema";
            this.Load += new System.EventHandler(this.Cinema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Movies_Data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Movies_Data;
        private System.Windows.Forms.Button Book_btn;
        private System.Windows.Forms.Button InDay_btn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ID_lb;
        private System.Windows.Forms.Label Name_lb;
        private System.Windows.Forms.Label Balance_lb;
        private System.Windows.Forms.Label Point_lb;
        private System.Windows.Forms.Label VIP_lb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Booked_btn;
        private System.Windows.Forms.Button Coming_btn;
        private System.Windows.Forms.Button Comment_btn;
        private System.Windows.Forms.Label Expense_lb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Commented_btn;
        private System.Windows.Forms.Button AllComment_btn;
        private System.Windows.Forms.TextBox Reservation_ID_tb;
        private System.Windows.Forms.Button Statement;
    }
}

