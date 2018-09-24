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
            GForm.LoadForm(this, GForm.Type.Primary, () =>
            {
                GForm.FrmMain.assignButtonClick(btnAddLead, GForm.SubFrmAddLead,true , true, () =>
                {
                    GForm.SubFrmAddLead.lblTitle.Text = "ADD NEW LEAD";
                    GForm.SubFrmAuthorDetails.ManageControlVisibility(subFrmAuthorDetails.CallType.addLead);
                    GForm.SubFrmAuthorDetails.pnlSub.Parent = GForm.SubFrmAddLead.pnlStep1;

                    GForm.SubFrmAuthorDetails.txtLName.Text = txtLName.Text;
                    GForm.SubFrmAuthorDetails.txtFName.Text = txtFName.Text;
                    GForm.SubFrmAuthorDetails.txtMName.Text = txtMName.Text;
                    GForm.SubFrmAuthorDetails.txtPhoneMobile.Text = txtPhone.Text;
                }, () => {
                    GForm.SubFrmAuthorDetails.pnlSub.Parent = GForm.SubFrmAuthorDetails.pnlMain;
                });

                GForm.FrmMain.assignButtonClick(btnAddLeadExistingAuthor, GForm.SubFrmAddLead, true, true, () =>
                {
                    GForm.SubFrmAddLead.lblTitle.Text = "ADD NEW LEAD TO EXISTING AUTHOR";
                    GForm.SubFrmAuthorDetails.ManageControlVisibility(subFrmAuthorDetails.CallType.addLeadExistingAuthor);
                    GForm.SubFrmAuthorDetails.pnlSub.Parent = GForm.SubFrmAddLead.pnlStep1;
                });

                GForm.FrmMain.assignButtonClick(btnViewAuthor, GForm.SubFrmAuthorDetails, false, true, () =>
                {
                    GForm.SubFrmAuthorDetails.ManageControlVisibility(subFrmAuthorDetails.CallType.viewAuthorDetails);
                    GForm.SubFrmAuthorDetails.pnlSub.Parent = GForm.SubFrmAuthorDetails.pnlMain;
                });
            }, () =>
             {
                 this.txtLName.Focus();
             });
        }

        private void loadAuthor()
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
        }
    }
}
