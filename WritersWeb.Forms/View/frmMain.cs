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
            GForm.LoadForm(this, () => {
                GForm.AddDraggable(panelEx1);
                GForm.AddButtonClose(labelX5);
                GForm.AddButtonMaximumMinimum(labelX2);
                GForm.AddButtonMaximizeMinimize(labelX4);

                //Primary Menus
                assignButtonClick(btnDashboard, new object[] { GForm.FrmDashboard, "Dashboard", "" });
                assignButtonClick(btnAdmin, new object[] { GForm.FrmAdmin, "Administrator", "" });
                assignButtonClick(btnEmployee, new object[] { GForm.FrmEmployee, "Manage Employee", "" });
                assignButtonClick(btnSales, new object[] { GForm.FrmSales, "Manage Sales", "" });
                assignButtonClick(btnLeads, new object[] { GForm.FrmLead, "Manage Leads", "" });
                assignButtonClick(btnFulfillment, new object[] { GForm.FrmFulfillment, "Manage Fulfillment", "" });
                assignButtonClick(btnProduction, new object[] { GForm.FrmProduction, "Manage Projects", "" });
                assignButtonClick(btnTrack, new object[] { GForm.FrmTrack, "Track Sales", "" });
                assignButtonClick(btnMemo, new object[] { GForm.FrmMemo, "Manage Memo", "" });
                assignButtonClick(btnSetting, new object[] { GForm.FrmSetting, "Settings", "" });
                assignButtonClick(btnReports, new object[] { GForm.FrmReports, "Manage Reports", "" });
                btnAccountInfo.Text = UserProfile.Fullname;
            }, GForm.Type.Main);
            btnDashboard.PerformClick();
        }

        private void btn_MouseClick(object sender, EventArgs e)
        {
            var btn_convert = sender as DevComponents.DotNetBar.ButtonX;
            if (btn_convert.Tag != null)
            {
                string form_name = BaseFunction.Tag.Get(btn_convert, BaseFunction.Tag.Key.FormName).ToString();
                var form = GForm.forms[form_name];
                object obj = BaseFunction.Tag.Get(btn_convert, BaseFunction.Tag.Key.FuncBeforeShow);
                if (obj != null) (obj as Action)();
                if ((bool)BaseFunction.Tag.Get(btn_convert, BaseFunction.Tag.Key.IsPopUpForm))
                {
                    GForm.Current = form;
                    var ctrl = form.Controls.Find("pnlMain", true);
                    if (ctrl.Length != 0)
                        ctrl[0].Visible = true;
                    form.StartPosition = FormStartPosition.CenterScreen;
                    GForm.BackDrop.Show();
                    form.ShowDialog();
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
                        if (BaseFunction.Tag.Get(btn_convert, BaseFunction.Tag.Key.BreadcrumbLabel) != null)
                            lblCrump.Text = BaseFunction.Tag.Get(btn_convert, BaseFunction.Tag.Key.BreadcrumbLabel).ToString();
                        if (BaseFunction.Tag.Get(btn_convert, BaseFunction.Tag.Key.BreadcrumbLabel) != null)
                            lblSymbol.Symbol = BaseFunction.Tag.Get(btn_convert, BaseFunction.Tag.Key.BreadcrumbIcon).ToString();
                    }
                    else { MessageBox.Show("Message: Panel Main does not exist"); }
                }
            }
            else { MessageBox.Show("Message: " + btn_convert.Name + " Event Not Assigned for this button"); }
        }

        private void assignButtonClick(Control ctrl, object[] obj)
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
            assignButtonClick(ctrl, obj, false);
        }

        public void assignButtonClick(Control ctrl, object[] obj, bool isPopUpForm, Action funcBeforeShow = null)
        {
            BaseFunction.Tag.Set(ctrl, BaseFunction.Tag.Key.FormName, (obj[0] as Form).Name);
            BaseFunction.Tag.Set(ctrl, BaseFunction.Tag.Key.IsPopUpForm, isPopUpForm);
            BaseFunction.Tag.Set(ctrl, BaseFunction.Tag.Key.FuncBeforeShow, funcBeforeShow);
            if (obj.Length >= 2)
                BaseFunction.Tag.Set(ctrl, BaseFunction.Tag.Key.BreadcrumbLabel, obj[1]);
            if (obj.Length >= 3)
                BaseFunction.Tag.Set(ctrl, BaseFunction.Tag.Key.BreadcrumbIcon, obj[2]);

            ctrl.Click += new EventHandler(btn_MouseClick);
        }
    }
}
