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
    public partial class frmLead : Form
    {
        public frmLead()
        {
            InitializeComponent();
            GForm.LoadForm(this, () => {
                //MessageBox.Show("LOADIN LEAD");
                GForm.FrmMain.assignButtonClick(btnAddLead, new object[] { GForm.FrmSubLeadAdd }, true);
            }, GForm.Type.Primary);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //frmMain ev = new frmMain();
            //ev.btn_MouseClick(sender as DevComponents.DotNetBar.ButtonX, e);
        }
    }
}
