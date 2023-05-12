using Cinema.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.BS_Layer
{
    internal class BL_Admin
    {
        public BL_Admin() { }
        DBMain Main = new DBMain();
        public bool AddRES(string User, string ShowID, int Seat)
        {
            string sql = $"exec Sp_AddReservation '{User}', '{ShowID}', '{Seat}";
            return Main.ExecuteNoTable(sql);
        }
        public bool AddShowTime(string ShowTimeID, string MovieID, string Date, string Start, string RoomID)
        {
            string sql = $"EXEC Sp_AddNewShowTime '{ShowTimeID}', '{MovieID}', '{Date}', '{Start}', '{RoomID}'";
            return Main.ExecuteNoTable(sql);
        }
        public bool AddMov(string ID, string Name, int Cost, string Time, string Actor, string Direc, string ComID)
        {
            string sql = $"EXEC Sp_AddNewMovie '{ID}', N'{Name}', '{Cost}', '{Time}', N'{Actor}', N'{Direc}', '{ComID}'";
            return Main.ExecuteNoTable(sql);
        }
        public bool DelRES(int ID)
        {
            string sql = $"exec Sp_DelReservation '{ID}'";
            return Main.ExecuteNoTable(sql);
        }
        public DataTable ShowTime()
        {
            string sql = "select * from ShowTime";
            return Main.LoadMovies(sql);
        }
        public DataTable Movies()
        {
            string sql = "select * from Movie";
            return Main.LoadMovies(sql);
        }
        public DataTable Res()
        {
            string sql = "select * from Reservation";
            return Main.LoadMovies(sql);
        }
        public DataTable Emp()
        {
            string sql = "select * from User_Information A inner join Admin B on A.User_ID = B.User_ID";
            return Main.LoadMovies(sql);
        }
        public DataTable KH()
        {
            string sql = "select * from User_Information A inner join Customer B on A.User_ID = B.User_ID";
            return Main.LoadMovies(sql);
        }
        public DataTable ISVIP()
        {
            string sql = "select * from View_isVIP";
            return Main.LoadMovies(sql);
        }
        public DataTable NoVIP()
        {
            string sql = "select * from View_isNotVIP";
            return Main.LoadMovies(sql);
        }
        public DataTable ShowingInDay()
        {
            string sql = "select * from View_ShowingInDay";
            return Main.LoadMovies(sql);
        }
        public DataTable ComingShow()
        {
            string sql = "select * from View_ComingShowing";
            return Main.LoadMovies(sql);
        }
        public DataTable ClosedShow()
        {
            string sql = "select * from View_ClosedShowing";
            return Main.LoadMovies(sql);
        }
        public DataTable ShowInDayAva()
        {
            string sql = "select * from View_ShowingInDayAvailable";
            return Main.LoadMovies(sql);
        }
        public DataTable ShowInDayOut()
        {
            string sql = "select * from View_ShowingInDayOut";
            return Main.LoadMovies(sql);
        }
        public DataTable highRatingShow()
        {
            string sql = "select * from View_HighRatingShowing";
            return Main.LoadMovies(sql);
        }
    }
}
