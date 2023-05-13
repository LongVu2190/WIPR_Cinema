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
                case MovieType.ByScreen:
                    sql = $"select * from Fn_ShowTimeByScreen('{ID}')";
                    return db.LoadData(sql);
                case MovieType.ByCompany:
                    sql = $"select * from Fn_ShowTimeByCompany(N'{ID}')";
                    return db.LoadData(sql);
                case MovieType.ByActor:
                    sql = $"select * from Fn_ShowTimeByActor(N'{ID}')";
                    return db.LoadData(sql);
                case MovieType.UserBooked:
                    sql = $"select * from Fn_UserBooked('{ID}')";
                    return db.LoadData(sql);
                case MovieType.UserCommented:
                    sql = $"select * from Fn_UserCommented('{ID}')";
                    return db.LoadData(sql);
                case MovieType.MovieRating:
                    sql = $"select * from Fn_MovieRating('{ID}')";
                    return db.LoadData(sql);
                case MovieType.InDay:
                    sql = "select * from View_ShowingInDay";
                    return db.LoadData(sql);
                case MovieType.Coming:
                    sql = "select * from View_ComingShowing";
                    return db.LoadData(sql);
                case MovieType.AllComments:
                    sql = "select * from View_Comments";
                    return db.LoadData(sql);              
                default:
                    return null;
            }
        }
        public void UserInformation(string User_ID, ref User cus)
        {
            string sql = $"select * from Fn_UserInformation('{User_ID}')";
            db.UserInformation(sql, ref cus);
        }
        public void SumTotalCost(string ShowTime_ID, ref int cost, string User_ID, int Count)
        {
            string sql = $"select * from Fn_SumTotalCost('{ShowTime_ID}', '{User_ID}', '{Count}')";
            db.SumTotalCost(sql, ref cost);
        }
        public void AddReservation(string User_ID, string ShowTime_ID, int Seat)
        {
            string sql = $"exec Sp_AddReservation '{User_ID}', '{ShowTime_ID}', {Seat}";
            db.MyExecuteNonQuery(sql);   
        }
        public void AddOrUpdateComment(int Reservation_ID, int Point, string Comment)
        {
            string sql = $"exec Sp_AddOrUpdateComment {Reservation_ID}, {Point}, N'{Comment}'";
            db.MyExecuteNonQuery(sql);
        }
    }
}
