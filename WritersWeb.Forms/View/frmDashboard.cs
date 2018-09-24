using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WritersWeb.Forms.Controller;

namespace WritersWeb.View
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            this.graph();
        }

        void graph()
        {
            this.chart1.Series["BookCover"].Points.AddXY("Daily", 1000);
            this.chart1.Series["BookCover"].Points.AddXY("Weekly", 1500);
            this.chart1.Series["BookCover"].Points.AddXY("Monthly", 2000);

            this.chart1.Series["Website"].Points.AddXY("Daily", 1000);
            this.chart1.Series["Website"].Points.AddXY("Weekly", 1500);
            this.chart1.Series["Website"].Points.AddXY("Monthly", 2000);

            this.chart1.Series["Multimedia"].Points.AddXY("Daily", 1000);
            this.chart1.Series["Multimedia"].Points.AddXY("Weekly", 1500);
            this.chart1.Series["Multimedia"].Points.AddXY("Monthly", 2000);


            StatisticsController repoStudents = new StatisticsController();

            lblCountLeads.Text = repoStudents.getCountLeads.ToString();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}
