using Cinema.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema.BS_Layer
{
    internal class BL_Cinema
    {
        DBMain db = new DBMain();
        public BL_Cinema() { }

        public List<int> LoadSeats(string ShowTime_ID)
        {
            string sql = $"select * from Fn_BookedSeats('{ShowTime_ID}')";
            return db.LoadSeats(sql);
        }
        public DataTable LoadMovies(MovieType flag, string ID)
        {
            string sql = "";
            switch (flag)
            {
                case MovieType.All:
                    sql = "select * from ShowTime";
                    return db.LoadMovies(sql);
                case MovieType.ByScreen:
                    sql = $"select * from Fn_ShowTimeByScreen('{ID}')";
                    return db.LoadMovies(sql);
                case MovieType.ByCompany:
                    sql = $"select * from Fn_ShowTimeByCompany(N'{ID}')";
                    return db.LoadMovies(sql);
                case MovieType.ByActor:
                    sql = $"select * from Fn_ShowTimeByActor(N'{ID}')";
                    return db.LoadMovies(sql);
                case MovieType.UserBooked:
                    sql = $"select * from Fn_UserBooked('{ID}')";
                    return db.LoadMovies(sql);
                case MovieType.UserCommented:
                    sql = $"select * from Fn_UserCommented('{ID}')";
                    return db.LoadMovies(sql);
                case MovieType.InDay:
                    sql = "select * from View_ShowingInDay";
                    return db.LoadMovies(sql);
                case MovieType.Coming:
                    sql = "select * from View_ComingShowing";
                    return db.LoadMovies(sql);
                default:
                    return null;
            }
        }
        public void LoadUserInformation(string User_ID, ref User cus)
        {
            string sql = $"select Balance, Point, isVip from Customer where Customer.User_ID = '{User_ID}'";
            db.GetUserInformation(sql, ref cus);
        }
        public void GetCost(string ShowTime_ID, ref int cost)
        {
            string sql = $"select Total_Cost from ShowTime where ShowTime_ID = '{ShowTime_ID}'";
            db.GetCost(sql, ref cost);
        }
        public void BookMovie(string User_ID, string ShowTime_ID, int Seat)
        {
            string sql = $"exec Sp_AddReservation '{User_ID}', '{ShowTime_ID}', {Seat}";
            db.MyExecuteNonQuery(sql);   
        }
        public void AddComment(int Reservation_ID, int Point, string Comment)
        {
            string sql = $"exec Sp_AddOrUpdateComment {Reservation_ID}, {Point}, N'{Comment}'";
            db.MyExecuteNonQuery(sql);
        }
    }
}
