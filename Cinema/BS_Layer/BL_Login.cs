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
    internal class BL_Login
    {
        DBMain db = new DBMain();
        DataTable myTable = new DataTable();
        string data;
        public BL_Login() { }
        public User AdminLogin(string User_ID, string Password)
        {
            string sql = $"select * from Fn_AdminLogin('{User_ID}', '{Password}')";
            User admin = new User();
            myTable = db.LoadData(sql);

            foreach (DataRow row in myTable.Rows)
            {
                admin.User_ID = row["User_ID"].ToString();
                admin.Name = row["User_Name"].ToString();
                admin.Role = row["Admin_Role"].ToString();
            }
            return admin;
        }
        public User CustomerLogin(string User_ID, string Password)
        {
            string sql = $"select * from Fn_CustomerLogin('{User_ID}', '{Password}')";

            User customer = new User();
            myTable = db.LoadData(sql);

            foreach (DataRow row in myTable.Rows)
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
        public void Register(string User_ID, string Password, string Name, string Email, string Address, string Phone)
        {
            string sql = $"exec Sp_AddNewCustomer '{User_ID}', '{Password}', N'{Name}', '{Email}', '{Address}', '{Phone}'";
            db.MyExecuteNonQuery(sql);
        }
    }
}
