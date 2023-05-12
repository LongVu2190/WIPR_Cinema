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
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        BL_Cinema bs = new BL_Cinema();
        Movie movie;
        List<int> Booked_Seats = new List<int>();
        List<int> User_Book = new List<int>();

        string ShowTime_ID = "";
        string Reservation_ID = "";
        MovieType flag = MovieType.InDay;

        public Cinema()
        {
            InitializeComponent();
            //AllocConsole();
        }
        private void Cinema_Load(object sender, EventArgs e)
        {
            Movies_Data.DataSource = bs.LoadMovies(flag, "");
            LoadUserInformation();
        }
        public void CreateSeatsWidget()
        {
            User_Book = new List<int>();
            Comment_btn.Enabled = false;
            ClearSeatButtons();
            movie = new Movie();
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
        public void SeatClick(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            if (bt.BackColor == Color.IndianRed)
            {
                MessageBox.Show("Seat " + bt.Name + " is chosen", "Notification");
            }
            else if (bt.BackColor == Color.ForestGreen)
            {
                User_Book.Remove(Convert.ToInt32(bt.Text));
                bt.BackColor = Color.LightSlateGray;
            }
            else
            {
                User_Book.Add(Convert.ToInt32(bt.Text));
                bt.BackColor = Color.ForestGreen;
            }
            Console.WriteLine(User_Book.Count());
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
            Booked_Seats = bs.LoadSeats(ShowTime_ID);
            ShowTime_ID_tb.Text = ShowTime_ID;
            Reservation_ID = "";
            Reservation_ID_tb.Text = "";
            CreateSeatsWidget();
        }
        public void ClearSeatButtons()
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
        public void LoadUserInformation()
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
            if (User_Book.Count() == 0)
            {
                MessageBox.Show("Please choose a seat", "Notification");
                return;
            }

            int cost = 0;
            bs.SumTotalCost(ShowTime_ID, ref cost, cus.User_ID, User_Book.Count());

            string result = $"Your total is {cost}";

            DialogResult dlr = MessageBox.Show(result, "Notification", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                if (cost > cus.Balance && User_Book.Count > 1)
                {
                    MessageBox.Show("You don't have enough money", "Notification");
                    return;
                }
                foreach (var seat in User_Book)
                {
                    bs.AddReservation(cus.User_ID, ShowTime_ID, seat);
                }               
                bs.UserInformation(cus.User_ID, ref cus);
                LoadUserInformation();
                MessageBox.Show("Booked Successfully", "Notification");
            }
            User_Book = new List<int>();
            ClearSeatButtons();
        }
        private void FindScreen_btn_Click(object sender, EventArgs e)
        {
            flag = MovieType.ByScreen;
            Movies_Data.DataSource = bs.LoadMovies(flag, Screen_tb.Text);
            Movies_Data.Invalidate();
            ClearSeatButtons();
        }
        private void FindCompany_btn_Click(object sender, EventArgs e)
        {
            flag = MovieType.ByCompany;
            Movies_Data.DataSource = bs.LoadMovies(flag, Company_tb.Text);
            Movies_Data.Invalidate();
            ClearSeatButtons();
        }
        private void FindActor_btn_Click(object sender, EventArgs e)
        {
            flag = MovieType.ByActor;
            Movies_Data.DataSource = bs.LoadMovies(flag, Actor_tb.Text);
            Movies_Data.Invalidate();
            ClearSeatButtons();
        }
        private void InDay_btn_Click(object sender, EventArgs e)
        {
            flag = MovieType.InDay;
            Movies_Data.DataSource = bs.LoadMovies(flag, "");
            Movies_Data.Invalidate();
            ClearSeatButtons();
        }
        private void Booked_btn_Click(object sender, EventArgs e)
        {
            flag = MovieType.UserBooked;
            Movies_Data.DataSource = bs.LoadMovies(flag, cus.User_ID);
            Movies_Data.Invalidate();
            ClearSeatButtons();
        }
        private void Coming_btn_Click(object sender, EventArgs e)
        {
            flag = MovieType.Coming;
            Movies_Data.DataSource = bs.LoadMovies(flag, "");
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
        private void Commented_btn_Click(object sender, EventArgs e)
        {
            flag = MovieType.UserCommented;
            Movies_Data.DataSource = bs.LoadMovies(flag, cus.User_ID);
            Movies_Data.Invalidate();
            ClearSeatButtons();
        }
        private void Rating_btn_Click(object sender, EventArgs e)
        {
            if (ShowTime_ID == "")
            {
                MessageBox.Show("Please choose a ShowTime", "Notification");
                return;
            }
            flag = MovieType.MovieRating;
            Movies_Data.DataSource = bs.LoadMovies(flag, ShowTime_ID);
            Movies_Data.Invalidate();
            ClearSeatButtons();
        }
        private void AllComment_btn_Click(object sender, EventArgs e)
        {
            flag = MovieType.AllComments;
            Movies_Data.DataSource = bs.LoadMovies(flag, "");
            Movies_Data.Invalidate();
            ClearSeatButtons();
        }
    }
}

