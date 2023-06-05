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
    public partial class Comment : Form
    {
        BL_Cinema bs = new BL_Cinema();
        string Reservation_ID = "";
        public Comment()
        {
            InitializeComponent();
        }
        public Comment(string Reservation_ID)
        {
            InitializeComponent();
            this.Reservation_ID = Reservation_ID;
        }

        private void Comment_Load(object sender, EventArgs e)
        {           
            Reservation_ID_tb.Text = Reservation_ID;
            Point_tb.Focus();
        }

        private void Comment_btn_Click(object sender, EventArgs e)
        {
            try
            {
                bs.AddOrUpdateComment(Convert.ToInt32(Reservation_ID), Convert.ToInt32(Point_tb.Text), Comment_tb.Text);
                MessageBox.Show("Commented");
                base.Close();
            }
            catch 
            {
                MessageBox.Show("Error");
            }
        }
    }
}
