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
        CinemaEntities cinemaEntity;

        string data;
        public BL_Cinema()
        {
            cinemaEntity = new CinemaEntities();
        }

        public List<int> LoadSeats(string ShowTime_ID)
        {
            DataTable dataTable = new DataTable();
            var seats =
            from seat in cinemaEntity.Fn_BookedSeats(ShowTime_ID) select seat;

            dataTable.Columns.Add("Seat", typeof(int));

            foreach (var seat in seats)
            {
                dataTable.Rows.Add(seat.Seat);
            }
            List<int> list = new List<int>();

            foreach (DataRow row in dataTable.Rows)
            {
                data = row["Seat"].ToString();
                list.Add(int.Parse(data));
            }
            return list;
        }
        public DataTable LoadMovies(MovieType flag, string ID)
        {
            DataTable dataTable = new DataTable();
            switch (flag)
            {
                case MovieType.ByScreen:
                    var byScreenMovies =
                        from byScreenMovie in cinemaEntity.Fn_ShowTimeByScreen(ID)
                        select byScreenMovie;
                    dataTable.Columns.Add("ShowTime_ID", typeof(string));
                    dataTable.Columns.Add("Movie_Title", typeof(string));
                    dataTable.Columns.Add("Total_Cost", typeof(int));
                    dataTable.Columns.Add("Date", typeof(DateTime));
                    dataTable.Columns.Add("Start_Time", typeof(TimeSpan));
                    dataTable.Columns.Add("End_Time", typeof(TimeSpan));
                    dataTable.Columns.Add("Main_Actor", typeof(string));
                    dataTable.Columns.Add("Director", typeof(string));
                    foreach (var byScreenMovie in byScreenMovies)
                    {
                        dataTable.Rows.Add(byScreenMovie.ShowTime_ID, byScreenMovie.Movie_Title, byScreenMovie.Total_Cost, byScreenMovie.Date,
                            byScreenMovie.Start_Time, byScreenMovie.End_Time, byScreenMovie.Main_Actor, byScreenMovie.Director);
                    }
                    return dataTable;
                case MovieType.ByCompany:
                    var byCompanyMovies =
                        from byCompanyMovie in cinemaEntity.Fn_ShowTimeByCompany(ID)
                        select byCompanyMovie;
                    dataTable.Columns.Add("ShowTime_ID", typeof(string));
                    dataTable.Columns.Add("Movie_Title", typeof(string));
                    dataTable.Columns.Add("Total_Cost", typeof(decimal));
                    dataTable.Columns.Add("Date", typeof(DateTime));
                    dataTable.Columns.Add("Start_Time", typeof(TimeSpan));
                    dataTable.Columns.Add("End_Time", typeof(TimeSpan));
                    dataTable.Columns.Add("Main_Actor", typeof(string));
                    dataTable.Columns.Add("Director", typeof(string));
                    foreach (var byCompanyMovie in byCompanyMovies)
                    {
                        dataTable.Rows.Add(byCompanyMovie.ShowTime_ID, byCompanyMovie.Movie_Title, byCompanyMovie.Total_Cost, byCompanyMovie.Date,
                           byCompanyMovie.Start_Time, byCompanyMovie.End_Time, byCompanyMovie.Main_Actor, byCompanyMovie.Director);
                    }
                    return dataTable;
                case MovieType.ByActor:
                    var byActorMovies =
                        from byActorMovie in cinemaEntity.Fn_ShowTimeByActor(ID)
                        select byActorMovie;
                    dataTable.Columns.Add("ShowTime_ID", typeof(string));
                    dataTable.Columns.Add("Movie_Title", typeof(string));
                    dataTable.Columns.Add("Total_Cost", typeof(int));
                    dataTable.Columns.Add("Date", typeof(DateTime));
                    dataTable.Columns.Add("Start_Time", typeof(TimeSpan));
                    dataTable.Columns.Add("End_Time", typeof(TimeSpan));
                    dataTable.Columns.Add("Main_Actor", typeof(string));
                    dataTable.Columns.Add("Director", typeof(string));
                    foreach (var byActorMovie in byActorMovies)
                    {
                        dataTable.Rows.Add(byActorMovie.ShowTime_ID, byActorMovie.Movie_Title, byActorMovie.Total_Cost, byActorMovie.Date,
                           byActorMovie.Start_Time, byActorMovie.End_Time, byActorMovie.Main_Actor, byActorMovie.Director);
                    }
                    return dataTable;
                case MovieType.UserBooked:
                    var userBookedMovies =
                        from userBookedMovie in cinemaEntity.Fn_UserBooked(ID)
                        select userBookedMovie;
                    dataTable.Columns.Add("Reservation_ID", typeof(string));
                    dataTable.Columns.Add("Movie_Title", typeof(string));
                    dataTable.Columns.Add("Seat", typeof(int));
                    dataTable.Columns.Add("Date", typeof(DateTime));
                    dataTable.Columns.Add("Start_Time", typeof(TimeSpan));
                    dataTable.Columns.Add("End_Time", typeof(TimeSpan));
                    dataTable.Columns.Add("Room", typeof(string));
                    foreach (var userBookedMovie in userBookedMovies)
                    {
                        dataTable.Rows.Add(userBookedMovie.Reservation_ID, userBookedMovie.Movie_Title, userBookedMovie.Seat, userBookedMovie.Date,
                           userBookedMovie.Start_Time, userBookedMovie.End_Time, userBookedMovie.Room);
                    }
                    return dataTable;
                case MovieType.UserCommented:
                    var usersCommented =
                       from userCommented in cinemaEntity.Fn_UserCommented(ID)
                       select userCommented;
                    dataTable.Columns.Add("Reservation_ID", typeof(string));
                    dataTable.Columns.Add("Movie_Title", typeof(string));
                    dataTable.Columns.Add("Rating_Point", typeof(int));
                    dataTable.Columns.Add("Comment", typeof(string));
                    foreach (var userCommented in usersCommented)
                    {
                        dataTable.Rows.Add(userCommented.Reservation_ID, userCommented.Movie_Title, userCommented.Rating_Point, userCommented.Comment);
                    }
                    return dataTable;
                case MovieType.InDay:
                    var inDayMovies =
                        from inDayMovie in cinemaEntity.View_ShowingInDay
                        select inDayMovie;
                    dataTable.Columns.Add("ShowTime_ID", typeof(string));
                    dataTable.Columns.Add("Movie_Title", typeof(string));
                    dataTable.Columns.Add("Total_Cost", typeof(decimal));
                    dataTable.Columns.Add("Date", typeof(DateTime));
                    dataTable.Columns.Add("Start_Time", typeof(TimeSpan));
                    dataTable.Columns.Add("End_Time", typeof(TimeSpan));
                    dataTable.Columns.Add("Main_Actor", typeof(string));
                    dataTable.Columns.Add("Director", typeof(string));
                    foreach (var inDayMovie in inDayMovies)
                    {
                        dataTable.Rows.Add(inDayMovie.ShowTime_ID, inDayMovie.Movie_Title, inDayMovie.Total_Cost, inDayMovie.Date,
                           inDayMovie.Start_Time, inDayMovie.End_Time, inDayMovie.Main_Actor, inDayMovie.Director);
                    }
                    return dataTable;
                case MovieType.Coming:
                    var comingMovies =
                        from comingMovie in cinemaEntity.View_ComingShowing
                        select comingMovie;
                    dataTable.Columns.Add("ShowTime_ID", typeof(string));
                    dataTable.Columns.Add("Movie_Title", typeof(string));
                    dataTable.Columns.Add("Total_Cost", typeof(decimal));
                    dataTable.Columns.Add("Date", typeof(DateTime));
                    dataTable.Columns.Add("Start_Time", typeof(TimeSpan));
                    dataTable.Columns.Add("End_Time", typeof(TimeSpan));
                    dataTable.Columns.Add("Main_Actor", typeof(string));
                    dataTable.Columns.Add("Director", typeof(string));
                    foreach (var comingMovie in comingMovies)
                    {
                        dataTable.Rows.Add(comingMovie.ShowTime_ID, comingMovie.Movie_Title, comingMovie.Total_Cost, comingMovie.Date,
                           comingMovie.Start_Time, comingMovie.End_Time, comingMovie.Main_Actor, comingMovie.Director);
                    }
                    return dataTable;
                default:
                    return null;
            }
        }

        public User_Object UserInformation(string User_ID)
        {
            DataTable dataTable = new DataTable();
            var usersInf =
              from userInf in cinemaEntity.Fn_UserInformation(User_ID)
              select userInf;
            dataTable.Columns.Add("UserName", typeof(string));
            dataTable.Columns.Add("Balance", typeof(int));
            dataTable.Columns.Add("Point", typeof(int));
            dataTable.Columns.Add("isVIP", typeof(bool));
            dataTable.Columns.Add("Expense", typeof(int));
            foreach (var userInf in usersInf)
            {
                dataTable.Rows.Add(userInf.UserName, userInf.Balance, userInf.Point, userInf.isVIP, userInf.Expense);
            }
            User_Object cus = new User_Object();

            cus.User_ID = User_ID;
            cus.Name = dataTable.Rows[0]["UserName"].ToString();
            data = dataTable.Rows[0]["Balance"].ToString();
            cus.Balance = int.Parse(data);
            data = dataTable.Rows[0]["Point"].ToString();
            cus.Point = int.Parse(data);
            data = dataTable.Rows[0]["isVIP"].ToString();
            cus.isVip = Boolean.Parse(data);
            data = dataTable.Rows[0]["Expense"].ToString();
            if (data == "") data = "0";
            cus.Expense = int.Parse(data);

            return cus;
        }
        public int SumTotalCost(string ShowTime_ID, string User_ID, int Count)
        {
            DataTable dataTable = new DataTable();

            var totalCost =
               from total in cinemaEntity.Fn_SumTotalCost(ShowTime_ID, User_ID, Count)
               select total;

            dataTable.Columns.Add("Total", typeof(int));

            foreach (var total in totalCost)
            {
                dataTable.Rows.Add(total.Total);
            }
            data = dataTable.Rows[0]["Total"].ToString();
            return int.Parse(data);
        }
        public void AddReservation(string User_ID, string ShowTime_ID, int Seat)
        {
            cinemaEntity = new CinemaEntities();
            cinemaEntity.Sp_AddReservation(User_ID, ShowTime_ID, Seat);
        }
        public void AddOrUpdateComment(int Reservation_ID, int Point, string Comment)
        {
            cinemaEntity = new CinemaEntities();
            cinemaEntity.Sp_AddOrUpdateComment(Reservation_ID, Point, Comment);
        }
    }
}
