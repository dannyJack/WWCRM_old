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
            Authenticates.CriteriaInfo authParams = new Authenticates.CriteriaInfo();
            string username = txt_uname.Text,
                    password = txt_pword.Text;
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                authParams.Username = username;
                authParams.Password = password;
                if (Account.AuthenticateUser(authParams) > 0)
                {
                    Authenticate aut = new Authenticate();
                    Object resObj = new Object();
                    List<object> auth = new List<object>();
                    auth = Account.AuthResult(authParams);
                    //((WritersWeb.Data.Authenticate)new System.Collections.Generic.Mscorlib_CollectionDebugView<object>(auth).Items[0]).Fullname
                    resObj = Account.AuthResult(authParams);

                    this.Hide();
                    GForm.FrmMain.ShowDialog();
                    this.Show();
                    GForm.Current = this;

                    //frmMain open = new frmMain();
                    //open.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Fields missing!!!");
            }       
        }
    }
}
