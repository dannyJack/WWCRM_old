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
using WritersWeb.Base;
using WritersWeb.Data;
using WritersWeb.Controller;

namespace WritersWeb.View
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            GForm.Current = GForm.FrmLogin = this;
            GForm.AddDraggable(sideNav);
            GForm.AddButtonClose(labelX5);
            GForm.AddButtonMaximizeMinimize(labelX4);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            GForm.FrmMain.ShowDialog();
            this.Show();
            GForm.Current = this;
        }

        private void txt_pword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnLogin_Click(null, null);
            }
        }
    }
}
