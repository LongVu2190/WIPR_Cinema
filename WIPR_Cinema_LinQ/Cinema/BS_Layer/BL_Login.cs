using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema.BS_Layer
{
    internal class BL_Login
    {
        public BL_Login() { }
        string data;
        public User_Object AdminLogin(string User_ID, string Password)
        {
            DataTable dataTable = new DataTable();
            using (CinemaDataContext cinemaDataContext = new CinemaDataContext())
            {
                var adminLogin = from adLogin in cinemaDataContext.Fn_AdminLogin(User_ID, Password)
                                 select adLogin;
                dataTable.Columns.Add("User_ID", typeof(string));
                dataTable.Columns.Add("User_Name", typeof(string));
                dataTable.Columns.Add("Admin_Role", typeof(string));
                foreach (var adLogin in adminLogin)
                {
                    dataTable.Rows.Add(adLogin.User_ID, adLogin.User_Name, adLogin.Admin_Role);
                }
                User_Object admin = new User_Object();
                foreach (DataRow row in dataTable.Rows)
                {
                    admin.User_ID = row["User_ID"].ToString();
                    admin.Name = row["User_Name"].ToString();
                    admin.Role = row["Admin_Role"].ToString();
                }
                return admin;
            }
        }
        public User_Object CustomerLogin(string User_ID, string Password)
        {
            using (CinemaDataContext cinemaDataContext = new CinemaDataContext())
            {
                DataTable dataTable = new DataTable();
                var customerLogin = from cusLogin in cinemaDataContext.Fn_CustomerLogin(User_ID, Password)
                                    select cusLogin;
                dataTable.Columns.Add("User_ID", typeof(string));
                dataTable.Columns.Add("User_Name", typeof(string));
                dataTable.Columns.Add("Balance", typeof(decimal));
                dataTable.Columns.Add("Point", typeof(int));
                dataTable.Columns.Add("isVip", typeof(bool));
                foreach (var cusLogin in customerLogin)
                {
                    dataTable.Rows.Add(cusLogin.User_ID, cusLogin.User_Name,
                        cusLogin.Balance, cusLogin.Point, cusLogin.isVip);
                }
                User_Object customer = new User_Object();
                foreach (DataRow row in dataTable.Rows)
                {
                    customer.User_ID = row["User_ID"].ToString();
                    customer.Name = row["User_Name"].ToString();
                    data = row["Balance"].ToString();
                    customer.Balance = int.Parse(data);
                    data = row["Point"].ToString();
                    customer.Point = int.Parse(data);
                    data = row["isVip"].ToString();
                    customer.isVip = Boolean.Parse(data);
                }
                return customer;
            }
        }
        public void Register(string User_ID, string Password, string Name, string Email, string Address, string Phone)
        {
            using (CinemaDataContext cinemaDataContext = new CinemaDataContext())
            {
                cinemaDataContext.ExecuteCommand($"exec Sp_AddNewCustomer '{User_ID}', '{Password}', N'{Name}', '{Email}', '{Address}', '{Phone}'");
            }
        }
    }
}
