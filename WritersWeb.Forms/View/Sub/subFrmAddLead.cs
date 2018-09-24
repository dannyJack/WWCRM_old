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
    public partial class subFrmAddLead : Form
    {
        public subFrmAddLead()
        {
            InitializeComponent();
            GForm.LoadForm(this, GForm.Type.Sub, () =>
            {
                GForm.HideFormBorder(this);
                GForm.AddDraggable(this.pnlMain);
                GForm.AddDraggable(lblTitle);
                GForm.AddButtonClose(btnClose);
            }, () => {
                GForm.SubFrmAuthorDetails.txtLName.Focus();
            });
        }
    }
}
