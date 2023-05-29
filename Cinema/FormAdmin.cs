using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cinema.BS_Layer;
using Cinema.ReportForms;

namespace Cinema
{
    public partial class FormAdmin : Form
    {
        BL_Admin bs = new BL_Admin();
        public User admin;
        public User cus;
        private bool Res = false;
        private bool ShowTime = false;
        private bool Movie = false;
        private bool Company = false;
        private bool Room = false;
        private int row = 0;
        public FormAdmin()
        {
            InitializeComponent();
        }
        private void ResetFlags()
        {
            Res = false;
            ShowTime = false;
            Movie = false;
            Company = false;
            Room = false;
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
            "ClosedShowing", });
            this.Filter.Text = "3 Filters";
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
            AllCustomers form = new AllCustomers();
            form.ShowDialog();
        }
        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetFlags();
            AllEmployees form = new AllEmployees();
            form.ShowDialog();
        }
        private void companyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetFlags();
            Company = true;
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
            this.add_btn.Enabled = true;
            this.delete_btn.Enabled = false;
        }
        private void roomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetFlags();
            Room = true;
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
            this.add_btn.Enabled = true;
            this.delete_btn.Enabled = false;
        }

        private void Filter_TextChanged(object sender, EventArgs e)
        {
            if (Filter.Text == "ShowingInDay")
                DataView.DataSource = bs.LoadData(AdminType.ShowingInDay);
            else if (Filter.Text == "ComingShowing")
                DataView.DataSource = bs.LoadData(AdminType.ComingShowing);
            else if (Filter.Text == "ClosedShowing")
                DataView.DataSource = bs.LoadData(AdminType.ClosedShowing);
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
            else if (Company)
            {
                try
                {
                    bs.AddCompany(this.DataView.Rows[a].Cells["Company_ID"].Value.ToString(), this.DataView.Rows[a].Cells["Name"].Value.ToString(), this.DataView.Rows[a].Cells["Email"].Value.ToString(), this.DataView.Rows[a].Cells["Phone"].Value.ToString(), this.DataView.Rows[a].Cells["Address"].Value.ToString());
                    companyToolStripMenuItem_Click(sender, e);
                    MessageBox.Show("SUCCESS!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Notification");
                }
            }
            else if (Room)
            {
                int seats = Int32.Parse(this.DataView.Rows[a].Cells["MaxSeats"].Value.ToString());
                try
                {
                    bs.AddRoom(this.DataView.Rows[a].Cells["Room_ID"].Value.ToString(), seats, this.DataView.Rows[a].Cells["Screen_Resolution"].Value.ToString(), this.DataView.Rows[a].Cells["Audio_Quality"].Value.ToString());
                    roomToolStripMenuItem_Click(sender, e);
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
        }

        private void DataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = DataView.CurrentCell.RowIndex;
            if (row == DataView.RowCount - 1)
            {
                row = 0;
                return;
            }
            if (ShowTime || Company || Room || Movie)
            {
                update_btn.Enabled = true;
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (row == 0) return;
            if (ShowTime)
            {
                try
                {
                    bs.UpdateShowTime(this.DataView.Rows[row].Cells[0].Value.ToString(), this.DataView.Rows[row].Cells[1].Value.ToString(), this.DataView.Rows[row].Cells[2].Value.ToString(), this.DataView.Rows[row].Cells[3].Value.ToString(), this.DataView.Rows[row].Cells[8].Value.ToString());
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
                    bs.UpdateMovie(this.DataView.Rows[row].Cells[0].Value.ToString(), this.DataView.Rows[row].Cells[1].Value.ToString(), Int32.Parse(this.DataView.Rows[row].Cells[2].Value.ToString()), this.DataView.Rows[row].Cells[3].Value.ToString(), this.DataView.Rows[row].Cells[4].Value.ToString(), this.DataView.Rows[row].Cells[5].Value.ToString(), this.DataView.Rows[row].Cells[6].Value.ToString());
                    moviesToolStripMenuItem_Click(sender, e);
                    MessageBox.Show("SUCCESS!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Notification");
                }
            }
            else if (Company)
            {
                try
                {
                    bs.UpdateCompany(this.DataView.Rows[row].Cells["Company_ID"].Value.ToString(), this.DataView.Rows[row].Cells["Name"].Value.ToString(), this.DataView.Rows[row].Cells["Email"].Value.ToString(), this.DataView.Rows[row].Cells["Phone"].Value.ToString(), this.DataView.Rows[row].Cells["Address"].Value.ToString());
                    companyToolStripMenuItem_Click(sender, e);
                    MessageBox.Show("SUCCESS!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Notification");
                }
            }
            else if (Room)
            {
                int seats = Int32.Parse(this.DataView.Rows[row].Cells["MaxSeats"].Value.ToString());
                try
                {
                    bs.UpdateRoom(this.DataView.Rows[row].Cells["Room_ID"].Value.ToString(), seats, this.DataView.Rows[row].Cells["Screen_Resolution"].Value.ToString(), this.DataView.Rows[row].Cells["Audio_Quality"].Value.ToString());
                    roomToolStripMenuItem_Click(sender, e);
                    MessageBox.Show("SUCCESS!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Notification");
                }
            }
            update_btn.Enabled = false;
        }
    }
}
