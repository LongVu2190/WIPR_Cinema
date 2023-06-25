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
    public partial class Register : Form
    {
        BL_Login bs = new BL_Login();
        public Register()
        {
            InitializeComponent();
        }

        private void Register_btn_Click(object sender, EventArgs e)
        {
            if (UserID_tb.Text == "" ||
                Password_tb.Text == "" ||
                Name_tb.Text == "" ||
                Email_tb.Text == "" ||
                Address_tb.Text == "" ||
                Phone_tb.Text == "")
            {
                MessageBox.Show("Fill in the blank");
                return;
            }               
            try
            {
                bs.Register(UserID_tb.Text, Password_tb.Text, Name_tb.Text, Email_tb.Text, Address_tb.Text, Phone_tb.Text);
                MessageBox.Show("Created Successfully");
                base.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notification");
            }
        }
    }
}
