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
                GForm.FrmMain.assignButtonClick(btnAddLead, new object[] { GForm.FrmSubLeadAdd }, true, () => {
                    GForm.FrmSubLeadAdd.lblTitle.Text = "Add New Lead";
                    GForm.FrmSubAuthorDetails.pnlMain.Parent = GForm.FrmSubLeadAdd.pnlStep1;
                });
                GForm.FrmMain.assignButtonClick(btnViewAuthor, new object[] { GForm.FrmSubAuthorDetails }, true, () => {
                    GForm.FrmSubAuthorDetails.pnlMain.Parent = GForm.FrmSubAuthorDetails;
                });
            }, GForm.Type.Primary);
        }

        private void loadAuthor()
        {

        }
    }
}
