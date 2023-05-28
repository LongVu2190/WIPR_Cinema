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
        DataTable myTable = new DataTable();
        string data;
        public BL_Cinema() { }

        public List<int> LoadSeats(string ShowTime_ID)
        {
            string sql = $"select * from Fn_BookedSeats('{ShowTime_ID}')";
            myTable = db.LoadData(sql);
            List<int> list = new List<int>();

            foreach (DataRow row in myTable.Rows)
            {
                data = row["Seat"].ToString();
                list.Add(int.Parse(data));
            }
            return list;
        }
        public DataTable LoadMovies(MovieType flag, string ID)
        {
            string sql = "";
            switch (flag)
            {
                case MovieType.UserBooked:
                    sql = $"select * from Fn_UserBooked('{ID}')";
                    return db.LoadData(sql);
                case MovieType.UserCommented:
                    sql = $"select * from Fn_UserCommented('{ID}')";
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
        
        public User UserInformation(string User_ID)
        {
            string sql = $"select * from Fn_UserInformation('{User_ID}')";
            myTable = db.LoadData(sql);
            User cus = new User();

            cus.User_ID = User_ID;
            cus.Name = myTable.Rows[0]["UserName"].ToString();
            data = myTable.Rows[0]["Balance"].ToString();
            cus.Balance = int.Parse(data);
            data = myTable.Rows[0]["Point"].ToString();
            cus.Point = int.Parse(data);
            data = myTable.Rows[0]["isVip"].ToString();
            cus.isVip = Boolean.Parse(data);
            data = myTable.Rows[0]["Expense"].ToString();
            if (data == "") data = "0";
            cus.Expense = int.Parse(data);

            return cus;
        }
        public int SumTotalCost(string ShowTime_ID, string User_ID, int Count)
        {
            string sql = $"select * from Fn_SumTotalCost('{ShowTime_ID}', '{User_ID}', '{Count}')";
            myTable = db.LoadData(sql);

            data = myTable.Rows[0]["Total"].ToString();
            return int.Parse(data);
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
