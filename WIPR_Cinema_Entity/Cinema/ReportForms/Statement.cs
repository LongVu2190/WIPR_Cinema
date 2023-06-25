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
    public partial class Statement : Form
    {
        string ID;
        public Statement()
        {
            InitializeComponent();
        }
        public Statement(string ID)
        {
            InitializeComponent();
            this.ID = ID;
        }

        private void Statement_Load(object sender, EventArgs e)
        {
            this.statementTableAdapter.Fill(this.cinemaDataSet.Statement, ID);

            this.reportViewer1.RefreshReport();
        }
    }
}
