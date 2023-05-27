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
        DBMain db = new DBMain();
        public void AddReservation(string User, string ShowID, int Seat)
        {
            string sql = $"exec Sp_AddReservation '{User}', '{ShowID}', '{Seat}";
            db.MyExecuteNonQuery(sql);
        }
        public void DeleteReservation(int ID)
        {
            string sql = $"exec Sp_DelReservation '{ID}'";
            db.MyExecuteNonQuery(sql);
        }
        public void Recharge(string User_ID, int money)
        {
            string sql = $"update Customer set Balance = Balance + {money} where User_ID = '{User_ID}'";
            db.MyExecuteNonQuery(sql);
        }
        public void AddShowTime(string ShowTimeID, string MovieID, string Date, string Start, string RoomID)
        {
            string sql = $"EXEC Sp_AddNewShowTime '{ShowTimeID}', '{MovieID}', '{Date}', '{Start}', '{RoomID}'";
            db.MyExecuteNonQuery(sql);
        }
        public void AddMovie(string ID, string Name, int Cost, string Time, string Actor, string Direc, string ComID)
        {
            string sql = $"EXEC Sp_AddNewMovie '{ID}', N'{Name}', '{Cost}', '{Time}', N'{Actor}', N'{Direc}', '{ComID}'";
            db.MyExecuteNonQuery(sql);
        }       
        public DataTable LoadData(AdminType type)
        {
            string sql = "";
            switch (type) 
            {
                case AdminType.isVIP:
                    sql = "select * from View_isVIP";
                    break;
                case AdminType.isNotVIP:
                    sql = "select * from View_isNotVIP";
                    break;
                case AdminType.ShowingInDay:
                    sql = "select * from View_ShowingInDay";
                    break;
                case AdminType.ComingShowing:
                    sql = "select * from View_ComingShowing";
                    break;
                case AdminType.ClosedShowing:
                    sql = "select * from View_ClosedShowing";
                    break;
                case AdminType.ShowingInDayAvailable:
                    sql = "select * from View_ShowingInDayAvailable";
                    break;
                case AdminType.ShowingInDayOut:
                    sql = "select * from View_ShowingInDayAvailable";
                    break;
                case AdminType.HighRatingShowing:
                    sql = "select * from View_HighRatingShowing";
                    break;
                case AdminType.Reservation:
                    sql = "select * from Reservation";
                    break;
                case AdminType.AllShowTime:
                    sql = "select * from ShowTime";
                    break;
                case AdminType.AllMovies:
                    sql = "select * from Movie";
                    break;
                case AdminType.AdminInformation:
                    sql = "select * from User_Information A inner join Admin B on A.User_ID = B.User_ID";
                    break;
                case AdminType.CustomerInformation:
                    sql = "select * from User_Information A inner join Customer B on A.User_ID = B.User_ID";
                    break;
                case AdminType.Company:
                    sql = "select * from Company";
                    break;
                case AdminType.Room:
                    sql = "select * from Room";
                    break;
            }
            return db.LoadData(sql);
        }
    }
}
