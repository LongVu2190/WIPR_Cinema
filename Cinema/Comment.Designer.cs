namespace Cinema
{
    partial class Comment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comment));
            this.Reservation_ID_tb = new System.Windows.Forms.TextBox();
            this.Comment_tb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Comment_btn = new System.Windows.Forms.Button();
            this.Point_tb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Reservation_ID_tb
            // 
            this.Reservation_ID_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reservation_ID_tb.Location = new System.Drawing.Point(140, 32);
            this.Reservation_ID_tb.Name = "Reservation_ID_tb";
            this.Reservation_ID_tb.ReadOnly = true;
            this.Reservation_ID_tb.Size = new System.Drawing.Size(292, 29);
            this.Reservation_ID_tb.TabIndex = 17;
            // 
            // Comment_tb
            // 
            this.Comment_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comment_tb.Location = new System.Drawing.Point(140, 122);
            this.Comment_tb.Name = "Comment_tb";
            this.Comment_tb.Size = new System.Drawing.Size(292, 29);
            this.Comment_tb.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Reservation ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Point:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Comment:";
            // 
            // Comment_btn
            // 
            this.Comment_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comment_btn.Location = new System.Drawing.Point(319, 173);
            this.Comment_btn.Name = "Comment_btn";
            this.Comment_btn.Size = new System.Drawing.Size(113, 29);
            this.Comment_btn.TabIndex = 33;
            this.Comment_btn.Tag = "NoDel";
            this.Comment_btn.Text = "Comment";
            this.Comment_btn.UseVisualStyleBackColor = true;
            this.Comment_btn.Click += new System.EventHandler(this.Comment_btn_Click);
            // 
            // Point_tb
            // 
            this.Point_tb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Point_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Point_tb.FormattingEnabled = true;
            this.Point_tb.Items.AddRange(new object[] {
            "10",
            "9",
            "8",
            "7",
            "6",
            "5",
            "4",
            "3",
            "2",
            "1",
            "0"});
            this.Point_tb.Location = new System.Drawing.Point(140, 76);
            this.Point_tb.Name = "Point_tb";
            this.Point_tb.Size = new System.Drawing.Size(292, 32);
            this.Point_tb.TabIndex = 45;
            // 
            // Comment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 217);
            this.Controls.Add(this.Point_tb);
            this.Controls.Add(this.Comment_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Comment_tb);
            this.Controls.Add(this.Reservation_ID_tb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Comment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comment";
            this.Load += new System.EventHandler(this.Comment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Reservation_ID_tb;
        private System.Windows.Forms.TextBox Comment_tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Comment_btn;
        private System.Windows.Forms.ComboBox Point_tb;
    }
}