using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WritersWeb.Func;

namespace WritersWeb.View
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            GForm.LoadForm(this, GForm.Type.Primary, () =>
            {
                //MessageBox.Show("Dashboard");

            });
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
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
