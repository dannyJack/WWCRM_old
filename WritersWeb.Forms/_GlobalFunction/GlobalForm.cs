using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WritersWeb.View;

namespace WritersWeb.Func
{
    public class GForm
    {
        #region Inner Class
        public static class Type
        {
            public static string Main { get { return "main"; } }
            public static string Primary { get { return "primary"; } }
            public static string Sub { get { return "sub"; } }
        }
        #endregion

        #region Private Variables
        private static Form FormBackDrop;
        private static bool mouse_isHold = false;
        private static int[] mouse_position = { 0, 0 };
        private static string frmCURRENT;
        #endregion

        #region Public Variables
        public static Dictionary<string, Form> forms = new Dictionary<string, Form>();

        public static Form BackDrop
        {
            get
            {
                if (FormBackDrop == null) FormBackDrop = new Form();
                FormBackDrop.WindowState = FormWindowState.Maximized;
                FormBackDrop.BackColor = System.Drawing.Color.Black;
                FormBackDrop.Opacity = 0.5D;
                FormBackDrop.FormBorderStyle = FormBorderStyle.None;
                //FormBackDrop.MdiParent = GForm.FrmMain;
                FormBackDrop.BringToFront();
                //FormBackDrop.IsMdiContainer = true;
                return FormBackDrop;
            }
        }

        //OUTSIDE FORM
        public static frmLogin FrmLogin { get { return (forms.ContainsKey("frmLogin") ? forms["frmLogin"] as frmLogin : FrmLogin = new frmLogin()); } set { forms[value.Name] = value; } }
        public static frmMain FrmMain { get { return (forms.ContainsKey("frmMain") ? forms["frmMain"] as frmMain : FrmMain = new frmMain()); } set { forms[value.Name] = value; } }

        //PRIMARY FORM
        public static frmDashboard FrmDashboard { get { return (forms.ContainsKey("frmDashboard") ? forms["frmDashboard"] as frmDashboard : FrmDashboard = new frmDashboard()); } set { forms[value.Name] = value; } }
        public static frmAdmin FrmAdmin { get { return (forms.ContainsKey("frmAdmin") ? forms["frmAdmin"] as frmAdmin : FrmAdmin = new frmAdmin()); } set { forms[value.Name] = value; } }
        public static frmEmployee FrmEmployee { get { return (forms.ContainsKey("frmEmployee") ? forms["frmEmployee"] as frmEmployee : FrmEmployee = new frmEmployee()); } set { forms[value.Name] = value; } }
        public static frmSales FrmSales { get { return (forms.ContainsKey("frmSales") ? forms["frmSales"] as frmSales : FrmSales = new frmSales()); } set { forms[value.Name] = value; } }
        public static frmLead FrmLead { get { return (forms.ContainsKey("frmLead") ? forms["frmLead"] as frmLead : FrmLead = new frmLead()); } set { forms[value.Name] = value; } }
        public static frmFulfillment FrmFulfillment { get { return (forms.ContainsKey("frmFulfillment") ? forms["frmFulfillment"] as frmFulfillment : FrmFulfillment = new frmFulfillment()); } set { forms[value.Name] = value; } }
        public static frmProduction FrmProduction { get { return (forms.ContainsKey("frmProduction") ? forms["frmProduction"] as frmProduction : FrmProduction = new frmProduction()); } set { forms[value.Name] = value; } }
        public static frmTrack FrmTrack { get { return (forms.ContainsKey("frmTrack") ? forms["frmTrack"] as frmTrack : FrmTrack = new frmTrack()); } set { forms[value.Name] = value; } }
        public static frmMemo FrmMemo { get { return (forms.ContainsKey("frmMemo") ? forms["frmMemo"] as frmMemo : FrmMemo = new frmMemo()); } set { forms[value.Name] = value; } }
        public static frmSetting FrmSetting { get { return (forms.ContainsKey("frmSetting") ? forms["frmSetting"] as frmSetting : FrmSetting = new frmSetting()); } set { forms[value.Name] = value; } }
        public static frmReports FrmReports { get { return (forms.ContainsKey("frmReports") ? forms["frmReports"] as frmReports : FrmReports = new frmReports()); } set { forms[value.Name] = value; } }

        //SUB FORM
        public static subFrmAddLead SubFrmAddLead { get { return (forms.ContainsKey("subFrmAddLead") ? forms["subFrmAddLead"] as subFrmAddLead : SubFrmAddLead = new subFrmAddLead()); } set { forms[value.Name] = value; } }
        public static frmAddEmployee FrmSubEmployeeAdd { get { return (forms.ContainsKey("frmAddEmployee") ? forms["frmAddEmployee"] as frmAddEmployee : FrmSubEmployeeAdd = new frmAddEmployee()); } set { forms[value.Name] = value; } }
        public static frmAddMemo FrmSubMemoAdd { get { return (forms.ContainsKey("frmAddMemo") ? forms["frmAddMemo"] as frmAddMemo : FrmSubMemoAdd = new frmAddMemo()); } set { forms[value.Name] = value; } }
        public static frmPayment FrmSubPayment { get { return (forms.ContainsKey("frmPayment") ? forms["frmPayment"] as frmPayment : FrmSubPayment = new frmPayment()); } set { forms[value.Name] = value; } }
        public static frmPurchase FrmSubPurchase { get { return (forms.ContainsKey("frmPurchase") ? forms["frmPurchase"] as frmPurchase : FrmSubPurchase = new frmPurchase()); } set { forms[value.Name] = value; } }
        public static frmAddAdmin FrmSubAdminAdd { get { return (forms.ContainsKey("frmAddAdmin") ? forms["frmAddAdmin"] as frmAddAdmin : FrmSubAdminAdd = new frmAddAdmin()); } set { forms[value.Name] = value; } }
        public static subFrmAuthorDetails SubFrmAuthorDetails { get { return (forms.ContainsKey("subFrmAuthorDetails") ? forms["subFrmAuthorDetails"] as subFrmAuthorDetails : SubFrmAuthorDetails = new subFrmAuthorDetails()); } set { forms[value.Name] = value; } }
        #endregion

        #region Public Functions

        public static Form FetchForm(string formName, bool isNew)
        {
            if (isNew) forms.Remove(formName);
            Form f;
            if (formName == "frmLogin") f = FrmLogin;
            else if (formName == "frmMain") f = FrmMain;
            else if (formName == "frmDashboard") f = FrmDashboard;
            else if (formName == "frmAdmin") f = FrmAdmin;
            else if (formName == "frmEmployee") f = FrmEmployee;
            else if (formName == "frmSales") f = FrmSales;
            else if (formName == "frmLead") f = FrmLead;
            else if (formName == "frmFulfillment") f = FrmFulfillment;
            else if (formName == "frmProduction") f = FrmProduction;
            else if (formName == "frmTrack") f = FrmTrack;
            else if (formName == "frmMemo") f = FrmMemo;
            else if (formName == "frmSetting") f = FrmSetting;
            else if (formName == "frmReports") f = FrmReports;
            else if (formName == "subFrmAddLead") f = SubFrmAddLead = new subFrmAddLead();
            else if (formName == "frmSubEmployeeAdd") f = FrmSubEmployeeAdd;
            else if (formName == "frmSubMemoAdd") f = FrmSubMemoAdd;
            else if (formName == "frmSubPayment") f = FrmSubPayment;
            else if (formName == "frmSubPurchase") f = FrmSubPurchase;
            else if (formName == "frmSubAdminAdd") f = FrmSubAdminAdd;
            else if (formName == "subFrmAuthorDetails") f = SubFrmAuthorDetails;
            else f = null;
            return f;
        }

        public static Form Current
        {
            get { return forms[frmCURRENT]; }
            set
            {
                frmCURRENT = value.Name;
                forms[frmCURRENT] = value;
                forms[frmCURRENT].MouseDown += new System.Windows.Forms.MouseEventHandler(ev_MouseDown);
                forms[frmCURRENT].MouseMove += new System.Windows.Forms.MouseEventHandler(ev_MouseMove);
                forms[frmCURRENT].MouseUp += new System.Windows.Forms.MouseEventHandler(ev_MouseUp);
            }
        }

        public static void CloseFormPanels()
        {
            foreach (KeyValuePair<string, Form> obj in forms)
            {
                var ctrl = obj.Value.Controls.Find("pnlMain", true);
                if (ctrl.Length != 0)
                    ctrl[0].Hide();
                var ctrl2 = Current.Controls.Find("pnlMain" + obj.Value.Name, true);
                if (ctrl2.Length != 0)
                    ctrl2[0].Hide();
            }
        }

        public static void AddDraggable(Control c, bool syncForm = true)
        {
            if (Current != null)
            {
                var ctrl = Current.Controls.Find(c.Name, true);
                if (ctrl.Length != 0)
                {
                    BFunc.Tag.Set(ctrl[0], BFunc.Tag.Key.SyncForm, syncForm);
                    ctrl[0].MouseDown += new System.Windows.Forms.MouseEventHandler(ev_MouseDown);
                    ctrl[0].MouseMove += new System.Windows.Forms.MouseEventHandler(ev_MouseMove);
                    ctrl[0].MouseUp += new System.Windows.Forms.MouseEventHandler(ev_MouseUp);
                }
            }
        }

        public static void AddButtonClose(Control c)
        {
            BFunc.Tag.Set(c, BFunc.Tag.Key.ParentForm, Current.Name);
            c.Click += new System.EventHandler(ev_FormClose);
        }

        public static void AddButtonMaximumMinimum(Control c)
        {
            c.Tag = Current.Name;
            c.Click += new System.EventHandler(ev_FormMaximumMinimum);
        }

        public static void AddButtonMaximizeMinimize(Control c)
        {
            c.Tag = Current.Name;
            c.Click += new System.EventHandler(ev_FormMaximizeMinimize);
        }

        public static void EventMaker(Control c, string type, object[] p)
        {
            if (type == "slide_down")
            {
                //p[0] = minimum height
                //p[1] = maximum height
                if (p[0] is int && p[1] is int)
                {
                    object[] control_tag = { type, p[0], p[1] };
                    c.Tag = control_tag;
                    c.Click += new EventHandler(ev_CustomClick);
                }
            }
        }

        public static void LoadForm(Form frm, string FormType = null, Action callBackFuncOnFirstLoad = null, Action callBackFuncOnLoad = null, Action callBackFuncOnClose = null)
        {
            if (FormType != Type.Main)
            {
                Panel pnl = null;
                var pnlMain = frm.Controls.Find("pnlMain", true);
                var pnlMain_transferred = frm.Controls.Find("pnlMain" + frm.Name, true);
                if (pnlMain.Length != 0)
                    pnl = pnlMain[0] as Panel;
                else if (pnlMain_transferred.Length != 0)
                    pnl = pnlMain_transferred[0] as Panel;
                if (pnl != null)
                {
                    pnl.VisibleChanged += new EventHandler((object s, EventArgs e) =>
                    {
                        if (pnl.Visible)
                        {
                            if (BFunc.Tag.Is(frm, BFunc.Tag.Key.IsFormLoaded,null))
                            {
                                BFunc.Tag.Set(frm, BFunc.Tag.Key.FormType, FormType);
                                BFunc.Tag.Set(frm, BFunc.Tag.Key.IsFormLoaded, true);
                                if (callBackFuncOnFirstLoad != null) callBackFuncOnFirstLoad();
                            }
                            if (callBackFuncOnLoad != null)
                                callBackFuncOnLoad();
                        }
                        else
                        {
                            if (callBackFuncOnClose != null)
                            {
                                BFunc.Tag.Set(frm, BFunc.Tag.Key.IsFormLoaded, null);
                                if (BFunc.Tag.Is(frm, BFunc.Tag.Key.IsPopUpForm, true))
                                    MessageBox.Show("Invalid Callback function onClose for this form. This form is popup type. Popup type close event should be initialize on the button sender.");
                                else callBackFuncOnClose();
                            }
                        }
                    });
                }
            }
            else
            {
                if (frm.Tag == null)
                {
                    frm.Tag = "Loaded";
                    if (callBackFuncOnFirstLoad != null) callBackFuncOnFirstLoad();
                }
            }
        }

        public static void HideFormBorder(Form frm)
        {
            frm.FormBorderStyle = FormBorderStyle.None;
        }
        #endregion

        #region Private Functions
        private static void ev_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse_isHold)
            {
                var ctrl = (Control)sender;
                var IsSyncForm = BFunc.Tag.Get(ctrl, BFunc.Tag.Key.SyncForm);
                if (IsSyncForm != null ? (bool)IsSyncForm == false : false)
                    ctrl.Location = new System.Drawing.Point(ctrl.Location.X + e.X - mouse_position[0], ctrl.Location.Y + e.Y - mouse_position[1]);
                else
                    forms[frmCURRENT].Location = new System.Drawing.Point(forms[frmCURRENT].Location.X + e.X - mouse_position[0], forms[frmCURRENT].Location.Y + e.Y - mouse_position[1]);
            }
        }

        private static void ev_MouseUp(object sender, MouseEventArgs e)
        {
            mouse_isHold = false;
        }

        private static void ev_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouse_isHold = true;
                mouse_position[0] = e.X;
                mouse_position[1] = e.Y;
            }
            else mouse_isHold = false;
        }

        private static void ev_FormClose(object sender, EventArgs e)
        {
            var ctrl = sender as Control;
            BackDrop.Hide();
            if(BFunc.Tag.Get(ctrl, BFunc.Tag.Key.ParentForm) != null)
            {
                string frm_name = BFunc.Tag.Get(ctrl, BFunc.Tag.Key.ParentForm).ToString();
                if (forms.ContainsKey(frm_name))
                {
                    Form frm = (forms[frm_name] as Form);
                    frm.Close();
                    if (BFunc.Tag.Is(frm, BFunc.Tag.Key.IsFormReloadOnClick, true))
                    {
                        //MessageBox.Show(frm.Name);
                        //frm.Dispose();
                        forms.Remove(frm_name);
                    }
                }
            }
        }

        private static void ev_FormMaximumMinimum(object sender, EventArgs e)
        {
            var btn_tag = (sender as Control).Tag;
            if (btn_tag != null)
            {
                var frm = (forms[btn_tag.ToString()] as Form);
                if (frm.WindowState == FormWindowState.Maximized)
                    frm.WindowState = FormWindowState.Normal;
                else frm.WindowState = FormWindowState.Maximized;
            }
        }

        private static void ev_FormMaximizeMinimize(object sender, EventArgs e)
        {
            var btn_tag = (sender as Control).Tag;
            if (btn_tag != null)
            {
                var frm = (forms[btn_tag.ToString()] as Form);
                frm.WindowState = FormWindowState.Minimized;
            }
        }

        private static void ev_CustomClick(object sender, EventArgs e)
        {
            MessageBox.Show("1");
            var btn = sender as Control;
            if (btn.Tag != null && btn.Tag is object)
            {
                MessageBox.Show("2");
                var btn_tag = btn.Tag as object[];
                if (btn_tag[0].ToString() == "slide_down")
                {
                    MessageBox.Show("3");
                    if (btn_tag[0] is int && btn_tag[1] is int)
                    {
                        MessageBox.Show("4");
                        if (btn.Height <= int.Parse(btn_tag[1].ToString()))
                            btn.Height = int.Parse(btn_tag[2].ToString());
                        else btn.Height = int.Parse(btn_tag[1].ToString());
                    }
                }
            }
        }
        #endregion
    }
}
