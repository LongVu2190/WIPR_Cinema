using Microsoft.Reporting.Map.WebForms.BingMaps;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Cinema.BS_Layer
{
    internal class BL_Admin
    {
        public BL_Admin() { }
        public void AddReservation(string User, string ShowID, int Seat)
        {
            CinemaDataContext cinemaDataContext = new CinemaDataContext();
            cinemaDataContext.ExecuteCommand($"exec Sp_AddReservation '{User}', '{ShowID}', '{Seat}");
        }
        public void DeleteReservation(int ID)
        {
            CinemaDataContext cinemaDataContext = new CinemaDataContext();
            cinemaDataContext.ExecuteCommand($"exec Sp_DelReservation '{ID}'");
        }
        public void Recharge(string User_ID, int money)
        {
            using (CinemaDataContext cinemaDataContext = new CinemaDataContext())
            {
                cinemaDataContext.ExecuteCommand($"update Customer set Balance = Balance + {money} where User_ID = '{User_ID}'");
            }
        }
        public void AddShowTime(string ShowTimeID, string MovieID, string Date, string Start, string RoomID)
        {
            TimeSpan startTime;
            CinemaDataContext cinemaDataContext = new CinemaDataContext();
            if (TimeSpan.TryParse(Start, out startTime))
            {
                cinemaDataContext.ExecuteCommand($"EXEC Sp_AddNewShowTime '{ShowTimeID}', '{MovieID}', '{Date}', '{Start}', '{RoomID}'");
            }
        }
        public void UpdateShowTime(string ShowTimeID, string MovieID, string Date, string Start, string RoomID)
        {
            TimeSpan startTime;
            CinemaDataContext cinemaDataContext = new CinemaDataContext();
            if (TimeSpan.TryParse(Start, out startTime))
            {
                cinemaDataContext.ExecuteCommand($"EXEC Sp_UpdateShowTime '{ShowTimeID}', '{MovieID}', '{Date}', '{Start}', '{RoomID}'");
            }
        }
        public void AddMovie(string ID, string Name, int Cost, string Time, string Actor, string Direc, string ComID)
        {
            CinemaDataContext cinemaDataContext = new CinemaDataContext();
            TimeSpan runTime;
            if (TimeSpan.TryParse(Time, out runTime))
            {
                cinemaDataContext.ExecuteCommand($"EXEC Sp_AddNewMovie '{ID}', N'{Name}', '{Cost}', '{Time}', N'{Actor}', N'{Direc}', '{ComID}'");
            }
        }
        public void UpdateMovie(string ID, string Name, int Cost, string Time, string Actor, string Direc, string ComID)
        {
            CinemaDataContext cinemaDataContext = new CinemaDataContext();
            TimeSpan runTime;
            if (TimeSpan.TryParse(Time, out runTime))
            {
                cinemaDataContext.ExecuteCommand($"EXEC Sp_UpdateMovie '{ID}', N'{Name}', '{Cost}', '{Time}', N'{Actor}', N'{Direc}', '{ComID}'");
            }
        }
        public void AddCompany(string Company_ID, string Name, string Email, string Phone, string Address)
        {
            CinemaDataContext cinemaDataContext = new CinemaDataContext();
            cinemaDataContext.ExecuteCommand($"EXEC Sp_AddNewCompany '{Company_ID}', N'{Name}', '{Email}', '{Phone}', '{Address}'");
        }
        public void UpdateCompany(string Company_ID, string Name, string Email, string Phone, string Address)
        {
            CinemaDataContext cinemaDataContext = new CinemaDataContext();
            cinemaDataContext.ExecuteCommand($"EXEC Sp_UpdateCompany '{Company_ID}', N'{Name}', '{Email}', '{Phone}', '{Address}'");
        }
        public void AddRoom(string Room_ID, int MaxSeats, string Screen_Resolution, string Audio_Quality)
        {
            CinemaDataContext cinemaDataContext = new CinemaDataContext();
            cinemaDataContext.ExecuteCommand($"EXEC Sp_AddNewRoom '{Room_ID}', {MaxSeats}, '{Screen_Resolution}', '{Audio_Quality}'");
        }
        public void UpdateRoom(string Room_ID, int MaxSeats, string Screen_Resolution, string Audio_Quality)
        {
            CinemaDataContext cinemaDataContext = new CinemaDataContext();
            cinemaDataContext.ExecuteCommand($"EXEC Sp_UpdateRoom '{Room_ID}', {MaxSeats}, '{Screen_Resolution}', '{Audio_Quality}'");
        }
        public DataTable LoadData(AdminType type)
        {
            using (CinemaDataContext cinemaDataContext = new CinemaDataContext())
            {
                DataTable result = new DataTable();
                switch (type)
                {
                    case AdminType.ShowingInDay:
                        var showinginDays = from showinginDay in cinemaDataContext.View_ShowingInDays select showinginDay;
                        result.Columns.Add("ShowTime_ID", typeof(string));
                        result.Columns.Add("Movie_Title", typeof(string));
                        result.Columns.Add("Total_Cost", typeof(decimal));
                        result.Columns.Add("Main_Actor", typeof(string));
                        result.Columns.Add("Director", typeof(string));
                        result.Columns.Add("Date", typeof(DateTime));
                        result.Columns.Add("Start_Time", typeof(TimeSpan));
                        result.Columns.Add("End_Time", typeof(TimeSpan));
                        foreach (var showinginDay in showinginDays)
                        {
                            result.Rows.Add(showinginDay.ShowTime_ID, showinginDay.Movie_Title, showinginDay.Total_Cost, showinginDay.Main_Actor, showinginDay.Director, showinginDay.Date, showinginDay.Start_Time, showinginDay.End_Time);
                        }
                        break;
                    case AdminType.ComingShowing:
                        var commingShowings = from commingShowing in cinemaDataContext.View_ComingShowings select commingShowing;
                        result.Columns.Add("ShowTime_ID", typeof(string));
                        result.Columns.Add("Movie_Title", typeof(string));
                        result.Columns.Add("Total_Cost", typeof(decimal));
                        result.Columns.Add("Main_Actor", typeof(string));
                        result.Columns.Add("Director", typeof(string));
                        result.Columns.Add("Date", typeof(DateTime));
                        result.Columns.Add("Start_Time", typeof(TimeSpan));
                        result.Columns.Add("End_Time", typeof(TimeSpan));
                        foreach (var commingShowing in commingShowings)
                        {
                            result.Rows.Add(commingShowing.ShowTime_ID, commingShowing.Movie_Title, commingShowing.Total_Cost, commingShowing.Main_Actor, commingShowing.Director, commingShowing.Date, commingShowing.Start_Time, commingShowing.End_Time);
                        }
                        break;
                    case AdminType.ClosedShowing:
                        var closedShowings = from closedShowing in cinemaDataContext.View_ClosedShowings select closedShowing;
                        result.Columns.Add("ShowTime_ID", typeof(string));
                        result.Columns.Add("Movie_Title", typeof(string));
                        result.Columns.Add("Total_Cost", typeof(decimal));
                        result.Columns.Add("Main_Actor", typeof(string));
                        result.Columns.Add("Director", typeof(string));
                        result.Columns.Add("Date", typeof(DateTime));
                        result.Columns.Add("Start_Time", typeof(TimeSpan));
                        result.Columns.Add("End_Time", typeof(TimeSpan));
                        foreach (var closedShowing in closedShowings)
                        {
                            result.Rows.Add(closedShowing.ShowTime_ID, closedShowing.Movie_Title, closedShowing.Total_Cost, closedShowing.Main_Actor, closedShowing.Director, closedShowing.Date, closedShowing.Start_Time, closedShowing.End_Time);
                        }
                        break;
                    case AdminType.Reservation:
                        var Reservations = from Reservation in cinemaDataContext.Reservations select Reservation;
                        result.Columns.Add("Reservation ID");
                        result.Columns.Add("User ID");
                        result.Columns.Add("ShowTime ID");
                        result.Columns.Add("Seat");
                        result.Columns.Add("Paid");
                        foreach (var Reservation in Reservations)
                        {
                            result.Rows.Add(Reservation.Reservation_ID, Reservation.User_ID, Reservation.ShowTime_ID, Reservation.Seat, Reservation.Paid);
                        }
                        break;
                    case AdminType.AllShowTime:
                        var ShowTimes = from ShowTime in cinemaDataContext.ShowTimes select ShowTime;
                        result.Columns.Add("ShowTime ID");
                        result.Columns.Add("Movie ID");
                        result.Columns.Add("Date");
                        result.Columns.Add("Start Time");
                        result.Columns.Add("End Time");
                        result.Columns.Add("Current Seats");
                        result.Columns.Add("Quality Cost");
                        result.Columns.Add("Total Cost");
                        result.Columns.Add("Room ID");
                        foreach (var ShowTime in ShowTimes)
                        {
                            result.Rows.Add(ShowTime.ShowTime_ID, ShowTime.Movie_ID, ShowTime.Date, ShowTime.Start_Time, ShowTime.End_Time, ShowTime.Current_Seats, ShowTime.Quality_Cost, ShowTime.Total_Cost, ShowTime.Room_ID);
                        }
                        break;
                    case AdminType.AllMovies:
                        var Movies = from Movie in cinemaDataContext.Movies select Movie;
                        result.Columns.Add("Movie ID");
                        result.Columns.Add("Movie Title");
                        result.Columns.Add("Movie Cost");
                        result.Columns.Add("Runtime");
                        result.Columns.Add("Main Actor");
                        result.Columns.Add("Director");
                        result.Columns.Add("Company ID");
                        foreach (var Movie in Movies)
                        {
                            result.Rows.Add(Movie.Movie_ID, Movie.Movie_Title, Movie.Movie_Cost, Movie.Runtime, Movie.Main_Actor, Movie.Director, Movie.Company_ID);
                        }
                        break;
                    case AdminType.Company:
                        var Companies = from Company in cinemaDataContext.Companies select Company;
                        result.Columns.Add("Company ID");
                        result.Columns.Add("Name");
                        result.Columns.Add("Email");
                        result.Columns.Add("Phone");
                        result.Columns.Add("Address");
                        foreach (var Company in Companies)
                        {
                            result.Rows.Add(Company.Company_ID, Company.Name, Company.Email, Company.Phone, Company.Address);
                        }
                        break;
                    case AdminType.Room:
                        var Rooms = from Room in cinemaDataContext.Rooms select Room;
                        result.Columns.Add("Room ID");
                        result.Columns.Add("Max Seats");
                        result.Columns.Add("Screen Resolution");
                        result.Columns.Add("Audio Quality");
                        foreach (var Room in Rooms)
                        {
                            result.Rows.Add(Room.Room_ID, Room.MaxSeats, Room.Screen_Resolution, Room.Audio_Quality);
                        }
                        break;
                }
                return result;
            }
        }
    }
}
