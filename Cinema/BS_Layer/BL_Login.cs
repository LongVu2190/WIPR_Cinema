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

        public BL_Login() { }
        public void AdminLogin(string User_ID, string Password, ref User admin, ref bool result)
        {
            string sql = $"select * from Fn_AdminLogin('{User_ID}', '{Password}')";
            db.AdminLogin(sql, ref admin, ref result);
        }
        public void CustomerLogin(string User_ID, string Password, ref User cus, ref bool result)
        {
            string sql = $"select * from Fn_CustomerLogin('{User_ID}', '{Password}')";
            db.CustomerLogin(sql, ref cus, ref result);
        }
        public void Register(string User_ID, string Password, string Name, string Email, string Address, string Phone)
        {
            string sql = $"exec Sp_AddNewCustomer '{User_ID}', '{Password}', N'{Name}', '{Email}', '{Address}', '{Phone}'";
            db.MyExecuteNonQuery(sql);
        }
    }
}
