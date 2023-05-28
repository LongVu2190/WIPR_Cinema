using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Policy;

namespace Cinema.DB_Layer
{
    internal class DBMain
    {
        string strConnectionString = "Data Source=localhost;Initial Catalog=Cinema;Integrated Security=False;User ID=sa;Password=123456";

        SqlConnection con = null;
        SqlDataAdapter sql_data = null;
        DataTable data = null;

        public DBMain()
        {
            con = new SqlConnection(strConnectionString);
        }
        public DataTable LoadData(string sql)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();

            sql_data = new SqlDataAdapter(sql, con);
            data = new DataTable();
            sql_data.Fill(data);

            return data;
        }
        public void MyExecuteNonQuery(string sql)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }
    }
}
