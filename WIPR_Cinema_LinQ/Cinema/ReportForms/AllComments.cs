using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema.ReportForms
{
    public partial class AllComments : Form
    {
        public AllComments()
        {
            InitializeComponent();
        }

        private void AllComments_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cinemaDataSet.View_Comments' table. You can move, or remove it, as needed.
            this.view_CommentsTableAdapter.Fill(this.cinemaDataSet.View_Comments);

            this.reportViewer1.RefreshReport();
        }
    }
}
