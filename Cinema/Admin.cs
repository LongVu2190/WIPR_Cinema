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
        public User admin;
        public User cus;
        private bool Res = false;
        private bool ShowTime = false;
        private bool Movie = false;
        public Admin()
        {
            InitializeComponent();
            DataView.DataSource = bs.LoadData(AdminType.AllMovies);
        }
        private void ResetFlags()
        {
            Res = false;
            ShowTime = false;
            Movie = false;
        }
        private void showingTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetFlags();
            ShowTime = true;
            try
            {
                DataView.DataSource = bs.LoadData(AdminType.AllShowTime);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notification");
            }
            this.Filter.Items.Clear();
            this.Filter.Items.AddRange(new object[] {
            "ShowingInDay",
            "ComingShowing",
            "ClosedShowing",
            "ShowingInDayAvailable",
            "ShowingInDayOut",
            "HighRatingShowing" });
            this.Filter.Text = "6 Filters";
            this.add_btn.Enabled = true;
            this.delete_btn.Enabled = false;
        }
        private void moviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetFlags();
            Movie = true;
            try
            {
                DataView.DataSource = bs.LoadData(AdminType.AllMovies);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notification");
            }
            this.Filter.Items.Clear();
            this.Filter.Text = "None";
            this.add_btn.Enabled = true;
            this.delete_btn.Enabled = false;
        }
        private void reservationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetFlags();
            Res = true;
            try
            {
                DataView.DataSource = bs.LoadData(AdminType.Reservation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notification");
            }
            this.Filter.Items.Clear();
            this.Filter.Text = "None";
            this.add_btn.Enabled = false;
            this.delete_btn.Enabled = true;
        }
        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetFlags();
            try
            {
                DataView.DataSource = bs.LoadData(AdminType.CustomerInformation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notification");
            }
            this.Filter.Items.Clear();
            this.Filter.Items.AddRange(new object[] {
            "VIP",
            "NoVIP"});
            this.Filter.Text = "2 Filters";
            this.add_btn.Enabled = false;
            this.delete_btn.Enabled = false;
        }
        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetFlags();
            try
            {
                DataView.DataSource = bs.LoadData(AdminType.AdminInformation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notification");
            }          
            this.Filter.Items.Clear();
            this.toolStrip1.Text = "None";
            this.add_btn.Enabled = false;
            this.delete_btn.Enabled = false;
        }
        private void companyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetFlags();
            try
            {
                DataView.DataSource = bs.LoadData(AdminType.Company);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notification");
            }            
            this.Filter.Items.Clear();
            this.toolStrip1.Text = "None";
            this.add_btn.Enabled = false;
            this.delete_btn.Enabled = false;
        }
        private void roomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetFlags();
            try
            {
                DataView.DataSource = bs.LoadData(AdminType.Room);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notification");
            }           
            this.Filter.Items.Clear();
            this.toolStrip1.Text = "None";
            this.add_btn.Enabled = false;
            this.delete_btn.Enabled = false;
        }

        private void Filter_TextChanged(object sender, EventArgs e)
        {
            if (Filter.Text == "VIP")
                DataView.DataSource = bs.LoadData(AdminType.isVIP);
            else if (Filter.Text == "NoVIP")
                DataView.DataSource = bs.LoadData(AdminType.isNotVIP);
            else if (Filter.Text == "ShowingInDay")
                DataView.DataSource = bs.LoadData(AdminType.ShowingInDay);
            else if (Filter.Text == "ComingShowing")
                DataView.DataSource = bs.LoadData(AdminType.ComingShowing);
            else if (Filter.Text == "ClosedShowing")
                DataView.DataSource = bs.LoadData(AdminType.ClosedShowing);
            else if (Filter.Text == "ShowingInDayAvailable")
                DataView.DataSource = bs.LoadData(AdminType.ShowingInDayAvailable);
            else if (Filter.Text == "ShowingInDayOut")
                DataView.DataSource = bs.LoadData(AdminType.ShowingInDayOut);
            else if (Filter.Text == "HighRatingShowing")
                DataView.DataSource = bs.LoadData(AdminType.HighRatingShowing);
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            int a = this.DataView.Rows.Count - 2;
            if (Res)
            {
                try
                {
                    bs.AddReservation(this.DataView.Rows[a].Cells[1].Value.ToString(), this.DataView.Rows[a].Cells[2].Value.ToString(), Int32.Parse(this.DataView.Rows[a].Cells[3].Value.ToString()));
                    reservationsToolStripMenuItem_Click(sender, e);
                    MessageBox.Show("SUCCESS!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Notification");
                }

            }
            else if (ShowTime)
            {
                try
                {
                    bs.AddShowTime(this.DataView.Rows[a].Cells[0].Value.ToString(), this.DataView.Rows[a].Cells[1].Value.ToString(), this.DataView.Rows[a].Cells[2].Value.ToString(), this.DataView.Rows[a].Cells[3].Value.ToString(), this.DataView.Rows[a].Cells[8].Value.ToString());
                    showingTimeToolStripMenuItem_Click(sender, e);
                    MessageBox.Show("SUCCESS!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Notification");
                }
            }
            else if (Movie)
            {
                try
                {
                    bs.AddMovie(this.DataView.Rows[a].Cells[0].Value.ToString(), this.DataView.Rows[a].Cells[1].Value.ToString(), Int32.Parse(this.DataView.Rows[a].Cells[2].Value.ToString()), this.DataView.Rows[a].Cells[3].Value.ToString(), this.DataView.Rows[a].Cells[4].Value.ToString(), this.DataView.Rows[a].Cells[5].Value.ToString(), this.DataView.Rows[a].Cells[6].Value.ToString());
                    moviesToolStripMenuItem_Click(sender, e);
                    MessageBox.Show("SUCCESS!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Notification");
                }
            }
        }
        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (Res)
            {
                try
                {
                    bs.DeleteReservation(Int32.Parse(this.DataView.Rows[this.DataView.CurrentRow.Index].Cells[0].Value.ToString()));
                    reservationsToolStripMenuItem_Click(sender, e);
                    MessageBox.Show("SUCCESS!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Notification");
                }
            }
        }

        private void Recharge_btn_Click(object sender, EventArgs e)
        {
            try
            {
                bs.Recharge(User_ID_tb.Text, Convert.ToInt32(Recharge_Num.Value));
                MessageBox.Show("OK", "Notification");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notification");
            }
            customersToolStripMenuItem_Click(sender, e);
        }
    }
}
