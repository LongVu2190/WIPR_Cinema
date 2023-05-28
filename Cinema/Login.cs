using Cinema.BS_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class Login : Form
    {
        User user = new User();
        BL_Login bs = new BL_Login();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Admin_cb.Checked)
                {
                    user = bs.AdminLogin(UserID_tb.Text, Password_tb.Text);
                }
                else
                {
                    user = bs.CustomerLogin(UserID_tb.Text, Password_tb.Text);
                }
            
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notification");
            }
           
            if (user.User_ID == UserID_tb.Text) 
            {
                MessageBox.Show("Login Successfully");
                this.Hide();
                if (Admin_cb.Checked)
                    new Admin { admin = this.user }.ShowDialog();
                else
                    new Booking { cus = this.user }.ShowDialog();
                base.Close();
            }
            else
            {
                MessageBox.Show("Failed");
            }
        }

        private void Register_btn_Click(object sender, EventArgs e)
        {
            new Register { }.ShowDialog();
        }
        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login_btn_Click(sender, e);
            }
        }

        private void Password_cb_Click(object sender, EventArgs e)
        {
            this.Password_tb.UseSystemPasswordChar = !Password_cb.Checked;
        }
    }
}
