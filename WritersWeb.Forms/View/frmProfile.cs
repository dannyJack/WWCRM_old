using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using WritersWeb.Base;
using WritersWeb.Confirmation;

namespace WritersWeb.View
{
    public partial class frmProfile : Form
    {
        public frmProfile()
        {
            InitializeComponent();
        }
        
        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProfile_Load(object sender, EventArgs e)
        {
            txtFirstname.Text = UserProfile.Firstname;
            txtLastname.Text = UserProfile.Lastname;
            txtMiddlename.Text = UserProfile.Middlename;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // type of validate message
            //Alert.Message("Info", "info");
            //Alert.Message("Success", "success");
            //Alert.Message("Error", "error");
            //Alert.Message("Warning", "warning");

            //confirmation dialog
            Alert.Confirmation("Are you sure you want to delete this Item");
        }
    }
}
