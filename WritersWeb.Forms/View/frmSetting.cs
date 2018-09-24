using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WritersWeb.View
{
    public partial class frmSetting : Form
    {
        public frmSetting()
        {
            InitializeComponent();
            this.graph();
        }
        void graph()
        {
            this.chart1.Series["Sales"].Points.AddXY("Joe", 1000);
            this.chart1.Series["Sales"].Points.AddXY("Daniel", 1500);
            this.chart1.Series["Sales"].Points.AddXY("Jay-ar", 2000);
        }
    }
}
