using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Cinema.BS_Layer
{
    internal class BL_Admin
    {
        CinemaEntities cinemaEntity;

        public BL_Admin()
        {
            cinemaEntity = new CinemaEntities();
        }
        public void AddReservation(string User, string ShowID, int Seat)
        {
            cinemaEntity = new CinemaEntities();
            cinemaEntity.Sp_AddReservation(User, ShowID, Seat);
        }
        public void DeleteReservation(int ID)
        {
            cinemaEntity = new CinemaEntities();
            cinemaEntity.Sp_DelReservation(ID);
        }
        public void Recharge(string User_ID, int money)
        {
            cinemaEntity = new CinemaEntities();
            cinemaEntity.Database.ExecuteSqlCommand($"update Customer set Balance = Balance + {money} where User_ID = '{User_ID}'");
        }
        public void AddShowTime(string ShowTimeID, string MovieID, DateTime Date, TimeSpan Start, string RoomID)
        {
            cinemaEntity = new CinemaEntities();
            cinemaEntity.Sp_AddNewShowTime(ShowTimeID, MovieID, Date, Start, RoomID);
        }
        public void UpdateShowTime(string ShowTimeID, string MovieID, DateTime Date, TimeSpan Start, string RoomID)
        {
            cinemaEntity = new CinemaEntities();
            cinemaEntity.Sp_UpdateShowTime(ShowTimeID, MovieID, Date, Start, RoomID);
        }
        public void AddMovie(string ID, string Name, int Cost, TimeSpan Time, string Actor, string Direc, string ComID)
        {
            cinemaEntity = new CinemaEntities();
            cinemaEntity.Sp_AddNewMovie(ID, Name, Cost, Time, Actor, Direc, ComID);
        }
        public void UpdateMovie(string ID, string Name, int Cost, TimeSpan Time, string Actor, string Direc, string ComID)
        {
            cinemaEntity = new CinemaEntities();
            cinemaEntity.Sp_UpdateMovie(ID, Name, Cost, Time, Actor, Direc, ComID);
        }
        public void AddCompany(string Company_ID, string Name, string Email, string Phone, string Address)
        {
            cinemaEntity = new CinemaEntities();
            cinemaEntity.Sp_AddNewCompany(Company_ID, Name, Email, Phone, Address);
            
        }
        public void UpdateCompany(string Company_ID, string Name, string Email, string Phone, string Address)
        {
            cinemaEntity = new CinemaEntities();
            cinemaEntity.Sp_UpdateCompany(Company_ID, Name, Email, Phone, Address);
           
        }
        public void AddRoom(string Room_ID, int MaxSeats, string Screen_Resolution, string Audio_Quality)
        {
            cinemaEntity = new CinemaEntities();
            cinemaEntity.Sp_AddNewRoom(Room_ID, MaxSeats, Screen_Resolution, Audio_Quality);
            
        }
        public void UpdateRoom(string Room_ID, int MaxSeats, string Screen_Resolution, string Audio_Quality)
        {
            cinemaEntity = new CinemaEntities();
            cinemaEntity.Sp_UpdateRoom(Room_ID , MaxSeats, Screen_Resolution, Audio_Quality);
           
        }
        public DataTable LoadData(AdminType type)
        {
            DataTable dataTable = new DataTable();
            switch (type)
            {
                case AdminType.ShowingInDay:
                    var inDayMovies =
                    from inDayMovie in cinemaEntity.View_ShowingInDay
                    select inDayMovie;
                    dataTable.Columns.Add("ShowTime_ID", typeof(string));
                    dataTable.Columns.Add("Movie_Title", typeof(string));
                    dataTable.Columns.Add("Total_Cost", typeof(decimal));
                    dataTable.Columns.Add("Main_Actor", typeof(string));
                    dataTable.Columns.Add("Director", typeof(string));
                    dataTable.Columns.Add("Date", typeof(DateTime));
                    dataTable.Columns.Add("Start_Time", typeof(TimeSpan));
                    dataTable.Columns.Add("End_Time", typeof(TimeSpan));
                    foreach (var inDayMovie in inDayMovies)
                    {
                        dataTable.Rows.Add(inDayMovie.ShowTime_ID, inDayMovie.Movie_Title, inDayMovie.Total_Cost
                            , inDayMovie.Main_Actor, inDayMovie.Director, inDayMovie.Date, inDayMovie.Start_Time, inDayMovie.End_Time);
                    }
                    return dataTable;  
                case AdminType.ComingShowing:
                    var comingMovies =
                    from comingMovie in cinemaEntity.View_ComingShowing
                    select comingMovie;
                    dataTable.Columns.Add("ShowTime_ID", typeof(string));
                    dataTable.Columns.Add("Movie_Title", typeof(string));
                    dataTable.Columns.Add("Total_Cost", typeof(decimal));
                    dataTable.Columns.Add("Main_Actor", typeof(string));
                    dataTable.Columns.Add("Director", typeof(string));
                    dataTable.Columns.Add("Date", typeof(DateTime));
                    dataTable.Columns.Add("Start_Time", typeof(TimeSpan));
                    dataTable.Columns.Add("End_Time", typeof(TimeSpan));
                    foreach (var comingMovie in comingMovies)
                    {
                        dataTable.Rows.Add(comingMovie.ShowTime_ID, comingMovie.Movie_Title, comingMovie.Total_Cost
                            , comingMovie.Main_Actor, comingMovie.Director, comingMovie.Date, comingMovie.Start_Time, comingMovie.End_Time);
                    }
                    return dataTable;
                case AdminType.ClosedShowing:
                    var closedMovies =
                    from closedMovie in cinemaEntity.View_ClosedShowing
                    select closedMovie;
                    dataTable.Columns.Add("ShowTime_ID", typeof(string));
                    dataTable.Columns.Add("Movie_Title", typeof(string));
                    dataTable.Columns.Add("Total_Cost", typeof(decimal));
                    dataTable.Columns.Add("Main_Actor", typeof(string));
                    dataTable.Columns.Add("Director", typeof(string));
                    dataTable.Columns.Add("Date", typeof(DateTime));
                    dataTable.Columns.Add("Start_Time", typeof(TimeSpan));
                    dataTable.Columns.Add("End_Time", typeof(TimeSpan));
                    foreach (var closedMovie in closedMovies)
                    {
                        dataTable.Rows.Add(closedMovie.ShowTime_ID, closedMovie.Movie_Title, closedMovie.Total_Cost
                            , closedMovie.Main_Actor, closedMovie.Director, closedMovie.Date, closedMovie.Start_Time, closedMovie.End_Time);
                    }
                    return dataTable;
                case AdminType.Reservation:
                    var reservations =
                    from reservation in cinemaEntity.Reservations
                    select reservation;
                    dataTable.Columns.Add("Reservation_ID", typeof(int));
                    dataTable.Columns.Add("User_ID", typeof(string));
                    dataTable.Columns.Add("ShowTime_ID", typeof(string));
                    dataTable.Columns.Add("Seat", typeof(int));
                    dataTable.Columns.Add("Paid", typeof(int));
                    foreach (var reservation in reservations)
                    {
                        dataTable.Rows.Add(reservation.Reservation_ID, reservation.User_ID, reservation.ShowTime_ID
                            , reservation.Seat, reservation.Paid);
                    }
                    return dataTable;  
                case AdminType.AllShowTime:
                    var allShowTime =
                    from showTime in cinemaEntity.ShowTimes
                    select showTime;
                    dataTable.Columns.Add("ShowTime_ID", typeof(string));
                    dataTable.Columns.Add("Movie_ID", typeof(string));
                    dataTable.Columns.Add("Date", typeof(DateTime));
                    dataTable.Columns.Add("Start_Time", typeof(TimeSpan));
                    dataTable.Columns.Add("End_Time", typeof(TimeSpan));
                    dataTable.Columns.Add("Current_Seats", typeof(int));
                    dataTable.Columns.Add("Quality_Cost", typeof(int));
                    dataTable.Columns.Add("Total_Cost", typeof(int));
                    dataTable.Columns.Add("Room_ID", typeof(string));
                    foreach (var showTime in allShowTime)
                    {
                        dataTable.Rows.Add(showTime.ShowTime_ID, showTime.Movie_ID, showTime.Date, showTime.Start_Time, showTime.End_Time
                            , showTime.Current_Seats, showTime.Quality_Cost, showTime.Total_Cost, showTime.Room_ID);
                    }
                    return dataTable;                     
                case AdminType.AllMovies:
                    var allMovies =
                    from movie in cinemaEntity.Movies
                    select movie;
                    dataTable.Columns.Add("Movie_ID", typeof(string));
                    dataTable.Columns.Add("Movie_Title", typeof(string));
                    dataTable.Columns.Add("Movie_Cost", typeof(int));
                    dataTable.Columns.Add("Runtime", typeof(TimeSpan));
                    dataTable.Columns.Add("Main_Actor", typeof(string));
                    dataTable.Columns.Add("Director", typeof(string));
                    dataTable.Columns.Add("Company_ID", typeof(string));
                    foreach (var movie in allMovies)
                    {
                        dataTable.Rows.Add(movie.Movie_ID, movie.Movie_Title, movie.Movie_Cost, movie.Runtime
                            , movie.Main_Actor, movie.Director, movie.Company_ID);
                    }
                    return dataTable;                    
                case AdminType.Company:
                    var companies =
                    from company in cinemaEntity.Companies
                    select company;
                    dataTable.Columns.Add("Company_ID", typeof(string));
                    dataTable.Columns.Add("Name", typeof(string));
                    dataTable.Columns.Add("Email", typeof(string));
                    dataTable.Columns.Add("Phone", typeof(string));
                    dataTable.Columns.Add("Address", typeof(string));
                    foreach (var company in companies)
                    {
                        dataTable.Rows.Add(company.Company_ID, company.Name, company.Email, company.Phone, company.Address);
                    }
                    return dataTable;                   
                case AdminType.Room:
                    var rooms =
                    from room in cinemaEntity.Rooms
                    select room;
                    dataTable.Columns.Add("Room_ID", typeof(string));
                    dataTable.Columns.Add("MaxSeats", typeof(int));
                    dataTable.Columns.Add("Screen_Resolution", typeof(string));
                    dataTable.Columns.Add("Audio_Quality", typeof(string));
                    foreach (var room in rooms)
                    {
                        dataTable.Rows.Add(room.Room_ID, room.MaxSeats, room.Screen_Resolution, room.Audio_Quality);
                    }
                    return dataTable;               
            }
            return null;
        }
    }
}
