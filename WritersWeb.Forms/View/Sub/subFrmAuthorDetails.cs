﻿using System;
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
            GForm.LoadForm(this, () => {
                GForm.HideFormBorder(this);
                GForm.AddDraggable(pnlMain);
                GForm.AddDraggable(lblTitle);
                GForm.AddButtonClose(lblClose);
            }, GForm.Type.Sub);
        }
    }
}