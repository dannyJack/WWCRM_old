using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WritersWeb.View;

using WritersWeb.Func;
using WritersWeb.Base;

namespace WritersWeb.View
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            //Partial
            btnSales.Hide();
            string user = "lead";
            if (user != "super_admin")
                btnAdmin.Hide();
            if (user != "super_admin" && user != "HR")
                btnEmployee.Hide();
            if (user != "super_admin" && user != "admin_lead" && user != "admin_sales" && user != "lead" && user != "sales")
                btnLeads.Hide();
            if (user != "super_admin" && user != "admin_production" && user != "supervisor_production" && user != "production")
                btnProduction.Hide();
            if (user != "super_admin" && user != "admin_fulfillment" && user != "fulfillment")
                btnFulfillment.Hide();
            if (user != "super_admin" && user != "admin_lead" && user != "admin_sales" && user != "admin_finance" && user != "admin_fulfillment"
                && user != "lead" && user != "sales" && user != "finance" && user != "fulfillment")
                btnTrack.Hide();
            if (user != "super_admin" && user!="HR" && user != "admin_lead" && user != "admin_sales" && user != "admin_finance" && user != "admin_production" && user != "supervisor_production" && user != "admin_fulfillment"
                && user != "lead" && user != "sales" && user != "finance" && user != "production" && user != "fulfillment")
                btnMemo.Hide();
            if (user != "super_admin")
                btnReports.Hide();
            if (user != "super_admin")
                btnSetting.Hide();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            GForm.Current = this;
            GForm.LoadForm(this, GForm.Type.Main, () => {
                GForm.AddDraggable(panelEx1);
                GForm.AddButtonClose(labelX5);
                GForm.AddButtonMaximumMinimum(labelX2);
                GForm.AddButtonMaximizeMinimize(labelX4);

                //Primary Menus
                assignButtonClick(btnDashboard, new object[] { GForm.FrmDashboard, "Dashboard", "" });
                assignButtonClick(btnAdmin, new object[] { GForm.FrmAdmin, "Administrator", "" });
                assignButtonClick(btnEmployee, new object[] { GForm.FrmEmployee, "Manage Employee", "" });
                assignButtonClick(btnSales, new object[] { GForm.FrmSales, "Manage Sales", "" });
                assignButtonClick(btnLeads, new object[] { GForm.FrmLead, "Manage Leads", "" },true);
                assignButtonClick(btnFulfillment, new object[] { GForm.FrmFulfillment, "Manage Fulfillment", "" });
                assignButtonClick(btnProduction, new object[] { GForm.FrmProduction, "Manage Projects", "" });
                assignButtonClick(btnTrack, new object[] { GForm.FrmTrack, "Track Sales", "" });
                assignButtonClick(btnMemo, new object[] { GForm.FrmMemo, "Manage Memo", "" });
                assignButtonClick(btnSetting, new object[] { GForm.FrmSetting, "Settings", "" });
                assignButtonClick(btnReports, new object[] { GForm.FrmReports, "Manage Reports", "" });
                btnAccountInfo.Text = UserProfile.Fullname;
            });
            btnDashboard.PerformClick();
        }

        private void btn_MouseClick(object sender, EventArgs e)
        {
            var btn_convert = sender as DevComponents.DotNetBar.ButtonX;
            if (btn_convert.Tag != null)
            {
                string form_name = BFunc.Tag.Get(btn_convert, BFunc.Tag.Key.ParentForm).ToString();
                if (btn_convert.Parent.Name == this.sideNav.Name)
                {
                    if (!BFunc.Tag.Is(this, BFunc.Tag.Key.LastForm, null))
                    {
                        string last_frm = (string)BFunc.Tag.Get(this, BFunc.Tag.Key.LastForm);
                        if (GForm.forms.ContainsKey(last_frm))
                        {
                            var ctrl_transfered = this.Controls.Find("pnlMain" + last_frm, true);
                            if (ctrl_transfered.Length != 0)
                            {
                                //MessageBox.Show("last_form"+ last_frm);
                                ctrl_transfered[0].Name = "pnlMain";
                                ctrl_transfered[0].Parent = GForm.forms[last_frm];
                            }
                        }
                    }
                    BFunc.Tag.Set(this, BFunc.Tag.Key.LastForm, form_name);
                }
                if (!GForm.forms.ContainsKey(form_name)) GForm.FetchForm(form_name, true);

                var form = GForm.forms[form_name];

                object obj = BFunc.Tag.Get(btn_convert, BFunc.Tag.Key.FuncBeforeShow);
                if (obj != null) (obj as Action)();

                if (BFunc.Tag.Is(btn_convert, BFunc.Tag.Key.IsPopUpForm,true))
                {
                    BFunc.Tag.Set(form, BFunc.Tag.Key.IsPopUpForm, true);
                    GForm.Current = form;
                    var ctrl = form.Controls.Find("pnlMain", true);
                    if (ctrl.Length != 0)
                        ctrl[0].Visible = true;
                    form.StartPosition = FormStartPosition.CenterScreen;
                    GForm.BackDrop.Show();
                    form.ShowDialog();
                    obj = BFunc.Tag.Get(btn_convert, BFunc.Tag.Key.FuncOnClose);
                    if (obj != null) (obj as Action)();
                    GForm.Current = this;
                }
                else
                {
                    GForm.CloseFormPanels();
                    var ctrl = form.Controls.Find("pnlMain", true);
                    var ctrl_transfered = this.Controls.Find("pnlMain" + form_name, true);
                    if (ctrl.Length != 0 || ctrl_transfered.Length != 0)
                    {
                        if (ctrl.Length != 0)
                        {
                            ctrl[0].Name = ctrl[0].Name + form_name;
                            ctrl[0].Parent = this.mainWrap;
                            ctrl[0].Show();
                        }
                        else
                        {
                            ctrl_transfered[0].Name = ctrl_transfered[0].Name;
                            ctrl_transfered[0].Show();
                        }
                        if (BFunc.Tag.Get(btn_convert, BFunc.Tag.Key.BreadcrumbLabel) != null)
                            lblCrump.Text = BFunc.Tag.Get(btn_convert, BFunc.Tag.Key.BreadcrumbLabel).ToString();
                        if (BFunc.Tag.Get(btn_convert, BFunc.Tag.Key.BreadcrumbLabel) != null)
                            lblSymbol.Symbol = BFunc.Tag.Get(btn_convert, BFunc.Tag.Key.BreadcrumbIcon).ToString();
                    }
                    else { MessageBox.Show("Message: Panel Main does not exist"); }
                }
            }
            else { MessageBox.Show("Message: " + btn_convert.Name + " Event Not Assigned for this button"); }
        }

        public void assignButtonClick(Control ctrl, Form frm, bool isFormReloadOnClick = false, bool isPopUpForm = false, Action funcBeforeShow = null, Action funcOnClose = null)
        {
            assignButtonClick(ctrl, new object[] { frm }, isFormReloadOnClick, isPopUpForm, funcBeforeShow, funcOnClose);
        }

        public void assignButtonClick(Control ctrl, object[] obj,bool isFormReloadOnClick = false, bool isPopUpForm = false, Action funcBeforeShow = null, Action funcOnClose = null)
        {
            string frm_name = (obj[0] as Form).Name;
            BFunc.Tag.Set(ctrl, BFunc.Tag.Key.ParentForm, frm_name);
            BFunc.Tag.Set(ctrl, BFunc.Tag.Key.IsPopUpForm, isPopUpForm);
            BFunc.Tag.Set(ctrl, BFunc.Tag.Key.FuncBeforeShow, funcBeforeShow);
            BFunc.Tag.Set(ctrl, BFunc.Tag.Key.FuncOnClose, funcOnClose);
            BFunc.Tag.Set(GForm.forms[frm_name], BFunc.Tag.Key.IsFormReloadOnClick, isFormReloadOnClick);

            if (obj.Length >= 2)
                BFunc.Tag.Set(ctrl, BFunc.Tag.Key.BreadcrumbLabel, obj[1]);
            if (obj.Length >= 3)
                BFunc.Tag.Set(ctrl, BFunc.Tag.Key.BreadcrumbIcon, obj[2]);

            if(ctrl.Parent.Name == this.sideNav.Name)
            {
                ctrl.MouseLeave += new EventHandler((object sender, EventArgs e) =>
                {
                    var btn_convert = sender as DevComponents.DotNetBar.ButtonX;
                    btn_convert.BackColor = Color.Transparent;
                    btn_convert.SymbolColor = Color.Gainsboro;
                });
                ctrl.MouseEnter += new EventHandler((object sender, EventArgs e) =>
                {
                    var btn_convert = sender as DevComponents.DotNetBar.ButtonX;
                    btn_convert.BackColor = Color.LightSeaGreen;
                    btn_convert.SymbolColor = Color.White;
                });
            }

            ctrl.Click += new EventHandler(btn_MouseClick);
        }
    }
}
