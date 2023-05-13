using Cinema.BS_Layer;
using Cinema.DB_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class Cinema : Form
    {
        public User cus;

        BL_Cinema bs = new BL_Cinema();
        Movie movie;
        List<int> Booked_Seats = new List<int>();
        List<int> User_Booked = new List<int>();

        string ShowTime_ID = "";
        string Reservation_ID = "";
        MovieType flag = MovieType.InDay;

        public Cinema()
        {
            InitializeComponent();
        }
        private void Cinema_Load(object sender, EventArgs e)
        {
            try
            {
                Movies_Data.DataSource = bs.LoadMovies(flag, "");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notification");
            }
            LoadUserInformation();
        }
        private void CreateSeatsWidget()
        {
            User_Booked = new List<int>();
            Comment_btn.Enabled = false;
            movie = new Movie();
            ClearSeatButtons();
            for (int i = 0; i <= 28; i++)
            {
                movie.SEATS.Add(0);
            }
            for (int i = 0; i < Booked_Seats.Count; i++)
            {
                movie.SEATS[Booked_Seats[i]] = 1;
            }
            int Count = 1;
            int Buttons = 28;
            int X = 0;
            int Y = 0;
            for (int i = 1; i <= Buttons; i++)
            {
                Button b = new Button();
                b.Text = Count.ToString();
                b.Name = Count.ToString();
                b.Size = new Size(50, 50);
                b.Font = new Font("Arial", 12, FontStyle.Bold);
                b.Location = new Point(60 * (X + 1), Y + 50);
                switch (movie.SEATS[i])
                {
                    case -1:
                        b.BackColor = Color.DodgerBlue;
                        break;
                    case 0:
                        b.BackColor = Color.LightSlateGray;
                        break;
                    case 1:
                        b.BackColor = Color.IndianRed;
                        break;
                }
                b.ForeColor = Color.White;
                b.Padding = new Padding(0);
                b.Click += new EventHandler(this.SeatClick);
                if (i % 7 == 0)
                {
                    X = -1;
                    Y += 60;
                }
                X++;
                Controls.Add(b);
                Count++;
            }
        }
        private void ClearSeatButtons()
        {
            for (int i = 0; i < 5; i++)
            {
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is Button)
                    {
                        if (!String.Equals(ctrl.Tag, "NoDel"))
                            this.Controls.Remove(ctrl);
                    }
                }
            }
        }
        private void SeatClick(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            if (bt.BackColor == Color.IndianRed)
            {
                MessageBox.Show("Seat " + bt.Name + " is chosen", "Notification");
            }
            else if (bt.BackColor == Color.ForestGreen)
            {
                User_Booked.Remove(Convert.ToInt32(bt.Text));
                bt.BackColor = Color.LightSlateGray;
            }
            else
            {
                User_Booked.Add(Convert.ToInt32(bt.Text));
                bt.BackColor = Color.ForestGreen;
            }
        }
        private void Movies_Data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = Movies_Data.CurrentCell.RowIndex;
            if (r == Movies_Data.RowCount - 1 || flag == MovieType.AllComments)
            {
                ShowTime_ID = "";
                ShowTime_ID_tb.Text = "";
                Reservation_ID = "";
                Reservation_ID_tb.Text = "";
                return;
            }
            if (flag == MovieType.UserBooked || flag == MovieType.UserCommented)
            {
                ShowTime_ID = "";
                ShowTime_ID_tb.Text = "";
                Reservation_ID = Movies_Data.Rows[r].Cells[0].Value.ToString();
                Comment_btn.Enabled = true;
                Reservation_ID_tb.Text = Reservation_ID;
                return;
            }
            ShowTime_ID = Movies_Data.Rows[r].Cells[0].Value.ToString();
            try
            {
                Booked_Seats = bs.LoadSeats(ShowTime_ID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notification");
            }
            ShowTime_ID_tb.Text = ShowTime_ID;
            Reservation_ID = "";
            Reservation_ID_tb.Text = "";
            CreateSeatsWidget();
        }
        private void LoadUserInformation()
        {
            ID_lb.Text = cus.User_ID.ToString();
            Name_lb.Text = cus.Name.ToString();
            Balance_lb.Text = cus.Balance.ToString();
            Point_lb.Text = cus.Point.ToString();
            VIP_lb.Text = cus.isVip.ToString();
            Expense_lb.Text = cus.Expense.ToString();
        }
        private void Book_btn_Click(object sender, EventArgs e)
        {
            int total_cost = 0;
            if (User_Booked.Count() == 0)
            {
                MessageBox.Show("Please choose a seat", "Notification");
                return;
            }
            try
            {
                bs.SumTotalCost(ShowTime_ID, ref total_cost, cus.User_ID, User_Booked.Count());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notification");
            }

            DialogResult dlr = MessageBox.Show($"Your total is {total_cost}", "Notification", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                if (total_cost > cus.Balance && User_Booked.Count > 1)
                {
                    MessageBox.Show("You don't have enough money", "Notification");
                    return;
                }
                try
                {
                    bs.SumTotalCost(ShowTime_ID, ref total_cost, cus.User_ID, User_Booked.Count());
                    foreach (var seat in User_Booked)
                    {
                        bs.AddReservation(cus.User_ID, ShowTime_ID, seat);
                    }
                    bs.UserInformation(cus.User_ID, ref cus);
                    LoadUserInformation();
                    MessageBox.Show("Booked Successfully", "Notification");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Notification");
                }
            }
            User_Booked = new List<int>();
            ClearSeatButtons();
        }
        private void Finder_click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            string type = "";
            switch (bt.Name)
            {
                case "FindScreen_btn":
                    flag = MovieType.ByScreen;
                    type = Screen_tb.Text;
                    break;
                case "FindCompany_btn":
                    flag = MovieType.ByCompany;
                    type = Company_tb.Text;
                    break;
                case "FindActor_btn":
                    flag = MovieType.ByActor;
                    type = Actor_tb.Text;
                    break;
                case "InDay_btn":
                    flag = MovieType.InDay;
                    break;
                case "Coming_btn":
                    flag = MovieType.Coming;
                    break;
                case "Commented_btn":
                    flag = MovieType.UserBooked;
                    type = cus.User_ID;
                    break;
                case "UserCommented":
                    flag = MovieType.UserBooked;
                    type = cus.User_ID;
                    break;
                case "AllComment_btn":
                    flag = MovieType.AllComments;
                    break;
                case "Rating_btn":
                    if (ShowTime_ID == "")
                    {
                        MessageBox.Show("Please choose a ShowTime", "Notification");
                        return;
                    }
                    flag = MovieType.MovieRating;
                    type = ShowTime_ID;
                    break;
                default:
                    flag = MovieType.Coming;
                    break;
            }
            try
            {
                Movies_Data.DataSource = bs.LoadMovies(flag, type);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notification");
            }
            Movies_Data.Invalidate();
            ClearSeatButtons();
        }
        private void Comment_btn_Click(object sender, EventArgs e)
        {
            if (Reservation_ID == "") return;
            Comment form = new Comment(Reservation_ID);
            form.ShowDialog();
            Reservation_ID = "";
            Comment_btn.Enabled = false;
        }
    }
}

