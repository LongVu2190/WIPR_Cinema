using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cinema.BS_Layer;

namespace Cinema
{
    public partial class Admin : Form
    {
        BL_Admin bs = new BL_Admin();
        DataTable DataTables = null;
        DataSet DataSets = null;
        public User admin;
        //FLAGS
        private bool Res = false;
        private bool ShowTime = false;
        private bool Movie = false;
        private bool Customer = false;
        private bool Employee = false;
        public Admin()
        {
            InitializeComponent();
            DataView.DataSource = bs.Movies();
        }
        private void RESETFLAGS()
        {
            Res = false;
            ShowTime = false;
            Movie = false;
            Customer = false;
            Employee = false;
        }
        //TOOL STRIP
        private void showingTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RESETFLAGS();
            ShowTime = true;
            DataView.DataSource = bs.ShowTime();
            this.toolStripComboBox1.Items.Clear();
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "ShowingInDay",
            "ComingShowing",
            "ClosedShowing",
            "ShowingInDayAvailable",
            "ShowingInDayOut",
            "HighRatingShowing" });
            this.toolStripComboBox1.Text = "6 Filters";
            this.ADDBUTT.Enabled = true;
            this.DELETE.Enabled = false;
        }
        private void moviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RESETFLAGS();
            Movie = true; 
            DataView.DataSource = bs.Movies();
            this.toolStripComboBox1.Items.Clear();
            this.toolStripComboBox1.Text = "None";
            this.ADDBUTT.Enabled = true;
            this.DELETE.Enabled = false;
        }
        private void reservationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RESETFLAGS();
            Res = true;
            DataView.DataSource = bs.Res();
            this.toolStripComboBox1.Items.Clear();
            this.toolStripComboBox1.Text = "None";
            this.ADDBUTT.Enabled = false;
            this.DELETE.Enabled = true;
        }
        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RESETFLAGS();
            Customer = true;
            DataView.DataSource = bs.KH();
            this.toolStripComboBox1.Items.Clear();
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "VIP",
            "NoVIP"});
            this.toolStripComboBox1.Text = "2 Filters";
            this.ADDBUTT.Enabled = false;
            this.DELETE.Enabled = false;
        }
        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RESETFLAGS();
            Employee = true;
            DataView.DataSource = bs.Emp();
            this.toolStripComboBox1.Items.Clear();
            this.toolStrip1.Text = "None";
            this.ADDBUTT.Enabled = false;
            this.DELETE.Enabled = false;
        }
        private void toolStripComboBox1_TextUpdate(object sender, EventArgs e)
        {

        }
        private void toolStripComboBox1_TextChanged(object sender, EventArgs e)
        {
            if (toolStripComboBox1.Text == "VIP")
                DataView.DataSource = bs.ISVIP();
            else if (toolStripComboBox1.Text == "NoVIP")
                DataView.DataSource = bs.NoVIP();
            else if (toolStripComboBox1.Text == "ShowingInDay")
                DataView.DataSource = bs.ShowingInDay();
            else if (toolStripComboBox1.Text == "ComingShowing")
                DataView.DataSource = bs.ComingShow();
            else if (toolStripComboBox1.Text == "ClosedShowing")
                DataView.DataSource = bs.ClosedShow();
            else if (toolStripComboBox1.Text == "ShowingInDayAvailable")
                DataView.DataSource = bs.ShowInDayAva();
            else if (toolStripComboBox1.Text == "ShowingInDayOut")
                DataView.DataSource = bs.ShowInDayOut();
            else if (toolStripComboBox1.Text == "HighRatingShowing")
                DataView.DataSource = bs.highRatingShow();
        }
        private void ADDBUTT_Click(object sender, EventArgs e)
        {
            int a = this.DataView.Rows.Count - 2;
            if (Res)
            {
                if (bs.AddRES(this.DataView.Rows[a].Cells[1].Value.ToString(), this.DataView.Rows[a].Cells[2].Value.ToString(), Int32.Parse(this.DataView.Rows[a].Cells[3].Value.ToString())))
                {
                    reservationsToolStripMenuItem_Click(sender, e);
                    MessageBox.Show("SUCCESS!!");
                }
                else
                    MessageBox.Show("FAIL");

            }
            else if (ShowTime)
            {
                if (bs.AddShowTime(this.DataView.Rows[a].Cells[0].Value.ToString(), this.DataView.Rows[a].Cells[1].Value.ToString(), this.DataView.Rows[a].Cells[2].Value.ToString(), this.DataView.Rows[a].Cells[3].Value.ToString(), this.DataView.Rows[a].Cells[8].Value.ToString()))
                {
                    showingTimeToolStripMenuItem_Click(sender, e);
                    MessageBox.Show("SUCCESS!!");
                }
                else
                    MessageBox.Show("FAIL");
            }
            else if (Movie)
            {
                if (bs.AddMov(this.DataView.Rows[a].Cells[0].Value.ToString(), this.DataView.Rows[a].Cells[1].Value.ToString(), Int32.Parse(this.DataView.Rows[a].Cells[2].Value.ToString()), this.DataView.Rows[a].Cells[3].Value.ToString(), this.DataView.Rows[a].Cells[4].Value.ToString(), this.DataView.Rows[a].Cells[5].Value.ToString(), this.DataView.Rows[a].Cells[6].Value.ToString()))
                {
                    moviesToolStripMenuItem_Click(sender, e);
                    MessageBox.Show("SUCCESS!!");
                }
                else
                    MessageBox.Show("FAIL");
            }
            else if (Customer)
            {

            }
            else if (Employee)
            {

            }
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            if (Res)
            {
                if (bs.DelRES(Int32.Parse(this.DataView.Rows[this.DataView.CurrentRow.Index].Cells[0].Value.ToString())))
                {
                    reservationsToolStripMenuItem_Click(sender, e);
                    MessageBox.Show("SUCCESS!!");
                }
                else
                    MessageBox.Show("FAIL");

            }
            else if (ShowTime)
            {

            }
            else if (Movie)
            {

            }
            else if (Customer)
            {

            }
            else if (Employee)
            {

            }
        }
    }
}
