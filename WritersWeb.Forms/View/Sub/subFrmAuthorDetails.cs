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
    public partial class subFrmAuthorDetails : Form
    {
        public subFrmAuthorDetails()
        {
            InitializeComponent();
            GForm.LoadForm(this, GForm.Type.Sub, () => {
                GForm.HideFormBorder(this);
                GForm.AddDraggable(pnlMain);
                GForm.AddDraggable(lblTitle);
                GForm.AddButtonClose(btnClose);
            });
        }

        public static class CallType
        {
            public static string viewAuthorDetails { get { return "view_author"; } }
            public static string addLead { get { return "add_lead"; } }
            public static string addLeadExistingAuthor { get { return "add_lead_existing_author"; } }
        }

        public bool enableEdit
        {
            set
            {
                txtLName.Enabled = value;
                txtFName.Enabled = value;
                txtMName.Enabled = value;
                txtEmail.Enabled = value;
                txtEmailAlt.Enabled = value;
                txtPhoneHome.Enabled = value;
                txtPhoneMobile.Enabled = value;
                txtPhoneOffice.Enabled = value;
                txtPhoneOther.Enabled = value;
                txtCountry.Enabled = value;
                txtState.Enabled = value;
                txtCity.Enabled = value;
                txtStreet.Enabled = value;
                txtPostalCode.Enabled = value;
            }
        }

        public void ManageControlVisibility(string callType)
        {
            if (callType == CallType.viewAuthorDetails)
            {
                btnSubmit.Text = "SAVE";
                btnCancel.Hide();
                btnContinue.Hide();btnContinueSpace.Hide();
                btnSubmit.Hide();btnSubmitSpace.Hide();
                btnEdit.Show(); btnEditSpace.Hide();
                enableEdit = false;
            }
            else if (callType == CallType.addLead)
            {
                btnSubmit.Text = "SUBMIT";
                btnCancel.Show();
                btnContinue.Show();btnContinueSpace.Show();
                btnSubmit.Hide();btnSubmitSpace.Hide();
                btnEdit.Hide();btnEditSpace.Hide();
                enableEdit = true;
            }
            else if (callType == CallType.addLeadExistingAuthor)
            {
                btnSubmit.Text = "SUBMIT";
                btnCancel.Show();
                btnContinue.Show();btnContinueSpace.Show();
                btnSubmit.Hide(); btnSubmitSpace.Hide();
                btnEdit.Show();btnEditSpace.Show();
                enableEdit = false;
            }
        }
    }
}
